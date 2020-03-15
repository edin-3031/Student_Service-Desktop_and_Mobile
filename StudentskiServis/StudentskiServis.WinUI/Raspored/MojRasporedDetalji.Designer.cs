namespace StudentskiServis.WinUI.Raspored
{
    partial class MojRasporedDetalji
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
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbVazno = new System.Windows.Forms.CheckBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(152, 72);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.ReadOnly = true;
            this.txtNaslov.Size = new System.Drawing.Size(177, 20);
            this.txtNaslov.TabIndex = 1;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(363, 72);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(177, 20);
            this.txtDatum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum";
            // 
            // cbVazno
            // 
            this.cbVazno.AutoSize = true;
            this.cbVazno.Location = new System.Drawing.Point(593, 75);
            this.cbVazno.Name = "cbVazno";
            this.cbVazno.Size = new System.Drawing.Size(56, 17);
            this.cbVazno.TabIndex = 4;
            this.cbVazno.Text = "Važno";
            this.cbVazno.UseVisualStyleBackColor = true;
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(77, 140);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.ReadOnly = true;
            this.rtbOpis.Size = new System.Drawing.Size(679, 306);
            this.rtbOpis.TabIndex = 5;
            this.rtbOpis.Text = "";
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(789, 242);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(103, 37);
            this.btnIzmijeni.TabIndex = 6;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(789, 305);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(103, 37);
            this.btnBrisi.TabIndex = 7;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // MojRasporedDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 458);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.cbVazno);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label1);
            this.Name = "MojRasporedDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MojRasporedDetalji";
            this.Load += new System.EventHandler(this.MojRasporedDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbVazno;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnBrisi;
    }
}