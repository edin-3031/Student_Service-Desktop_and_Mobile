namespace StudentskiServis.WinUI.Administracija
{
    partial class frmAdministracijaIzmjenaAdmin
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
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datHire = new System.Windows.Forms.DateTimePicker();
            this.textEMail = new System.Windows.Forms.TextBox();
            this.datBirth = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textOffice = new System.Windows.Forms.TextBox();
            this.textContract = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textWorking = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioZ = new System.Windows.Forms.RadioButton();
            this.btnIzmjenaSlike = new System.Windows.Forms.Button();
            this.editSlika = new System.Windows.Forms.PictureBox();
            this.izmjenaSlike = new System.Windows.Forms.OpenFileDialog();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.editSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(24, 55);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(232, 20);
            this.textLastName.TabIndex = 80;
            this.textLastName.Validating += new System.ComponentModel.CancelEventHandler(this.textLastName_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Ime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Prezime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "E-mail";
            // 
            // datHire
            // 
            this.datHire.CustomFormat = "";
            this.datHire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datHire.Location = new System.Drawing.Point(276, 145);
            this.datHire.MaxDate = new System.DateTime(2999, 12, 31, 23, 59, 59, 0);
            this.datHire.Name = "datHire";
            this.datHire.Size = new System.Drawing.Size(232, 20);
            this.datHire.TabIndex = 97;
            this.datHire.Value = new System.DateTime(2019, 12, 11, 0, 0, 0, 0);
            // 
            // textEMail
            // 
            this.textEMail.Location = new System.Drawing.Point(24, 146);
            this.textEMail.Name = "textEMail";
            this.textEMail.Size = new System.Drawing.Size(232, 20);
            this.textEMail.TabIndex = 82;
            this.textEMail.Validating += new System.ComponentModel.CancelEventHandler(this.textEMail_Validating);
            // 
            // datBirth
            // 
            this.datBirth.CustomFormat = "";
            this.datBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datBirth.Location = new System.Drawing.Point(276, 100);
            this.datBirth.MaxDate = new System.DateTime(2999, 12, 31, 23, 59, 59, 0);
            this.datBirth.Name = "datBirth";
            this.datBirth.Size = new System.Drawing.Size(232, 20);
            this.datBirth.TabIndex = 96;
            this.datBirth.Value = new System.DateTime(2019, 12, 11, 0, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(273, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 83;
            this.label15.Text = "Kancelarija";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(24, 100);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(232, 20);
            this.textFirstName.TabIndex = 95;
            this.textFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textFirstName_Validating);
            // 
            // textOffice
            // 
            this.textOffice.Location = new System.Drawing.Point(276, 55);
            this.textOffice.Name = "textOffice";
            this.textOffice.Size = new System.Drawing.Size(232, 20);
            this.textOffice.TabIndex = 84;
            this.textOffice.Validating += new System.ComponentModel.CancelEventHandler(this.textOffice_Validating);
            // 
            // textContract
            // 
            this.textContract.Location = new System.Drawing.Point(24, 189);
            this.textContract.Name = "textContract";
            this.textContract.Size = new System.Drawing.Size(232, 20);
            this.textContract.TabIndex = 94;
            this.textContract.Validating += new System.ComponentModel.CancelEventHandler(this.textContract_Validating);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 173);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 13);
            this.label24.TabIndex = 93;
            this.label24.Text = "Vrsta ugovora";
            // 
            // textWorking
            // 
            this.textWorking.Location = new System.Drawing.Point(24, 234);
            this.textWorking.Name = "textWorking";
            this.textWorking.Size = new System.Drawing.Size(88, 20);
            this.textWorking.TabIndex = 92;
            this.textWorking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textWorking.Validating += new System.ComponentModel.CancelEventHandler(this.textWorking_Validating);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 218);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 91;
            this.label23.Text = "Staž";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(273, 218);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 89;
            this.label22.Text = "Spol";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(276, 189);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(232, 20);
            this.textAddress.TabIndex = 88;
            this.textAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textAddress_Validating);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(273, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 85;
            this.label19.Text = "Datum rođenja";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(273, 173);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 87;
            this.label21.Text = "Adresa";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(273, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 13);
            this.label20.TabIndex = 86;
            this.label20.Text = "Datum zaposlenja";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(614, 324);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(92, 33);
            this.btnSaveEdit.TabIndex = 98;
            this.btnSaveEdit.Text = "Sačuvaj";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(276, 234);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(57, 17);
            this.radioM.TabIndex = 99;
            this.radioM.TabStop = true;
            this.radioM.Text = "Muško";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // radioZ
            // 
            this.radioZ.AutoSize = true;
            this.radioZ.Location = new System.Drawing.Point(416, 234);
            this.radioZ.Name = "radioZ";
            this.radioZ.Size = new System.Drawing.Size(61, 17);
            this.radioZ.TabIndex = 100;
            this.radioZ.TabStop = true;
            this.radioZ.Text = "Žensko";
            this.radioZ.UseVisualStyleBackColor = true;
            this.radioZ.Validating += new System.ComponentModel.CancelEventHandler(this.radioZ_Validating);
            // 
            // btnIzmjenaSlike
            // 
            this.btnIzmjenaSlike.Location = new System.Drawing.Point(573, 199);
            this.btnIzmjenaSlike.Name = "btnIzmjenaSlike";
            this.btnIzmjenaSlike.Size = new System.Drawing.Size(115, 23);
            this.btnIzmjenaSlike.TabIndex = 102;
            this.btnIzmjenaSlike.Text = "Promijeni sliku";
            this.btnIzmjenaSlike.UseVisualStyleBackColor = true;
            this.btnIzmjenaSlike.Click += new System.EventHandler(this.btnIzmjenaSlike_Click);
            // 
            // editSlika
            // 
            this.editSlika.Location = new System.Drawing.Point(550, 39);
            this.editSlika.Name = "editSlika";
            this.editSlika.Size = new System.Drawing.Size(156, 154);
            this.editSlika.TabIndex = 101;
            this.editSlika.TabStop = false;
            this.editSlika.Click += new System.EventHandler(this.editSlika_Click);
            // 
            // izmjenaSlike
            // 
            this.izmjenaSlike.FileName = "izmjenaSlike";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmAdministracijaIzmjenaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 377);
            this.Controls.Add(this.btnIzmjenaSlike);
            this.Controls.Add(this.editSlika);
            this.Controls.Add(this.radioZ);
            this.Controls.Add(this.radioM);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datHire);
            this.Controls.Add(this.textEMail);
            this.Controls.Add(this.datBirth);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textOffice);
            this.Controls.Add(this.textContract);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.textWorking);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Name = "frmAdministracijaIzmjenaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministracijaIzmjenaAdmin";
            this.Load += new System.EventHandler(this.frmAdministracijaIzmjenaAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datHire;
        private System.Windows.Forms.TextBox textEMail;
        private System.Windows.Forms.DateTimePicker datBirth;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textOffice;
        private System.Windows.Forms.TextBox textContract;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textWorking;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioZ;
        private System.Windows.Forms.Button btnIzmjenaSlike;
        private System.Windows.Forms.PictureBox editSlika;
        private System.Windows.Forms.OpenFileDialog izmjenaSlike;
        private System.Windows.Forms.ErrorProvider error;
    }
}