namespace StudentskiServis.WinUI.Uplata
{
    partial class frmIzmjenaUplata
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
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datUplate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOvjereno = new System.Windows.Forms.CheckBox();
            this.cbEvidentirao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUplatio = new System.Windows.Forms.ComboBox();
            this.picUplata = new System.Windows.Forms.PictureBox();
            this.btnSlika = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.ofdUplata = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picUplata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Svrha";
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(12, 32);
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(200, 20);
            this.txtSvrha.TabIndex = 1;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(12, 86);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(200, 20);
            this.txtIznos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iznos";
            // 
            // datUplate
            // 
            this.datUplate.Location = new System.Drawing.Point(12, 137);
            this.datUplate.Name = "datUplate";
            this.datUplate.Size = new System.Drawing.Size(200, 20);
            this.datUplate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum uplate";
            // 
            // cbOvjereno
            // 
            this.cbOvjereno.AutoSize = true;
            this.cbOvjereno.Location = new System.Drawing.Point(12, 181);
            this.cbOvjereno.Name = "cbOvjereno";
            this.cbOvjereno.Size = new System.Drawing.Size(69, 17);
            this.cbOvjereno.TabIndex = 6;
            this.cbOvjereno.Text = "Ovjereno";
            this.cbOvjereno.UseVisualStyleBackColor = true;
            // 
            // cbEvidentirao
            // 
            this.cbEvidentirao.FormattingEnabled = true;
            this.cbEvidentirao.Location = new System.Drawing.Point(12, 233);
            this.cbEvidentirao.Name = "cbEvidentirao";
            this.cbEvidentirao.Size = new System.Drawing.Size(200, 21);
            this.cbEvidentirao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Evidentirao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Uplatio";
            // 
            // cbUplatio
            // 
            this.cbUplatio.FormattingEnabled = true;
            this.cbUplatio.Location = new System.Drawing.Point(12, 287);
            this.cbUplatio.Name = "cbUplatio";
            this.cbUplatio.Size = new System.Drawing.Size(200, 21);
            this.cbUplatio.TabIndex = 9;
            // 
            // picUplata
            // 
            this.picUplata.Location = new System.Drawing.Point(246, 16);
            this.picUplata.Name = "picUplata";
            this.picUplata.Size = new System.Drawing.Size(426, 228);
            this.picUplata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUplata.TabIndex = 11;
            this.picUplata.TabStop = false;
            // 
            // btnSlika
            // 
            this.btnSlika.Location = new System.Drawing.Point(417, 250);
            this.btnSlika.Name = "btnSlika";
            this.btnSlika.Size = new System.Drawing.Size(94, 34);
            this.btnSlika.TabIndex = 12;
            this.btnSlika.Text = "Dodaj sliku";
            this.btnSlika.UseVisualStyleBackColor = true;
            this.btnSlika.Click += new System.EventHandler(this.btnSlika_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(570, 353);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(102, 39);
            this.btnSacuvaj.TabIndex = 14;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // ofdUplata
            // 
            this.ofdUplata.FileName = "openFileDialog";
            // 
            // frmIzmjenaUplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 404);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnSlika);
            this.Controls.Add(this.picUplata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbUplatio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEvidentirao);
            this.Controls.Add(this.cbOvjereno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datUplate);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSvrha);
            this.Controls.Add(this.label1);
            this.Name = "frmIzmjenaUplata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIzmjenaUplata";
            this.Load += new System.EventHandler(this.frmIzmjenaUplata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUplata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSvrha;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datUplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbOvjereno;
        private System.Windows.Forms.ComboBox cbEvidentirao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUplatio;
        private System.Windows.Forms.PictureBox picUplata;
        private System.Windows.Forms.Button btnSlika;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.OpenFileDialog ofdUplata;
    }
}