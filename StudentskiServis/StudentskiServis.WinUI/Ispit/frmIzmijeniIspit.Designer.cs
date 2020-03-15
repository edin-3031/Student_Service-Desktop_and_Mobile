namespace StudentskiServis.WinUI.Ispit
{
    partial class frmIzmijeniIspit
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
            this.txtUcionica = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbParcijalno = new System.Windows.Forms.CheckBox();
            this.txtBodovi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPitanja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbObjavio = new System.Windows.Forms.ComboBox();
            this.dateIspit = new System.Windows.Forms.DateTimePicker();
            this.cbKurs = new System.Windows.Forms.ComboBox();
            this.errorIzmjena = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorIzmjena)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(312, 262);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(99, 37);
            this.btnSacuvaj.TabIndex = 33;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtUcionica
            // 
            this.txtUcionica.Location = new System.Drawing.Point(12, 83);
            this.txtUcionica.Name = "txtUcionica";
            this.txtUcionica.Size = new System.Drawing.Size(200, 20);
            this.txtUcionica.TabIndex = 31;
            this.txtUcionica.Validating += new System.ComponentModel.CancelEventHandler(this.txtUcionica_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Učionica";
            // 
            // cbParcijalno
            // 
            this.cbParcijalno.AutoSize = true;
            this.cbParcijalno.Location = new System.Drawing.Point(287, 176);
            this.cbParcijalno.Name = "cbParcijalno";
            this.cbParcijalno.Size = new System.Drawing.Size(125, 17);
            this.cbParcijalno.TabIndex = 29;
            this.cbParcijalno.Text = "Parcijalno bodovanje";
            this.cbParcijalno.UseVisualStyleBackColor = true;
            // 
            // txtBodovi
            // 
            this.txtBodovi.Location = new System.Drawing.Point(287, 130);
            this.txtBodovi.Name = "txtBodovi";
            this.txtBodovi.Size = new System.Drawing.Size(90, 20);
            this.txtBodovi.TabIndex = 28;
            this.txtBodovi.Validating += new System.ComponentModel.CancelEventHandler(this.txtBodovi_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Maksimalno bodova";
            // 
            // txtPitanja
            // 
            this.txtPitanja.Location = new System.Drawing.Point(287, 83);
            this.txtPitanja.Name = "txtPitanja";
            this.txtPitanja.Size = new System.Drawing.Size(90, 20);
            this.txtPitanja.TabIndex = 26;
            this.txtPitanja.Validating += new System.ComponentModel.CancelEventHandler(this.txtPitanja_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Broj pitanja";
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(287, 37);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(90, 20);
            this.txtTrajanje.TabIndex = 24;
            this.txtTrajanje.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrajanje_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Trajanje (minute)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Datum održavanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Objavio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kurs";
            // 
            // cbObjavio
            // 
            this.cbObjavio.FormattingEnabled = true;
            this.cbObjavio.Location = new System.Drawing.Point(12, 176);
            this.cbObjavio.Name = "cbObjavio";
            this.cbObjavio.Size = new System.Drawing.Size(200, 21);
            this.cbObjavio.TabIndex = 34;
            this.cbObjavio.Validating += new System.ComponentModel.CancelEventHandler(this.cbObjavio_Validating);
            // 
            // dateIspit
            // 
            this.dateIspit.Location = new System.Drawing.Point(12, 130);
            this.dateIspit.Name = "dateIspit";
            this.dateIspit.Size = new System.Drawing.Size(200, 20);
            this.dateIspit.TabIndex = 35;
            // 
            // cbKurs
            // 
            this.cbKurs.FormattingEnabled = true;
            this.cbKurs.Location = new System.Drawing.Point(12, 36);
            this.cbKurs.Name = "cbKurs";
            this.cbKurs.Size = new System.Drawing.Size(200, 21);
            this.cbKurs.TabIndex = 36;
            this.cbKurs.Validating += new System.ComponentModel.CancelEventHandler(this.cbKurs_Validating);
            // 
            // errorIzmjena
            // 
            this.errorIzmjena.ContainerControl = this;
            // 
            // frmIzmijeniIspit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 311);
            this.Controls.Add(this.cbKurs);
            this.Controls.Add(this.dateIspit);
            this.Controls.Add(this.cbObjavio);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtUcionica);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbParcijalno);
            this.Controls.Add(this.txtBodovi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPitanja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIzmijeniIspit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIzmijeniIspit";
            this.Load += new System.EventHandler(this.frmIzmijeniIspit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIzmjena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtUcionica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbParcijalno;
        private System.Windows.Forms.TextBox txtBodovi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPitanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbObjavio;
        private System.Windows.Forms.DateTimePicker dateIspit;
        private System.Windows.Forms.ComboBox cbKurs;
        private System.Windows.Forms.ErrorProvider errorIzmjena;
    }
}