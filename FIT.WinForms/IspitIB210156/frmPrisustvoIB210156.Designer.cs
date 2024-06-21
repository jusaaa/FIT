namespace FIT.WinForms.IspitIB210156
{
    partial class frmPrisustvoIB210156
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
            lblBrojStudenata = new Label();
            label1 = new Label();
            cmbNastava = new ComboBox();
            label2 = new Label();
            cmbStudent = new ComboBox();
            btnDodaj = new Button();
            dgvPrisustvo = new DataGridView();
            PredmetProstorijaVrijeme = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            txtInfo = new TextBox();
            label4 = new Label();
            btnGenerisi = new Button();
            txtBrojZapisa = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblProstorija
            // 
            lblProstorija.AutoSize = true;
            lblProstorija.Font = new Font("Segoe UI", 20F);
            lblProstorija.Location = new Point(21, 35);
            lblProstorija.Name = "lblProstorija";
            lblProstorija.Size = new Size(0, 46);
            lblProstorija.TabIndex = 0;
            // 
            // lblBrojStudenata
            // 
            lblBrojStudenata.AutoSize = true;
            lblBrojStudenata.Font = new Font("Segoe UI", 20F);
            lblBrojStudenata.Location = new Point(688, 35);
            lblBrojStudenata.Name = "lblBrojStudenata";
            lblBrojStudenata.Size = new Size(0, 46);
            lblBrojStudenata.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 105);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Nastava:";
            // 
            // cmbNastava
            // 
            cmbNastava.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(21, 128);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(306, 28);
            cmbNastava.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 105);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "Student:";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(355, 128);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(306, 28);
            cmbStudent.TabIndex = 5;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(688, 127);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(94, 29);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPrisustvo
            // 
            dgvPrisustvo.AllowUserToAddRows = false;
            dgvPrisustvo.AllowUserToDeleteRows = false;
            dgvPrisustvo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustvo.Columns.AddRange(new DataGridViewColumn[] { PredmetProstorijaVrijeme, Student });
            dgvPrisustvo.Location = new Point(21, 176);
            dgvPrisustvo.Name = "dgvPrisustvo";
            dgvPrisustvo.ReadOnly = true;
            dgvPrisustvo.RowHeadersWidth = 51;
            dgvPrisustvo.RowTemplate.Height = 29;
            dgvPrisustvo.Size = new Size(761, 279);
            dgvPrisustvo.TabIndex = 7;
            // 
            // PredmetProstorijaVrijeme
            // 
            PredmetProstorijaVrijeme.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PredmetProstorijaVrijeme.DataPropertyName = "PredmetProstorijaVrijeme";
            PredmetProstorijaVrijeme.HeaderText = "Predmet,prostorija,vrijeme";
            PredmetProstorijaVrijeme.MinimumWidth = 6;
            PredmetProstorijaVrijeme.Name = "PredmetProstorijaVrijeme";
            PredmetProstorijaVrijeme.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.MinimumWidth = 6;
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(txtBrojZapisa);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(30, 481);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(752, 238);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(7, 100);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(739, 132);
            txtInfo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 77);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 8;
            label4.Text = "Info:";
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(203, 35);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 7;
            btnGenerisi.Text = "Generiši";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // txtBrojZapisa
            // 
            txtBrojZapisa.Location = new Point(97, 35);
            txtBrojZapisa.Name = "txtBrojZapisa";
            txtBrojZapisa.Size = new Size(84, 27);
            txtBrojZapisa.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 38);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 0;
            label3.Text = "Broj zapisa:";
            // 
            // frmPrisustvoIB210156
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 731);
            Controls.Add(groupBox1);
            Controls.Add(dgvPrisustvo);
            Controls.Add(btnDodaj);
            Controls.Add(cmbStudent);
            Controls.Add(label2);
            Controls.Add(cmbNastava);
            Controls.Add(label1);
            Controls.Add(lblBrojStudenata);
            Controls.Add(lblProstorija);
            Name = "frmPrisustvoIB210156";
            Text = "Evidencija nastave";
            ((System.ComponentModel.ISupportInitialize)dgvPrisustvo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProstorija;
        private Label lblBrojStudenata;
        private Label label1;
        private ComboBox cmbNastava;
        private Label label2;
        private ComboBox cmbStudent;
        private Button btnDodaj;
        private DataGridView dgvPrisustvo;
        private DataGridViewTextBoxColumn PredmetProstorijaVrijeme;
        private DataGridViewTextBoxColumn Student;
        private GroupBox groupBox1;
        private TextBox txtBrojZapisa;
        private Label label3;
        private TextBox txtInfo;
        private Label label4;
        private Button btnGenerisi;
    }
}