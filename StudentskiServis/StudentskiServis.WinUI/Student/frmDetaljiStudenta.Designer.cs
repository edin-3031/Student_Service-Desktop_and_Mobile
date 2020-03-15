namespace StudentskiServis.WinUI.Student
{
    partial class frmDetaljiStudenta
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndeks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRodjenje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSpol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUpisanS = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOvjerenS = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtObnavlja = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBoxStud = new System.Windows.Forms.PictureBox();
            this.buttonBrisi = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStud)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(29, 91);
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(171, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(29, 50);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.ReadOnly = true;
            this.txtPrezime.Size = new System.Drawing.Size(171, 20);
            this.txtPrezime.TabIndex = 3;
            this.txtPrezime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIndeks
            // 
            this.txtIndeks.Location = new System.Drawing.Point(29, 135);
            this.txtIndeks.Name = "txtIndeks";
            this.txtIndeks.ReadOnly = true;
            this.txtIndeks.Size = new System.Drawing.Size(171, 20);
            this.txtIndeks.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Indeks";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(29, 178);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(171, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Korisničko ime";
            // 
            // txtRodjenje
            // 
            this.txtRodjenje.Location = new System.Drawing.Point(29, 226);
            this.txtRodjenje.Name = "txtRodjenje";
            this.txtRodjenje.ReadOnly = true;
            this.txtRodjenje.Size = new System.Drawing.Size(171, 20);
            this.txtRodjenje.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum rođenja";
            // 
            // txtUpis
            // 
            this.txtUpis.Location = new System.Drawing.Point(29, 277);
            this.txtUpis.Name = "txtUpis";
            this.txtUpis.ReadOnly = true;
            this.txtUpis.Size = new System.Drawing.Size(171, 20);
            this.txtUpis.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Datum upisa";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(29, 325);
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = true;
            this.txtMail.Size = new System.Drawing.Size(171, 20);
            this.txtMail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "E-Mail";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(29, 371);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.ReadOnly = true;
            this.txtAdresa.Size = new System.Drawing.Size(171, 20);
            this.txtAdresa.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adresa";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(29, 412);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(171, 20);
            this.txtTelefon.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefon";
            // 
            // txtSpol
            // 
            this.txtSpol.Location = new System.Drawing.Point(226, 50);
            this.txtSpol.Name = "txtSpol";
            this.txtSpol.ReadOnly = true;
            this.txtSpol.Size = new System.Drawing.Size(84, 20);
            this.txtSpol.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Spol";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(226, 91);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(171, 20);
            this.txtStatus.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Status";
            // 
            // txtNS
            // 
            this.txtNS.Location = new System.Drawing.Point(226, 135);
            this.txtNS.Name = "txtNS";
            this.txtNS.ReadOnly = true;
            this.txtNS.Size = new System.Drawing.Size(171, 20);
            this.txtNS.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(223, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Način studiranja";
            // 
            // txtUpisanS
            // 
            this.txtUpisanS.Location = new System.Drawing.Point(226, 178);
            this.txtUpisanS.Name = "txtUpisanS";
            this.txtUpisanS.ReadOnly = true;
            this.txtUpisanS.Size = new System.Drawing.Size(84, 20);
            this.txtUpisanS.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Upisan semestar";
            // 
            // txtOvjerenS
            // 
            this.txtOvjerenS.Location = new System.Drawing.Point(226, 226);
            this.txtOvjerenS.Name = "txtOvjerenS";
            this.txtOvjerenS.ReadOnly = true;
            this.txtOvjerenS.Size = new System.Drawing.Size(84, 20);
            this.txtOvjerenS.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(223, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Ovjeren semestar";
            // 
            // txtObnavlja
            // 
            this.txtObnavlja.Location = new System.Drawing.Point(226, 277);
            this.txtObnavlja.Name = "txtObnavlja";
            this.txtObnavlja.ReadOnly = true;
            this.txtObnavlja.Size = new System.Drawing.Size(84, 20);
            this.txtObnavlja.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(223, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Obnavlja godinu";
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(226, 325);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.ReadOnly = true;
            this.txtOcjena.Size = new System.Drawing.Size(84, 20);
            this.txtOcjena.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(223, 308);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Prosječna ocjena";
            // 
            // pictureBoxStud
            // 
            this.pictureBoxStud.Location = new System.Drawing.Point(517, 33);
            this.pictureBoxStud.Name = "pictureBoxStud";
            this.pictureBoxStud.Size = new System.Drawing.Size(156, 154);
            this.pictureBoxStud.TabIndex = 58;
            this.pictureBoxStud.TabStop = false;
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.Location = new System.Drawing.Point(548, 393);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(125, 39);
            this.buttonBrisi.TabIndex = 83;
            this.buttonBrisi.Text = "Briši";
            this.buttonBrisi.UseVisualStyleBackColor = true;
            this.buttonBrisi.Click += new System.EventHandler(this.buttonBrisi_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(417, 393);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(125, 39);
            this.btnIzmijeni.TabIndex = 82;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // frmDetaljiStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.pictureBoxStud);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtObnavlja);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtOvjerenS);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtUpisanS);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSpol);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUpis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRodjenje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIndeks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "frmDetaljiStudenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetaljiStudenta";
            this.Load += new System.EventHandler(this.frmDetaljiStudenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndeks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRodjenje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSpol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpisanS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOvjerenS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtObnavlja;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBoxStud;
        private System.Windows.Forms.Button buttonBrisi;
        private System.Windows.Forms.Button btnIzmijeni;
    }
}