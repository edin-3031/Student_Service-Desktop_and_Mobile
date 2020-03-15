namespace StudentskiServis.WinUI.Obavijest
{
    partial class frmDetaljiObavijesti
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbSadrzaj = new System.Windows.Forms.RichTextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatumObjave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbSadrzaj);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 250);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sadržaj";
            // 
            // rtbSadrzaj
            // 
            this.rtbSadrzaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSadrzaj.Location = new System.Drawing.Point(3, 16);
            this.rtbSadrzaj.Name = "rtbSadrzaj";
            this.rtbSadrzaj.ReadOnly = true;
            this.rtbSadrzaj.Size = new System.Drawing.Size(463, 231);
            this.rtbSadrzaj.TabIndex = 6;
            this.rtbSadrzaj.Text = "";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(43, 124);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.ReadOnly = true;
            this.txtNaslov.Size = new System.Drawing.Size(233, 20);
            this.txtNaslov.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Naslov";
            // 
            // txtDatumObjave
            // 
            this.txtDatumObjave.Location = new System.Drawing.Point(43, 79);
            this.txtDatumObjave.Name = "txtDatumObjave";
            this.txtDatumObjave.ReadOnly = true;
            this.txtDatumObjave.Size = new System.Drawing.Size(233, 20);
            this.txtDatumObjave.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Datum objave";
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(43, 32);
            this.txtProf.Name = "txtProf";
            this.txtProf.ReadOnly = true;
            this.txtProf.Size = new System.Drawing.Size(233, 20);
            this.txtProf.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Objavio";
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(376, 32);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(102, 37);
            this.btnIzmijeni.TabIndex = 15;
            this.btnIzmijeni.Text = "Izmijeni\r\n";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(376, 107);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(102, 37);
            this.btnBrisi.TabIndex = 16;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // frmDetaljiObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 426);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatumObjave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProf);
            this.Controls.Add(this.label1);
            this.Name = "frmDetaljiObavijesti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetaljiObavijesti";
            this.Load += new System.EventHandler(this.frmDetaljiObavijesti_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbSadrzaj;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatumObjave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnBrisi;
    }
}