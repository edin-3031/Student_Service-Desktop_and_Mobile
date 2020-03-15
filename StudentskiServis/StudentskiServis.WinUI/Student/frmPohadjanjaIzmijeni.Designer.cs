namespace StudentskiServis.WinUI.Student
{
    partial class frmPohadjanjaIzmijeni
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
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBrojObnavljanja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtKurs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbObnavlja = new System.Windows.Forms.CheckBox();
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.cbPolozio = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(125, 186);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(92, 20);
            this.txtOcjena.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ocjena";
            // 
            // txtBrojObnavljanja
            // 
            this.txtBrojObnavljanja.Location = new System.Drawing.Point(125, 140);
            this.txtBrojObnavljanja.Name = "txtBrojObnavljanja";
            this.txtBrojObnavljanja.Size = new System.Drawing.Size(92, 20);
            this.txtBrojObnavljanja.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Broj obnavljanja";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(79, 258);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(97, 38);
            this.btnSacuvaj.TabIndex = 19;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtKurs
            // 
            this.txtKurs.Location = new System.Drawing.Point(51, 53);
            this.txtKurs.Name = "txtKurs";
            this.txtKurs.ReadOnly = true;
            this.txtKurs.Size = new System.Drawing.Size(166, 20);
            this.txtKurs.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kurs";
            // 
            // cbObnavlja
            // 
            this.cbObnavlja.AutoSize = true;
            this.cbObnavlja.Location = new System.Drawing.Point(51, 140);
            this.cbObnavlja.Name = "cbObnavlja";
            this.cbObnavlja.Size = new System.Drawing.Size(68, 17);
            this.cbObnavlja.TabIndex = 32;
            this.cbObnavlja.Text = "Obnavlja";
            this.cbObnavlja.UseVisualStyleBackColor = true;
            this.cbObnavlja.CheckedChanged += new System.EventHandler(this.cbObnavlja_CheckedChanged);
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.Location = new System.Drawing.Point(51, 93);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(62, 17);
            this.cbAktivan.TabIndex = 33;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // cbPolozio
            // 
            this.cbPolozio.AutoSize = true;
            this.cbPolozio.Location = new System.Drawing.Point(51, 189);
            this.cbPolozio.Name = "cbPolozio";
            this.cbPolozio.Size = new System.Drawing.Size(60, 17);
            this.cbPolozio.TabIndex = 34;
            this.cbPolozio.Text = "Položio";
            this.cbPolozio.UseVisualStyleBackColor = true;
            this.cbPolozio.CheckedChanged += new System.EventHandler(this.cbPolozio_CheckedChanged);
            // 
            // frmPohadjanjaIzmijeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 328);
            this.Controls.Add(this.cbPolozio);
            this.Controls.Add(this.cbAktivan);
            this.Controls.Add(this.cbObnavlja);
            this.Controls.Add(this.txtKurs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBrojObnavljanja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSacuvaj);
            this.Name = "frmPohadjanjaIzmijeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPohadjanjaIzmijeni";
            this.Load += new System.EventHandler(this.frmPohadjanjaIzmijeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBrojObnavljanja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtKurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbObnavlja;
        private System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.CheckBox cbPolozio;
    }
}