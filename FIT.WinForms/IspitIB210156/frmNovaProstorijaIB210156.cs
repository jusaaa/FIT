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
using FIT.WinForms.Helpers;
using FIT.Data.IspitIB210156;

namespace FIT.WinForms.IspitIB210156
{
    public partial class frmNovaProstorijaIB210156 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmNovaProstorijaIB210156()
        {
            InitializeComponent();
        }
        bool ValidirajFormu()
        {
            if (!Helpers.Validator.ProvjeriUnos(txtNaziv, errorProvider1, "Unesite naziv prostorije!"))
            {
                return false;
            }
            if (!Helpers.Validator.ProvjeriUnos(txtOznaka, errorProvider1, "Unesite oznaku prostorije!"))
            {
                return false;
            }
            if (!Helpers.Validator.ProvjeriUnos(txtKapacitet, errorProvider1, "Unesite kapacitet prostorije!"))
            {
                return false;
            }
            if (!Helpers.Validator.ProvjeriUnos(pbLogo, errorProvider1, "Unesite sliku prostorije!"))
            {
                return false;
            }

            return true;
        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(!ValidirajFormu())
            {
                MessageBox.Show("Molimo Vas unesite sve potrebne podatke!","Pogrešan unos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            ProstorijeIB210156 novaProstorija = new ProstorijeIB210156
            {
                Naziv=txtNaziv.Text,
                Oznaka=txtOznaka.Text,
                Logo=Helpers.Ekstenzije.ToByteArray(pbLogo.Image),
                Kapacitet=Convert.ToInt32(txtKapacitet.Text)
            };
            db.ProstorijeIB210156.Add(novaProstorija);
            db.SaveChanges();
            this.Close();
        }
    }
}
