namespace FIT.WinForms.IspitIB210156
{
    partial class frmProstorijeIB210156
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNovaProstorija = new Button();
            dgvProstorije = new DataGridView();
            btnPrintaj = new Button();
            Id = new DataGridViewTextBoxColumn();
            Logo = new DataGridViewImageColumn();
            Naziv = new DataGridViewTextBoxColumn();
            Oznaka = new DataGridViewTextBoxColumn();
            Kapacitet = new DataGridViewTextBoxColumn();
            BrPredmeta = new DataGridViewTextBoxColumn();
            Nastava = new DataGridViewButtonColumn();
            Prisustvo = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).BeginInit();
            SuspendLayout();
            // 
            // btnNovaProstorija
            // 
            btnNovaProstorija.BackColor = SystemColors.ButtonFace;
            btnNovaProstorija.Location = new Point(784, 24);
            btnNovaProstorija.Name = "btnNovaProstorija";
            btnNovaProstorija.Size = new Size(148, 29);
            btnNovaProstorija.TabIndex = 0;
            btnNovaProstorija.Text = "Nova prostorija";
            btnNovaProstorija.UseVisualStyleBackColor = false;
            btnNovaProstorija.Click += btnNovaProstorija_Click;
            // 
            // dgvProstorije
            // 
            dgvProstorije.AllowUserToAddRows = false;
            dgvProstorije.AllowUserToDeleteRows = false;
            dgvProstorije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProstorije.Columns.AddRange(new DataGridViewColumn[] { Id, Logo, Naziv, Oznaka, Kapacitet, BrPredmeta, Nastava, Prisustvo });
            dgvProstorije.Location = new Point(12, 77);
            dgvProstorije.Name = "dgvProstorije";
            dgvProstorije.ReadOnly = true;
            dgvProstorije.RowHeadersWidth = 51;
            dgvProstorije.RowTemplate.Height = 29;
            dgvProstorije.Size = new Size(920, 311);
            dgvProstorije.TabIndex = 1;
            dgvProstorije.CellContentClick += dgvProstorije_CellContentClick;
            // 
            // btnPrintaj
            // 
            btnPrintaj.BackColor = SystemColors.ButtonFace;
            btnPrintaj.Location = new Point(801, 409);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(131, 29);
            btnPrintaj.TabIndex = 2;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = false;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Logo
            // 
            Logo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Logo.DataPropertyName = "Logo";
            Logo.HeaderText = "Logo";
            Logo.MinimumWidth = 6;
            Logo.Name = "Logo";
            Logo.ReadOnly = true;
            Logo.Width = 49;
            // 
            // Naziv
            // 
            Naziv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Naziv.DataPropertyName = "Naziv";
            Naziv.HeaderText = "Naziv";
            Naziv.MinimumWidth = 6;
            Naziv.Name = "Naziv";
            Naziv.ReadOnly = true;
            Naziv.Resizable = DataGridViewTriState.True;
            Naziv.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Oznaka
            // 
            Oznaka.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Oznaka.DataPropertyName = "Oznaka";
            Oznaka.HeaderText = "Oznaka";
            Oznaka.MinimumWidth = 6;
            Oznaka.Name = "Oznaka";
            Oznaka.ReadOnly = true;
            Oznaka.Resizable = DataGridViewTriState.True;
            Oznaka.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Kapacitet
            // 
            Kapacitet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Kapacitet.DataPropertyName = "Kapacitet";
            Kapacitet.HeaderText = "Kapacitet";
            Kapacitet.MinimumWidth = 6;
            Kapacitet.Name = "Kapacitet";
            Kapacitet.ReadOnly = true;
            Kapacitet.Resizable = DataGridViewTriState.True;
            Kapacitet.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // BrPredmeta
            // 
            BrPredmeta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrPredmeta.DataPropertyName = "BrPredmeta";
            BrPredmeta.HeaderText = "Br.Predmeta";
            BrPredmeta.MinimumWidth = 6;
            BrPredmeta.Name = "BrPredmeta";
            BrPredmeta.ReadOnly = true;
            BrPredmeta.Resizable = DataGridViewTriState.True;
            BrPredmeta.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Nastava
            // 
            Nastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nastava.DataPropertyName = "Nastava";
            Nastava.HeaderText = "";
            Nastava.MinimumWidth = 6;
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            Nastava.Text = "Nastava";
            Nastava.UseColumnTextForButtonValue = true;
            // 
            // Prisustvo
            // 
            Prisustvo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Prisustvo.DataPropertyName = "Prisustvo";
            Prisustvo.HeaderText = "";
            Prisustvo.MinimumWidth = 6;
            Prisustvo.Name = "Prisustvo";
            Prisustvo.ReadOnly = true;
            Prisustvo.Text = "Prisustvo";
            Prisustvo.UseColumnTextForButtonValue = true;
            // 
            // frmProstorijeIB210156
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 450);
            Controls.Add(btnPrintaj);
            Controls.Add(dgvProstorije);
            Controls.Add(btnNovaProstorija);
            Name = "frmProstorijeIB210156";
            Text = "Prostorije";
            ((System.ComponentModel.ISupportInitialize)dgvProstorije).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovaProstorija;
        private DataGridView dgvProstorije;
        private Button btnPrintaj;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewImageColumn Logo;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Oznaka;
        private DataGridViewTextBoxColumn Kapacitet;
        private DataGridViewTextBoxColumn BrPredmeta;
        private DataGridViewButtonColumn Nastava;
        private DataGridViewButtonColumn Prisustvo;
    }
}