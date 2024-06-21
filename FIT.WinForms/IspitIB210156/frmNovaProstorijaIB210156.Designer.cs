namespace FIT.WinForms.IspitIB210156
{
    partial class frmNovaProstorijaIB210156
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pbLogo = new PictureBox();
            label2 = new Label();
            txtNaziv = new TextBox();
            label3 = new Label();
            txtOznaka = new TextBox();
            label4 = new Label();
            txtKapacitet = new TextBox();
            btnSacuvaj = new Button();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 29);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Logo:";
            // 
            // pbLogo
            // 
            pbLogo.BorderStyle = BorderStyle.FixedSingle;
            pbLogo.Location = new Point(24, 62);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(208, 192);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            pbLogo.DoubleClick += pbLogo_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 77);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(275, 100);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(337, 27);
            txtNaziv.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 149);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Oznaka:";
            // 
            // txtOznaka
            // 
            txtOznaka.Location = new Point(275, 172);
            txtOznaka.Name = "txtOznaka";
            txtOznaka.Size = new Size(141, 27);
            txtOznaka.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 149);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 6;
            label4.Text = "Kapacitet:";
            // 
            // txtKapacitet
            // 
            txtKapacitet.Location = new Point(471, 172);
            txtKapacitet.Name = "txtKapacitet";
            txtKapacitet.Size = new Size(141, 27);
            txtKapacitet.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(518, 225);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 8;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmNovaProstorijaIB210156
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 287);
            Controls.Add(btnSacuvaj);
            Controls.Add(txtKapacitet);
            Controls.Add(label4);
            Controls.Add(txtOznaka);
            Controls.Add(label3);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(pbLogo);
            Controls.Add(label1);
            Name = "frmNovaProstorijaIB210156";
            Text = "Podaci o prostoriji";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbLogo;
        private Label label2;
        private TextBox txtNaziv;
        private Label label3;
        private TextBox txtOznaka;
        private Label label4;
        private TextBox txtKapacitet;
        private Button btnSacuvaj;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}