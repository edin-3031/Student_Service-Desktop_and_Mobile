namespace StudentskiServis.WinUI.Profesor
{
    partial class frmPredavanjeIzmjena
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.cBoxOdrzano = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datDatum = new System.Windows.Forms.DateTimePicker();
            this.rbPredavanje = new System.Windows.Forms.RadioButton();
            this.rbVjezba = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(642, 275);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(111, 44);
            this.btnSacuvaj.TabIndex = 17;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbOpis);
            this.groupBox1.Location = new System.Drawing.Point(64, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 292);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opis";
            // 
            // rtbOpis
            // 
            this.rtbOpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOpis.Location = new System.Drawing.Point(3, 16);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(525, 273);
            this.rtbOpis.TabIndex = 6;
            this.rtbOpis.Text = "";
            // 
            // cBoxOdrzano
            // 
            this.cBoxOdrzano.AutoSize = true;
            this.cBoxOdrzano.Location = new System.Drawing.Point(529, 83);
            this.cBoxOdrzano.Name = "cBoxOdrzano";
            this.cBoxOdrzano.Size = new System.Drawing.Size(66, 17);
            this.cBoxOdrzano.TabIndex = 12;
            this.cBoxOdrzano.Text = "Održano";
            this.cBoxOdrzano.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Datum predavanja";
            // 
            // datDatum
            // 
            this.datDatum.Location = new System.Drawing.Point(64, 80);
            this.datDatum.Name = "datDatum";
            this.datDatum.Size = new System.Drawing.Size(200, 20);
            this.datDatum.TabIndex = 18;
            // 
            // rbPredavanje
            // 
            this.rbPredavanje.AutoSize = true;
            this.rbPredavanje.Location = new System.Drawing.Point(30, 22);
            this.rbPredavanje.Name = "rbPredavanje";
            this.rbPredavanje.Size = new System.Drawing.Size(79, 17);
            this.rbPredavanje.TabIndex = 19;
            this.rbPredavanje.TabStop = true;
            this.rbPredavanje.Text = "Pradavanje";
            this.rbPredavanje.UseVisualStyleBackColor = true;
            // 
            // rbVjezba
            // 
            this.rbVjezba.AutoSize = true;
            this.rbVjezba.Location = new System.Drawing.Point(121, 21);
            this.rbVjezba.Name = "rbVjezba";
            this.rbVjezba.Size = new System.Drawing.Size(57, 17);
            this.rbVjezba.TabIndex = 20;
            this.rbVjezba.TabStop = true;
            this.rbVjezba.Text = "Vježba";
            this.rbVjezba.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbVjezba);
            this.groupBox2.Controls.Add(this.rbPredavanje);
            this.groupBox2.Location = new System.Drawing.Point(296, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 53);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vrsta";
            // 
            // frmPredavanjeIzmjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.datDatum);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cBoxOdrzano);
            this.Controls.Add(this.label1);
            this.Name = "frmPredavanjeIzmjena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPredavanjeIzmjena";
            this.Load += new System.EventHandler(this.frmPredavanjeIzmjena_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.CheckBox cBoxOdrzano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datDatum;
        private System.Windows.Forms.RadioButton rbPredavanje;
        private System.Windows.Forms.RadioButton rbVjezba;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}