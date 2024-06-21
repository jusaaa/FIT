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
    public partial class frmProstorijeIB210156 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmProstorijeIB210156()
        {
            InitializeComponent();
            UnesiProstorijeUDgv();
        }

        private void UnesiProstorijeUDgv()
        {
            var prostorije = db.ProstorijeIB210156.ToList();

            dgvProstorije.Rows.Clear();
            foreach (var pro in prostorije)
            {
                var brojPredmeta = db.NastavaIB210156.Where(n => n.ProstorijaId == pro.Id).Count();

                dgvProstorije.Rows.Add(
                    pro.Id,
                    pro.Logo,
                    pro.Naziv,
                    pro.Oznaka,
                    pro.Kapacitet,
                    brojPredmeta
                    );
            }
            dgvProstorije.Refresh();
        }

        private void btnNovaProstorija_Click(object sender, EventArgs e)
        {
            frmNovaProstorijaIB210156 frmNovaProstorijaIB210156 = new frmNovaProstorijaIB210156();
            DialogResult rezultat = frmNovaProstorijaIB210156.ShowDialog();
            if (rezultat == DialogResult.Cancel)
            {
                UnesiProstorijeUDgv();
            }
        }

        private void dgvProstorije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int prostorijaId = Convert.ToInt32(dgvProstorije.Rows[e.RowIndex].Cells["Id"].Value);
            var prostorija = db.ProstorijeIB210156.Find(prostorijaId);

            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProstorije.Columns["Nastava"].Index) 
            {
                frmNastavaIB210156 frmNastavaIB210156=new frmNastavaIB210156(prostorija);
                frmNastavaIB210156.ShowDialog();
            }
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvProstorije.Columns["Prisustvo"].Index)
            {
                frmPrisustvoIB210156 frmPrisustvoIB210156 = new frmPrisustvoIB210156(prostorija);
                frmPrisustvoIB210156.ShowDialog();
            }
        }
    }
}
