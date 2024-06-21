using FIT.Data.IspitIB210156;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB210156
{
    public partial class frmPrisustvoIB210156 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private ProstorijeIB210156? prostorija;

        public frmPrisustvoIB210156(ProstorijeIB210156? prostorija)
        {
            InitializeComponent();
            this.prostorija = prostorija;
            lblProstorija.Text = $"{prostorija.Naziv} - {prostorija.Oznaka}";
            UnesiNastavuUCmb();
            UnesiStudenteUCmb();
            UnesiPrisustvaUDgv();
            if (cmbNastava.Items.Count > 0)
            {
                cmbNastava.SelectedIndex = 0;
            }
            ProvjeriKapacitet(null, EventArgs.Empty);
            cmbNastava.SelectedIndexChanged += ProvjeriKapacitet;
        }
        private void ProvjeriKapacitet(object sender, EventArgs e)
        {
            var nastavaId = Convert.ToInt32(cmbNastava.SelectedValue);

            var brojac = db.PrisustvoIB210156.Where(n => n.NastavaId == nastavaId).Count();

            lblBrojStudenata.Text = $"{brojac}/{prostorija.Kapacitet}";
        }
        private void UnesiPrisustvaUDgv()
        {
            var prisustva = db.PrisustvoIB210156.Where(n => n.Nastava.ProstorijaId == prostorija.Id).ToList();

            dgvPrisustvo.Rows.Clear();
            foreach (var pri in prisustva)
            {
                dgvPrisustvo.Rows.Add(
                    pri.Nastava.Oznaka,
                    $"{pri.Student.Indeks} {pri.Student.Ime} {pri.Student.Prezime}"
                    );
            }
            dgvPrisustvo.Refresh();

        }

        private void UnesiStudenteUCmb()
        {
            var studenti = db.Studenti.ToList();
            cmbStudent.ValueMember = "Id";
            cmbStudent.DisplayMember = "Indeks" + " " + "Ime" + " " + "Prezime";
            cmbStudent.DataSource = studenti;
        }

        private void UnesiNastavuUCmb()
        {
            var nastava = db.NastavaIB210156.Where(n => n.ProstorijaId == prostorija.Id).ToList();
            cmbNastava.ValueMember = "Id";
            cmbNastava.DisplayMember = "Oznaka";
            cmbNastava.DataSource = nastava;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var nasId = Convert.ToInt32(cmbNastava.SelectedValue);
            var brojac = db.PrisustvoIB210156.Where(n => n.NastavaId == nasId).Count();
            var studId = Convert.ToInt32(cmbStudent.SelectedValue);

            var postojeci = db.PrisustvoIB210156.FirstOrDefault(s => s.NastavaId == nasId && s.StudentId == studId);
            if (postojeci != null)
            {
                MessageBox.Show("Student je već pohranjen za odabranu nastavu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (brojac == prostorija.Kapacitet)
            {
                MessageBox.Show("Mjesta su popunjena za odabranu nastavu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PrisustvoIB210156 prisustvo = new PrisustvoIB210156
            {
                NastavaId = nasId,
                StudentId = studId
            };
            db.PrisustvoIB210156.Add(prisustvo);
            db.SaveChanges();
            UnesiPrisustvaUDgv();
            ProvjeriKapacitet(null, EventArgs.Empty);
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var studId = Convert.ToInt32(cmbStudent.SelectedValue);
            int brojZapisa=Convert.ToInt32(txtBrojZapisa.Text);
            var nastId=Convert.ToInt32(cmbNastava.SelectedValue);
                
            await (Task.Run(() => DodajPrisustvo(studId,nastId,brojZapisa)));

         
            UnesiPrisustvaUDgv();
            ProvjeriKapacitet(null, EventArgs.Empty);
        }
        private string DohvatiPodatkeStudenta(int studId)
        {
            var student=db.Studenti.Find(studId);

            return $"{student.Indeks} {student.Ime} {student.Prezime}";
        }
        private string DohvatiPodatkeNastave(int nastId)
        {
            var nastava=db.NastavaIB210156.Find(nastId);

            return $"{nastava.Oznaka}";
        }

        private void DodajPrisustvo(int studId, int nastId,int brojZapisa)
        {
            var PodaciStudenta = DohvatiPodatkeStudenta(studId);
            var PodaciNastave = DohvatiPodatkeNastave(nastId);

            for (int i = 0; i <brojZapisa; i++)
            {
                PrisustvoIB210156 prisustvo = new PrisustvoIB210156 { 
                NastavaId=nastId,
                StudentId=studId
                };

                db.PrisustvoIB210156.Add(prisustvo);
                db.SaveChanges();

                string novaPoruka = $"{DateTime.Now.ToString("dd.MM HH:mm:ss")} -> {PodaciStudenta} {PodaciNastave}{Environment.NewLine}";
                Task.Delay(300).Wait();

                Invoke(new Action(() =>
                {
                    txtInfo.Text += novaPoruka;
                    txtInfo.SelectionStart = txtInfo.Text.Length;
                    txtInfo.ScrollToCaret();
                }));
            }
            MessageBox.Show("Dodavanje prisustava završeno.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
