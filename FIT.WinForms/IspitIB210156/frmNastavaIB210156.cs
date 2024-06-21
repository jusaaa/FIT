using FIT.Data.IspitIB210156;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmNastavaIB210156 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private ProstorijeIB210156? prostorija;
        public frmNastavaIB210156(ProstorijeIB210156? prostorija)
        {
            InitializeComponent();
            this.prostorija = prostorija;
            lblProstorija.Text = $"{prostorija.Naziv} - {prostorija.Oznaka}";
            PopuniPredmeteCmb();
            cmbDan.SelectedIndex = 0;
            cmbVrijeme.SelectedIndex = 0;
            UnesiNastavuUDgv();
        }

        private void UnesiNastavuUDgv()
        {
            var nastava = db.NastavaIB210156.Where(p => p.ProstorijaId == prostorija.Id)
                 .ToList();

            dgvNastava.Rows.Clear();
            foreach (var nas in nastava)
            {
                dgvNastava.Rows.Add(
                    nas.Predmet.Naziv,
                    nas.Dan,
                    nas.Vrijeme
                    );
            }
            dgvNastava.Refresh();
        }

        private void PopuniPredmeteCmb()
        {
            var predmeti = db.Predmeti.ToList();
            cmbPredmet.ValueMember = "Id";
            cmbPredmet.DisplayMember = "Naziv";
            cmbPredmet.DataSource = predmeti;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var zauzetTermin=db.NastavaIB210156.Where(n=>n.ProstorijaId==prostorija.Id).FirstOrDefault(n=>n.Vrijeme.Equals(cmbVrijeme.Text) && n.Dan.Equals(cmbDan.Text));
            if (zauzetTermin != null)
            {
                MessageBox.Show("Nastava u ovom vremenskom periodu već postoji!","Info",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NastavaIB210156 novaNastava = new NastavaIB210156 
            {
                ProstorijaId=prostorija.Id,
                PredmetId=Convert.ToInt32(cmbPredmet.SelectedValue),
                Vrijeme=cmbVrijeme.Text,
                Dan=cmbDan.Text,
                Oznaka=$"{cmbPredmet.Text} :: {cmbDan.Text} :: {cmbVrijeme.Text}"
            };
            db.NastavaIB210156.Add(novaNastava);
            db.SaveChanges();
            UnesiNastavuUDgv();
        }
    }
}
