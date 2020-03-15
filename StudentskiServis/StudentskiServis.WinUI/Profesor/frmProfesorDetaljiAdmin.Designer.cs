namespace StudentskiServis.WinUI.Profesor
{
    partial class frmProfesorDetaljiAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.cBoxOdrzano = new System.Windows.Forms.CheckBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum predavanja";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(31, 58);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(189, 20);
            this.txtDatum.TabIndex = 1;
            // 
            // cBoxOdrzano
            // 
            this.cBoxOdrzano.AutoSize = true;
            this.cBoxOdrzano.Location = new System.Drawing.Point(496, 61);
            this.cBoxOdrzano.Name = "cBoxOdrzano";
            this.cBoxOdrzano.Size = new System.Drawing.Size(66, 17);
            this.cBoxOdrzano.TabIndex = 3;
            this.cBoxOdrzano.Text = "Održano";
            this.cBoxOdrzano.UseVisualStyleBackColor = true;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(257, 58);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.ReadOnly = true;
            this.txtVrsta.Size = new System.Drawing.Size(189, 20);
            this.txtVrsta.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vrsta";
            // 
            // rtbOpis
            // 
            this.rtbOpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOpis.Location = new System.Drawing.Point(3, 16);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.ReadOnly = true;
            this.rtbOpis.Size = new System.Drawing.Size(525, 223);
            this.rtbOpis.TabIndex = 6;
            this.rtbOpis.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbOpis);
            this.groupBox1.Location = new System.Drawing.Point(31, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 242);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opis";
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(595, 177);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(111, 44);
            this.btnIzmijeni.TabIndex = 8;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(595, 244);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(111, 44);
            this.btnBrisi.TabIndex = 9;
            this.btnBrisi.Text = "Obriši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // frmProfesorDetaljiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 378);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxOdrzano);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label1);
            this.Name = "frmProfesorDetaljiAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfesorDetaljiAdmin";
            this.Load += new System.EventHandler(this.frmProfesorDetaljiAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.CheckBox cBoxOdrzano;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnBrisi;
    }
}