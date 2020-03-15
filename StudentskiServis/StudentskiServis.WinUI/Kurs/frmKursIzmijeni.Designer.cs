namespace StudentskiServis.WinUI.Kurs
{
    partial class frmKursIzmijeni
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtECTS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSeminarski = new System.Windows.Forms.CheckBox();
            this.cbPraksa = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(84, 257);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(101, 35);
            this.btnSacuvaj.TabIndex = 19;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtECTS
            // 
            this.txtECTS.Location = new System.Drawing.Point(65, 112);
            this.txtECTS.Name = "txtECTS";
            this.txtECTS.Size = new System.Drawing.Size(151, 20);
            this.txtECTS.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "ECTS";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(65, 61);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(151, 20);
            this.txtNaziv.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Naziv";
            // 
            // cbSeminarski
            // 
            this.cbSeminarski.AutoSize = true;
            this.cbSeminarski.Location = new System.Drawing.Point(65, 158);
            this.cbSeminarski.Name = "cbSeminarski";
            this.cbSeminarski.Size = new System.Drawing.Size(142, 17);
            this.cbSeminarski.TabIndex = 20;
            this.cbSeminarski.Text = "Posjeduje seminarski rad";
            this.cbSeminarski.UseVisualStyleBackColor = true;
            // 
            // cbPraksa
            // 
            this.cbPraksa.AutoSize = true;
            this.cbPraksa.Location = new System.Drawing.Point(65, 199);
            this.cbPraksa.Name = "cbPraksa";
            this.cbPraksa.Size = new System.Drawing.Size(107, 17);
            this.cbPraksa.TabIndex = 21;
            this.cbPraksa.Text = "Posjeduje praksu";
            this.cbPraksa.UseVisualStyleBackColor = true;
            // 
            // frmKursIzmijeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 318);
            this.Controls.Add(this.cbPraksa);
            this.Controls.Add(this.cbSeminarski);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtECTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmKursIzmijeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKursIzmijeni";
            this.Load += new System.EventHandler(this.frmKursIzmijeni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtECTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSeminarski;
        private System.Windows.Forms.CheckBox cbPraksa;
    }
}