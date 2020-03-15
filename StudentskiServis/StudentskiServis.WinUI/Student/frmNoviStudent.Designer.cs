namespace StudentskiServis.WinUI.Student
{
    partial class frmNoviStudent
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
            this.components = new System.ComponentModel.Container();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dateUpis = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateRodjenje = new System.Windows.Forms.DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpisaniSemestar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtnZ = new System.Windows.Forms.RadioButton();
            this.rbtnM = new System.Windows.Forms.RadioButton();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIndeks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnDL = new System.Windows.Forms.RadioButton();
            this.rbtnIC = new System.Windows.Forms.RadioButton();
            this.rbtnV = new System.Windows.Forms.RadioButton();
            this.cbObnavlja = new System.Windows.Forms.CheckBox();
            this.txtOvjerenSemestar = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbSpol = new System.Windows.Forms.GroupBox();
            this.gbNacinStudiranja = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbSpol.SuspendLayout();
            this.gbNacinStudiranja.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(456, 127);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSliku.TabIndex = 69;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(250, 129);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(200, 20);
            this.txtSlika.TabIndex = 68;
            this.txtSlika.Validating += new System.ComponentModel.CancelEventHandler(this.txtSlika_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(247, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 67;
            this.label15.Text = "Slika";
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(533, 432);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(116, 48);
            this.btnBrisi.TabIndex = 66;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(672, 432);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(116, 48);
            this.btnSacuvaj.TabIndex = 65;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 64;
            this.label14.Text = "Datum upisa";
            // 
            // dateUpis
            // 
            this.dateUpis.Location = new System.Drawing.Point(250, 80);
            this.dateUpis.Name = "dateUpis";
            this.dateUpis.Size = new System.Drawing.Size(200, 20);
            this.dateUpis.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 62;
            this.label13.Text = "Datum rođenja";
            // 
            // dateRodjenje
            // 
            this.dateRodjenje.Location = new System.Drawing.Point(250, 31);
            this.dateRodjenje.Name = "dateRodjenje";
            this.dateRodjenje.Size = new System.Drawing.Size(200, 20);
            this.dateRodjenje.TabIndex = 61;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(590, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(198, 182);
            this.pictureBox.TabIndex = 60;
            this.pictureBox.TabStop = false;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(12, 413);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(200, 20);
            this.txtConfirm.TabIndex = 59;
            this.txtConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirm_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "Potvrda šifre";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(12, 366);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.PasswordChar = '*';
            this.txtSifra.Size = new System.Drawing.Size(200, 20);
            this.txtSifra.TabIndex = 57;
            this.txtSifra.Validating += new System.ComponentModel.CancelEventHandler(this.txtSifra_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "Šifra";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 324);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 55;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Korisničko ime";
            // 
            // txtUpisaniSemestar
            // 
            this.txtUpisaniSemestar.Location = new System.Drawing.Point(250, 225);
            this.txtUpisaniSemestar.Name = "txtUpisaniSemestar";
            this.txtUpisaniSemestar.Size = new System.Drawing.Size(103, 20);
            this.txtUpisaniSemestar.TabIndex = 53;
            this.txtUpisaniSemestar.Validating += new System.ComponentModel.CancelEventHandler(this.txtUpisaniSemestar_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Upisani semestar";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(12, 273);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 20);
            this.txtTelefon.TabIndex = 51;
            this.txtTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefon_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Telefon";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(250, 176);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(200, 20);
            this.txtStatus.TabIndex = 49;
            this.txtStatus.Validating += new System.ComponentModel.CancelEventHandler(this.txtStatus_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Status";
            // 
            // rbtnZ
            // 
            this.rbtnZ.AutoSize = true;
            this.rbtnZ.Location = new System.Drawing.Point(124, 19);
            this.rbtnZ.Name = "rbtnZ";
            this.rbtnZ.Size = new System.Drawing.Size(50, 17);
            this.rbtnZ.TabIndex = 46;
            this.rbtnZ.TabStop = true;
            this.rbtnZ.Text = "Žena";
            this.rbtnZ.UseVisualStyleBackColor = true;
            this.rbtnZ.Validating += new System.ComponentModel.CancelEventHandler(this.rbtnZ_Validating);
            // 
            // rbtnM
            // 
            this.rbtnM.AutoSize = true;
            this.rbtnM.Location = new System.Drawing.Point(23, 19);
            this.rbtnM.Name = "rbtnM";
            this.rbtnM.Size = new System.Drawing.Size(72, 17);
            this.rbtnM.TabIndex = 45;
            this.rbtnM.TabStop = true;
            this.rbtnM.Text = "Muškarac";
            this.rbtnM.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(12, 226);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 20);
            this.txtMail.TabIndex = 44;
            this.txtMail.Validating += new System.ComponentModel.CancelEventHandler(this.txtMail_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "E-Mail";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(12, 176);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(200, 20);
            this.txtAdresa.TabIndex = 42;
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Adresa";
            // 
            // txtIndeks
            // 
            this.txtIndeks.Location = new System.Drawing.Point(12, 129);
            this.txtIndeks.Name = "txtIndeks";
            this.txtIndeks.Size = new System.Drawing.Size(200, 20);
            this.txtIndeks.TabIndex = 40;
            this.txtIndeks.Validating += new System.ComponentModel.CancelEventHandler(this.txtIndeks_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Indeks";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(12, 80);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(200, 20);
            this.txtIme.TabIndex = 38;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(12, 31);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(200, 20);
            this.txtPrezime.TabIndex = 36;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Prezime";
            // 
            // rbtnDL
            // 
            this.rbtnDL.AutoSize = true;
            this.rbtnDL.Location = new System.Drawing.Point(85, 15);
            this.rbtnDL.Name = "rbtnDL";
            this.rbtnDL.Size = new System.Drawing.Size(39, 17);
            this.rbtnDL.TabIndex = 71;
            this.rbtnDL.TabStop = true;
            this.rbtnDL.Text = "DL";
            this.rbtnDL.UseVisualStyleBackColor = true;
            // 
            // rbtnIC
            // 
            this.rbtnIC.AutoSize = true;
            this.rbtnIC.Location = new System.Drawing.Point(6, 16);
            this.rbtnIC.Name = "rbtnIC";
            this.rbtnIC.Size = new System.Drawing.Size(73, 17);
            this.rbtnIC.TabIndex = 70;
            this.rbtnIC.TabStop = true;
            this.rbtnIC.Text = "IN-CLASS";
            this.rbtnIC.UseVisualStyleBackColor = true;
            // 
            // rbtnV
            // 
            this.rbtnV.AutoSize = true;
            this.rbtnV.Location = new System.Drawing.Point(127, 15);
            this.rbtnV.Name = "rbtnV";
            this.rbtnV.Size = new System.Drawing.Size(71, 17);
            this.rbtnV.TabIndex = 73;
            this.rbtnV.TabStop = true;
            this.rbtnV.Text = "Vanredno";
            this.rbtnV.UseVisualStyleBackColor = true;
            this.rbtnV.Validating += new System.ComponentModel.CancelEventHandler(this.rbtnV_Validating);
            // 
            // cbObnavlja
            // 
            this.cbObnavlja.AutoSize = true;
            this.cbObnavlja.Location = new System.Drawing.Point(250, 418);
            this.cbObnavlja.Name = "cbObnavlja";
            this.cbObnavlja.Size = new System.Drawing.Size(103, 17);
            this.cbObnavlja.TabIndex = 82;
            this.cbObnavlja.Text = "Obnavlja godinu";
            this.cbObnavlja.UseVisualStyleBackColor = true;
            // 
            // txtOvjerenSemestar
            // 
            this.txtOvjerenSemestar.Location = new System.Drawing.Point(250, 275);
            this.txtOvjerenSemestar.Name = "txtOvjerenSemestar";
            this.txtOvjerenSemestar.Size = new System.Drawing.Size(98, 20);
            this.txtOvjerenSemestar.TabIndex = 84;
            this.txtOvjerenSemestar.Validating += new System.ComponentModel.CancelEventHandler(this.txtOvjerenSemestar_Validating);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(247, 258);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 13);
            this.label21.TabIndex = 83;
            this.label21.Text = "Ovjeren semestar";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // gbSpol
            // 
            this.gbSpol.Controls.Add(this.rbtnZ);
            this.gbSpol.Controls.Add(this.rbtnM);
            this.gbSpol.Location = new System.Drawing.Point(249, 301);
            this.gbSpol.Name = "gbSpol";
            this.gbSpol.Size = new System.Drawing.Size(200, 45);
            this.gbSpol.TabIndex = 85;
            this.gbSpol.TabStop = false;
            this.gbSpol.Text = "Spol";
            // 
            // gbNacinStudiranja
            // 
            this.gbNacinStudiranja.Controls.Add(this.rbtnIC);
            this.gbNacinStudiranja.Controls.Add(this.rbtnDL);
            this.gbNacinStudiranja.Controls.Add(this.rbtnV);
            this.gbNacinStudiranja.Location = new System.Drawing.Point(249, 366);
            this.gbNacinStudiranja.Name = "gbNacinStudiranja";
            this.gbNacinStudiranja.Size = new System.Drawing.Size(200, 39);
            this.gbNacinStudiranja.TabIndex = 86;
            this.gbNacinStudiranja.TabStop = false;
            this.gbNacinStudiranja.Text = "Način studiranja";
            // 
            // frmNoviStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.gbNacinStudiranja);
            this.Controls.Add(this.gbSpol);
            this.Controls.Add(this.txtOvjerenSemestar);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cbObnavlja);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateUpis);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateRodjenje);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUpisaniSemestar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIndeks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Name = "frmNoviStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNoviStudent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbSpol.ResumeLayout(false);
            this.gbSpol.PerformLayout();
            this.gbNacinStudiranja.ResumeLayout(false);
            this.gbNacinStudiranja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateUpis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateRodjenje;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpisaniSemestar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtnZ;
        private System.Windows.Forms.RadioButton rbtnM;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIndeks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnDL;
        private System.Windows.Forms.RadioButton rbtnIC;
        private System.Windows.Forms.RadioButton rbtnV;
        private System.Windows.Forms.CheckBox cbObnavlja;
        private System.Windows.Forms.TextBox txtOvjerenSemestar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox gbSpol;
        private System.Windows.Forms.GroupBox gbNacinStudiranja;
    }
}