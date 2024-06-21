namespace FIT.WinForms.IspitIB210156
{
    partial class frmNastavaIB210156
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
            lblProstorija = new Label();
            label1 = new Label();
            cmbPredmet = new ComboBox();
            label2 = new Label();
            cmbDan = new ComboBox();
            label3 = new Label();
            cmbVrijeme = new ComboBox();
            btnDodaj = new Button();
            dgvNastava = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvNastava).BeginInit();
            SuspendLayout();
            // 
            // lblProstorija
            // 
            lblProstorija.AutoSize = true;
            lblProstorija.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProstorija.Location = new Point(22, 24);
            lblProstorija.Name = "lblProstorija";
            lblProstorija.Size = new Size(0, 41);
            lblProstorija.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 86);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 1;
            label1.Text = "Predmet:";
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(22, 109);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(236, 28);
            cmbPredmet.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 86);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 3;
            label2.Text = "Dan:";
            // 
            // cmbDan
            // 
            cmbDan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDan.FormattingEnabled = true;
            cmbDan.Items.AddRange(new object[] { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" });
            cmbDan.Location = new Point(287, 109);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(137, 28);
            cmbDan.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 86);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Vrijeme:";
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Items.AddRange(new object[] { "08-10", "10-12", "12-14", "14-16" });
            cmbVrijeme.Location = new Point(446, 109);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(137, 28);
            cmbVrijeme.TabIndex = 6;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = SystemColors.ButtonHighlight;
            btnDodaj.Location = new Point(605, 108);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvNastava
            // 
            dgvNastava.AllowUserToAddRows = false;
            dgvNastava.AllowUserToDeleteRows = false;
            dgvNastava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastava.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvNastava.Location = new Point(22, 158);
            dgvNastava.Name = "dgvNastava";
            dgvNastava.ReadOnly = true;
            dgvNastava.RowHeadersWidth = 51;
            dgvNastava.RowTemplate.Height = 29;
            dgvNastava.Size = new Size(677, 267);
            dgvNastava.TabIndex = 8;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.MinimumWidth = 6;
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Dan
            // 
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.MinimumWidth = 6;
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            Dan.Width = 125;
            // 
            // Vrijeme
            // 
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.MinimumWidth = 6;
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            Vrijeme.Width = 125;
            // 
            // frmNastavaIB210156
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 450);
            Controls.Add(dgvNastava);
            Controls.Add(btnDodaj);
            Controls.Add(cmbVrijeme);
            Controls.Add(label3);
            Controls.Add(cmbDan);
            Controls.Add(label2);
            Controls.Add(cmbPredmet);
            Controls.Add(label1);
            Controls.Add(lblProstorija);
            Name = "frmNastavaIB210156";
            Text = "Nastava";
            ((System.ComponentModel.ISupportInitialize)dgvNastava).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProstorija;
        private Label label1;
        private ComboBox cmbPredmet;
        private Label label2;
        private ComboBox cmbDan;
        private Label label3;
        private ComboBox cmbVrijeme;
        private Button btnDodaj;
        private DataGridView dgvNastava;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
    }
}