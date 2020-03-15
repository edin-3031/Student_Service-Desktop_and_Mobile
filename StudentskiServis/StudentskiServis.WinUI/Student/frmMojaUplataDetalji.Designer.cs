namespace StudentskiServis.WinUI.Student
{
    partial class frmMojaUplataDetalji
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
            this.pictureBoxUplata = new System.Windows.Forms.PictureBox();
            this.cbOvjereno = new System.Windows.Forms.CheckBox();
            this.txtDatUplate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEvidentirao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUplata)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUplata
            // 
            this.pictureBoxUplata.Location = new System.Drawing.Point(269, 43);
            this.pictureBoxUplata.Name = "pictureBoxUplata";
            this.pictureBoxUplata.Size = new System.Drawing.Size(273, 182);
            this.pictureBoxUplata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxUplata.TabIndex = 23;
            this.pictureBoxUplata.TabStop = false;
            // 
            // cbOvjereno
            // 
            this.cbOvjereno.AutoSize = true;
            this.cbOvjereno.Location = new System.Drawing.Point(24, 254);
            this.cbOvjereno.Name = "cbOvjereno";
            this.cbOvjereno.Size = new System.Drawing.Size(69, 17);
            this.cbOvjereno.TabIndex = 22;
            this.cbOvjereno.Text = "Ovjereno";
            this.cbOvjereno.UseVisualStyleBackColor = true;
            // 
            // txtDatUplate
            // 
            this.txtDatUplate.Location = new System.Drawing.Point(24, 150);
            this.txtDatUplate.Name = "txtDatUplate";
            this.txtDatUplate.ReadOnly = true;
            this.txtDatUplate.Size = new System.Drawing.Size(239, 20);
            this.txtDatUplate.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Datum uplate";
            // 
            // txtEvidentirao
            // 
            this.txtEvidentirao.Location = new System.Drawing.Point(24, 205);
            this.txtEvidentirao.Name = "txtEvidentirao";
            this.txtEvidentirao.ReadOnly = true;
            this.txtEvidentirao.Size = new System.Drawing.Size(239, 20);
            this.txtEvidentirao.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Evidentirao";
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(24, 43);
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.ReadOnly = true;
            this.txtSvrha.Size = new System.Drawing.Size(239, 20);
            this.txtSvrha.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Svrha";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(24, 96);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.ReadOnly = true;
            this.txtIznos.Size = new System.Drawing.Size(239, 20);
            this.txtIznos.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Iznos";
            // 
            // frmMojaUplataDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 287);
            this.Controls.Add(this.pictureBoxUplata);
            this.Controls.Add(this.cbOvjereno);
            this.Controls.Add(this.txtDatUplate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEvidentirao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSvrha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label1);
            this.Name = "frmMojaUplataDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMojaUplataDetalji";
            this.Load += new System.EventHandler(this.frmMojaUplataDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUplata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxUplata;
        private System.Windows.Forms.CheckBox cbOvjereno;
        private System.Windows.Forms.TextBox txtDatUplate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEvidentirao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSvrha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label1;
    }
}