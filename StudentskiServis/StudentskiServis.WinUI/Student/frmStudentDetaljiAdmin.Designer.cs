namespace StudentskiServis.WinUI.Student
{
    partial class frmStudentDetaljiAdmin
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
            this.txtPraksa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeminiarski = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.txtObnavlja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrojObnavljanja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAktivan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPolozio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurs";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(37, 46);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(159, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // txtECTS
            // 
            this.txtECTS.Location = new System.Drawing.Point(37, 93);
            this.txtECTS.Name = "txtECTS";
            this.txtECTS.ReadOnly = true;
            this.txtECTS.Size = new System.Drawing.Size(159, 20);
            this.txtECTS.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ECTS";
            // 
            // txtPraksa
            // 
            this.txtPraksa.Location = new System.Drawing.Point(37, 186);
            this.txtPraksa.Name = "txtPraksa";
            this.txtPraksa.ReadOnly = true;
            this.txtPraksa.Size = new System.Drawing.Size(159, 20);
            this.txtPraksa.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Posjeduje praksu";
            // 
            // txtSeminiarski
            // 
            this.txtSeminiarski.Location = new System.Drawing.Point(37, 139);
            this.txtSeminiarski.Name = "txtSeminiarski";
            this.txtSeminiarski.ReadOnly = true;
            this.txtSeminiarski.Size = new System.Drawing.Size(159, 20);
            this.txtSeminiarski.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Posjeduje seminarski rad";
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(290, 251);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(97, 38);
            this.btnBrisi.TabIndex = 8;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // txtObnavlja
            // 
            this.txtObnavlja.Location = new System.Drawing.Point(37, 234);
            this.txtObnavlja.Name = "txtObnavlja";
            this.txtObnavlja.ReadOnly = true;
            this.txtObnavlja.Size = new System.Drawing.Size(92, 20);
            this.txtObnavlja.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Obnavlja";
            // 
            // txtBrojObnavljanja
            // 
            this.txtBrojObnavljanja.Location = new System.Drawing.Point(37, 281);
            this.txtBrojObnavljanja.Name = "txtBrojObnavljanja";
            this.txtBrojObnavljanja.ReadOnly = true;
            this.txtBrojObnavljanja.Size = new System.Drawing.Size(92, 20);
            this.txtBrojObnavljanja.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Broj obnavljanja";
            // 
            // txtAktivan
            // 
            this.txtAktivan.Location = new System.Drawing.Point(37, 327);
            this.txtAktivan.Name = "txtAktivan";
            this.txtAktivan.ReadOnly = true;
            this.txtAktivan.Size = new System.Drawing.Size(92, 20);
            this.txtAktivan.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Aktivan";
            // 
            // txtPolozio
            // 
            this.txtPolozio.Location = new System.Drawing.Point(37, 374);
            this.txtPolozio.Name = "txtPolozio";
            this.txtPolozio.ReadOnly = true;
            this.txtPolozio.Size = new System.Drawing.Size(92, 20);
            this.txtPolozio.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Položio";
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(37, 421);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.ReadOnly = true;
            this.txtOcjena.Size = new System.Drawing.Size(92, 20);
            this.txtOcjena.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ocjena";
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(290, 172);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(97, 38);
            this.btnIzmijeni.TabIndex = 19;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // frmStudentDetaljiAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 466);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPolozio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAktivan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBrojObnavljanja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObnavlja);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.txtPraksa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSeminiarski);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtECTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentDetaljiAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentDetaljiAdmin";
            this.Load += new System.EventHandler(this.frmStudentDetaljiAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtECTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPraksa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeminiarski;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.TextBox txtObnavlja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrojObnavljanja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAktivan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPolozio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIzmijeni;
    }
}