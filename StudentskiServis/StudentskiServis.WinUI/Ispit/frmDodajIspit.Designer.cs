namespace StudentskiServis.WinUI.Ispit
{
    partial class frmDodajIspit
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cbObjavljuje = new System.Windows.Forms.ComboBox();
            this.dateDatum = new System.Windows.Forms.DateTimePicker();
            this.cbKurs = new System.Windows.Forms.ComboBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtPitanja = new System.Windows.Forms.TextBox();
            this.txtBodovi = new System.Windows.Forms.TextBox();
            this.cbParcijalno = new System.Windows.Forms.CheckBox();
            this.txtUcionica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.greskaV = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.greskaV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(140, 342);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(100, 41);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cbObjavljuje
            // 
            this.cbObjavljuje.FormattingEnabled = true;
            this.cbObjavljuje.Location = new System.Drawing.Point(94, 25);
            this.cbObjavljuje.Name = "cbObjavljuje";
            this.cbObjavljuje.Size = new System.Drawing.Size(200, 21);
            this.cbObjavljuje.TabIndex = 1;
            this.cbObjavljuje.Validating += new System.ComponentModel.CancelEventHandler(this.cbObjavljuje_Validating);
            // 
            // dateDatum
            // 
            this.dateDatum.Location = new System.Drawing.Point(94, 120);
            this.dateDatum.Name = "dateDatum";
            this.dateDatum.Size = new System.Drawing.Size(200, 20);
            this.dateDatum.TabIndex = 2;
            // 
            // cbKurs
            // 
            this.cbKurs.FormattingEnabled = true;
            this.cbKurs.Location = new System.Drawing.Point(94, 73);
            this.cbKurs.Name = "cbKurs";
            this.cbKurs.Size = new System.Drawing.Size(200, 21);
            this.cbKurs.TabIndex = 3;
            this.cbKurs.Validating += new System.ComponentModel.CancelEventHandler(this.cbKurs_Validating);
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(12, 231);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(100, 20);
            this.txtTrajanje.TabIndex = 4;
            this.txtTrajanje.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrajanje_Validating);
            // 
            // txtPitanja
            // 
            this.txtPitanja.Location = new System.Drawing.Point(270, 231);
            this.txtPitanja.Name = "txtPitanja";
            this.txtPitanja.Size = new System.Drawing.Size(100, 20);
            this.txtPitanja.TabIndex = 5;
            this.txtPitanja.Validating += new System.ComponentModel.CancelEventHandler(this.txtPitanja_Validating);
            // 
            // txtBodovi
            // 
            this.txtBodovi.Location = new System.Drawing.Point(140, 231);
            this.txtBodovi.Name = "txtBodovi";
            this.txtBodovi.Size = new System.Drawing.Size(100, 20);
            this.txtBodovi.TabIndex = 6;
            this.txtBodovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtBodovi_Validating);
            // 
            // cbParcijalno
            // 
            this.cbParcijalno.AutoSize = true;
            this.cbParcijalno.Location = new System.Drawing.Point(140, 282);
            this.cbParcijalno.Name = "cbParcijalno";
            this.cbParcijalno.Size = new System.Drawing.Size(125, 17);
            this.cbParcijalno.TabIndex = 7;
            this.cbParcijalno.Text = "Parcijalno bodovanje";
            this.cbParcijalno.UseVisualStyleBackColor = true;
            // 
            // txtUcionica
            // 
            this.txtUcionica.Location = new System.Drawing.Point(94, 166);
            this.txtUcionica.Name = "txtUcionica";
            this.txtUcionica.Size = new System.Drawing.Size(200, 20);
            this.txtUcionica.TabIndex = 8;
            this.txtUcionica.Validating += new System.ComponentModel.CancelEventHandler(this.txtUcionica_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Objavljuje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kurs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Datum održavanja ispita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trajanje ispita (minute)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 215);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Broj pitanja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 215);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Maksimalni bodovi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 150);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Učionica";
            // 
            // greskaV
            // 
            this.greskaV.ContainerControl = this;
            // 
            // frmDodajIspit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 395);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUcionica);
            this.Controls.Add(this.cbParcijalno);
            this.Controls.Add(this.txtBodovi);
            this.Controls.Add(this.txtPitanja);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.cbKurs);
            this.Controls.Add(this.dateDatum);
            this.Controls.Add(this.cbObjavljuje);
            this.Controls.Add(this.btnSacuvaj);
            this.Name = "frmDodajIspit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDodajIspit";
            this.Load += new System.EventHandler(this.frmDodajIspit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.greskaV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cbObjavljuje;
        private System.Windows.Forms.DateTimePicker dateDatum;
        private System.Windows.Forms.ComboBox cbKurs;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtPitanja;
        private System.Windows.Forms.TextBox txtBodovi;
        private System.Windows.Forms.CheckBox cbParcijalno;
        private System.Windows.Forms.TextBox txtUcionica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider greskaV;
    }
}