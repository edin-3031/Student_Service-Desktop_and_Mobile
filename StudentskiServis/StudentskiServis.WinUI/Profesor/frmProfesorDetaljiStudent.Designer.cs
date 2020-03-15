namespace StudentskiServis.WinUI.Profesor
{
    partial class frmProfesorDetaljiStudent
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
            this.picSlika = new System.Windows.Forms.PictureBox();
            this.txtKancelarija = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZvanje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // picSlika
            // 
            this.picSlika.Location = new System.Drawing.Point(238, 52);
            this.picSlika.Name = "picSlika";
            this.picSlika.Size = new System.Drawing.Size(156, 154);
            this.picSlika.TabIndex = 17;
            this.picSlika.TabStop = false;
            // 
            // txtKancelarija
            // 
            this.txtKancelarija.Location = new System.Drawing.Point(29, 229);
            this.txtKancelarija.Name = "txtKancelarija";
            this.txtKancelarija.ReadOnly = true;
            this.txtKancelarija.Size = new System.Drawing.Size(174, 20);
            this.txtKancelarija.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kancelarija";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(29, 186);
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = true;
            this.txtMail.Size = new System.Drawing.Size(174, 20);
            this.txtMail.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "E-mail";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(29, 140);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(174, 20);
            this.txtPrezime.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prezime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(29, 95);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(174, 20);
            this.txtIme.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime";
            // 
            // txtZvanje
            // 
            this.txtZvanje.Location = new System.Drawing.Point(29, 52);
            this.txtZvanje.Name = "txtZvanje";
            this.txtZvanje.ReadOnly = true;
            this.txtZvanje.Size = new System.Drawing.Size(174, 20);
            this.txtZvanje.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Zvanje";
            // 
            // frmProfesorDetaljiStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 298);
            this.Controls.Add(this.txtZvanje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picSlika);
            this.Controls.Add(this.txtKancelarija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "frmProfesorDetaljiStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfesorDetaljiStudent";
            this.Load += new System.EventHandler(this.frmProfesorDetaljiStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSlika;
        private System.Windows.Forms.TextBox txtKancelarija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZvanje;
        private System.Windows.Forms.Label label5;
    }
}