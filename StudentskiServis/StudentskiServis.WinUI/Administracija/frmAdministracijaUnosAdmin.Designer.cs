namespace StudentskiServis.WinUI.Administracija
{
    partial class frmAdministracijaUnosAdmin
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
            this.txtKancelarija = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picSlika = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStaz = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUgovor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSnimi = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.dateRodjenje = new System.Windows.Forms.DateTimePicker();
            this.dateZaposlenje = new System.Windows.Forms.DateTimePicker();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.rbtnMusko = new System.Windows.Forms.RadioButton();
            this.rbtnZensko = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKancelarija
            // 
            this.txtKancelarija.Location = new System.Drawing.Point(37, 183);
            this.txtKancelarija.Name = "txtKancelarija";
            this.txtKancelarija.Size = new System.Drawing.Size(232, 20);
            this.txtKancelarija.TabIndex = 16;
            this.txtKancelarija.Validating += new System.ComponentModel.CancelEventHandler(this.txtKancelarija_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kancelarija";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(37, 140);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(232, 20);
            this.txtMail.TabIndex = 14;
            this.txtMail.Validating += new System.ComponentModel.CancelEventHandler(this.txtMail_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "E-mail";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(37, 49);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(232, 20);
            this.txtPrezime.TabIndex = 12;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(37, 277);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 20);
            this.txtUsername.TabIndex = 21;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Korisničko ime";
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(37, 371);
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.PasswordChar = '*';
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(232, 20);
            this.txtPasswordConfirmation.TabIndex = 25;
            this.txtPasswordConfirmation.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtPasswordConfirmation.Validating += new System.ComponentModel.CancelEventHandler(this.txtPasswordConfirmation_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Potvrda šifre";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(37, 321);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(232, 20);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Šifra";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Datum rođenja";
            // 
            // picSlika
            // 
            this.picSlika.Location = new System.Drawing.Point(694, 49);
            this.picSlika.Name = "picSlika";
            this.picSlika.Size = new System.Drawing.Size(156, 154);
            this.picSlika.TabIndex = 17;
            this.picSlika.TabStop = false;
            this.picSlika.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.picSlika_LoadCompleted);
            this.picSlika.Click += new System.EventHandler(this.picSlika_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Datum zaposlenja";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(290, 140);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(232, 20);
            this.txtAdresa.TabIndex = 33;
            this.txtAdresa.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            this.txtAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdresa_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Adresa";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtStaz
            // 
            this.txtStaz.Location = new System.Drawing.Point(290, 227);
            this.txtStaz.Name = "txtStaz";
            this.txtStaz.Size = new System.Drawing.Size(88, 20);
            this.txtStaz.TabIndex = 39;
            this.txtStaz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStaz.Validating += new System.ComponentModel.CancelEventHandler(this.txtStaz_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(287, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Staž";
            // 
            // txtUgovor
            // 
            this.txtUgovor.Location = new System.Drawing.Point(37, 227);
            this.txtUgovor.Name = "txtUgovor";
            this.txtUgovor.Size = new System.Drawing.Size(232, 20);
            this.txtUgovor.TabIndex = 41;
            this.txtUgovor.Validating += new System.ComponentModel.CancelEventHandler(this.txtUgovor_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Vrsta ugovora";
            // 
            // btnSnimi
            // 
            this.btnSnimi.Location = new System.Drawing.Point(548, 361);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(125, 39);
            this.btnSnimi.TabIndex = 42;
            this.btnSnimi.Text = "Sačuvaj";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.btnSnimi_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(37, 94);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(232, 20);
            this.txtIme.TabIndex = 43;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // dateRodjenje
            // 
            this.dateRodjenje.Location = new System.Drawing.Point(290, 49);
            this.dateRodjenje.MaxDate = new System.DateTime(2999, 12, 31, 23, 59, 59, 0);
            this.dateRodjenje.Name = "dateRodjenje";
            this.dateRodjenje.Size = new System.Drawing.Size(232, 20);
            this.dateRodjenje.TabIndex = 44;
            this.dateRodjenje.Value = new System.DateTime(2019, 12, 11, 0, 0, 0, 0);
            this.dateRodjenje.ValueChanged += new System.EventHandler(this.dateRodjenje_ValueChanged);
            this.dateRodjenje.Validating += new System.ComponentModel.CancelEventHandler(this.dateRodjenje_Validating);
            // 
            // dateZaposlenje
            // 
            this.dateZaposlenje.Location = new System.Drawing.Point(290, 94);
            this.dateZaposlenje.MaxDate = new System.DateTime(2999, 12, 31, 23, 59, 59, 0);
            this.dateZaposlenje.Name = "dateZaposlenje";
            this.dateZaposlenje.Size = new System.Drawing.Size(232, 20);
            this.dateZaposlenje.TabIndex = 45;
            this.dateZaposlenje.Value = new System.DateTime(2019, 12, 11, 0, 0, 0, 0);
            this.dateZaposlenje.Validating += new System.ComponentModel.CancelEventHandler(this.dateZaposlenje_Validating);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(290, 183);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(232, 20);
            this.txtSlika.TabIndex = 47;
            this.txtSlika.TextChanged += new System.EventHandler(this.txtSlika_TextChanged);
            this.txtSlika.Validating += new System.ComponentModel.CancelEventHandler(this.txtSlika_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Slika";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(725, 361);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(125, 39);
            this.btnBrisi.TabIndex = 49;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbtnMusko
            // 
            this.rbtnMusko.AutoSize = true;
            this.rbtnMusko.Location = new System.Drawing.Point(353, 275);
            this.rbtnMusko.Name = "rbtnMusko";
            this.rbtnMusko.Size = new System.Drawing.Size(57, 17);
            this.rbtnMusko.TabIndex = 50;
            this.rbtnMusko.TabStop = true;
            this.rbtnMusko.Text = "Muško";
            this.rbtnMusko.UseVisualStyleBackColor = true;
            // 
            // rbtnZensko
            // 
            this.rbtnZensko.AutoSize = true;
            this.rbtnZensko.Location = new System.Drawing.Point(438, 275);
            this.rbtnZensko.Name = "rbtnZensko";
            this.rbtnZensko.Size = new System.Drawing.Size(61, 17);
            this.rbtnZensko.TabIndex = 51;
            this.rbtnZensko.TabStop = true;
            this.rbtnZensko.Text = "Žensko";
            this.rbtnZensko.UseVisualStyleBackColor = true;
            this.rbtnZensko.Validating += new System.ComponentModel.CancelEventHandler(this.rbtnZensko_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Spol";
            // 
            // frmAdministracijaUnosAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.rbtnZensko);
            this.Controls.Add(this.rbtnMusko);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateZaposlenje);
            this.Controls.Add(this.dateRodjenje);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnSnimi);
            this.Controls.Add(this.txtUgovor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtStaz);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPasswordConfirmation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picSlika);
            this.Controls.Add(this.txtKancelarija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdministracijaUnosAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministracijaDetaljiAdmin";
            this.Load += new System.EventHandler(this.frmAdministracijaDetaljiAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswordConfirmation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStaz;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUgovor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.DateTimePicker dateRodjenje;
        private System.Windows.Forms.DateTimePicker dateZaposlenje;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.RadioButton rbtnZensko;
        private System.Windows.Forms.RadioButton rbtnMusko;
        private System.Windows.Forms.Label label12;
    }
}