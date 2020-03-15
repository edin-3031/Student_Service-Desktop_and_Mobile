namespace StudentskiServis.WinUI.Kurs
{
    partial class frmDetaljiKurs
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtECTS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeminarski = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPraksa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(98, 77);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(151, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // txtECTS
            // 
            this.txtECTS.Location = new System.Drawing.Point(98, 128);
            this.txtECTS.Name = "txtECTS";
            this.txtECTS.ReadOnly = true;
            this.txtECTS.Size = new System.Drawing.Size(151, 20);
            this.txtECTS.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ECTS";
            // 
            // txtSeminarski
            // 
            this.txtSeminarski.Location = new System.Drawing.Point(98, 182);
            this.txtSeminarski.Name = "txtSeminarski";
            this.txtSeminarski.ReadOnly = true;
            this.txtSeminarski.Size = new System.Drawing.Size(151, 20);
            this.txtSeminarski.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Posjeduje seminarski rad";
            // 
            // txtPraksa
            // 
            this.txtPraksa.Location = new System.Drawing.Point(98, 237);
            this.txtPraksa.Name = "txtPraksa";
            this.txtPraksa.ReadOnly = true;
            this.txtPraksa.Size = new System.Drawing.Size(151, 20);
            this.txtPraksa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Posjeduje praksu";
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(61, 312);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(101, 35);
            this.btnBrisi.TabIndex = 8;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(179, 312);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(101, 35);
            this.btnIzmijeni.TabIndex = 9;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // frmDetaljiKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 372);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.txtPraksa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSeminarski);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtECTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmDetaljiKurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetaljiKurs";
            this.Load += new System.EventHandler(this.frmDetaljiKurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtECTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeminarski;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPraksa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnIzmijeni;
    }
}