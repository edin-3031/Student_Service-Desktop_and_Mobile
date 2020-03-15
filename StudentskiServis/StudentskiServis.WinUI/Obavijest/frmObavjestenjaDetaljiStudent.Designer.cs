namespace StudentskiServis.WinUI.Obavijest
{
    partial class frmObavjestenjaDetaljiStudent
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbSadrzaj);
            this.groupBox1.Location = new System.Drawing.Point(12, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 282);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sadržaj";
            // 
            // rtbSadrzaj
            // 
            this.rtbSadrzaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSadrzaj.Location = new System.Drawing.Point(3, 16);
            this.rtbSadrzaj.Name = "rtbSadrzaj";
            this.rtbSadrzaj.ReadOnly = true;
            this.rtbSadrzaj.Size = new System.Drawing.Size(451, 263);
            this.rtbSadrzaj.TabIndex = 6;
            this.rtbSadrzaj.Text = "";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(123, 130);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.ReadOnly = true;
            this.txtNaslov.Size = new System.Drawing.Size(233, 20);
            this.txtNaslov.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Naslov";
            // 
            // txtDatumObjave
            // 
            this.txtDatumObjave.Location = new System.Drawing.Point(123, 85);
            this.txtDatumObjave.Name = "txtDatumObjave";
            this.txtDatumObjave.ReadOnly = true;
            this.txtDatumObjave.Size = new System.Drawing.Size(233, 20);
            this.txtDatumObjave.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Datum objave";
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(123, 38);
            this.txtProf.Name = "txtProf";
            this.txtProf.ReadOnly = true;
            this.txtProf.Size = new System.Drawing.Size(233, 20);
            this.txtProf.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Objavio";
            // 
            // frmObavjestenjaDetaljiStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatumObjave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProf);
            this.Controls.Add(this.label1);
            this.Name = "frmObavjestenjaDetaljiStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmObavjestenjaDetaljiStudent";
            this.Load += new System.EventHandler(this.frmObavjestenjaDetaljiStudent_Load);
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
    }
}