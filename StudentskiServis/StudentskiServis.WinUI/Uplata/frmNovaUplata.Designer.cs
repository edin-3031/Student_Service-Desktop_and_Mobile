namespace StudentskiServis.WinUI.Uplata
{
    partial class frmNovaUplata
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
            this.components = new System.ComponentModel.Container();
            this.cbEvidentirao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUplatio = new System.Windows.Forms.ComboBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.dateUplata = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOvjereno = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.pbUplata = new System.Windows.Forms.PictureBox();
            this.btnAddSlika = new System.Windows.Forms.Button();
            this.openFileDialogUplata = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbUplata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEvidentirao
            // 
            this.cbEvidentirao.FormattingEnabled = true;
            this.cbEvidentirao.Location = new System.Drawing.Point(12, 33);
            this.cbEvidentirao.Name = "cbEvidentirao";
            this.cbEvidentirao.Size = new System.Drawing.Size(200, 21);
            this.cbEvidentirao.TabIndex = 0;
            this.cbEvidentirao.SelectedIndexChanged += new System.EventHandler(this.cbEvidentirao_SelectedIndexChanged);
            this.cbEvidentirao.Validating += new System.ComponentModel.CancelEventHandler(this.cbEvidentirao_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evidentirao";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uplatio";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbUplatio
            // 
            this.cbUplatio.FormattingEnabled = true;
            this.cbUplatio.Location = new System.Drawing.Point(12, 77);
            this.cbUplatio.Name = "cbUplatio";
            this.cbUplatio.Size = new System.Drawing.Size(200, 21);
            this.cbUplatio.TabIndex = 2;
            this.cbUplatio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbUplatio.Validating += new System.ComponentModel.CancelEventHandler(this.cbUplatio_Validating);
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(12, 204);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(100, 20);
            this.txtIznos.TabIndex = 4;
            this.txtIznos.Validating += new System.ComponentModel.CancelEventHandler(this.txtIznos_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Iznos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Svrha";
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(12, 163);
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(200, 20);
            this.txtSvrha.TabIndex = 6;
            this.txtSvrha.Validating += new System.ComponentModel.CancelEventHandler(this.txtSvrha_Validating);
            // 
            // dateUplata
            // 
            this.dateUplata.Location = new System.Drawing.Point(12, 121);
            this.dateUplata.Name = "dateUplata";
            this.dateUplata.Size = new System.Drawing.Size(200, 20);
            this.dateUplata.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum uplate";
            // 
            // cbOvjereno
            // 
            this.cbOvjereno.AutoSize = true;
            this.cbOvjereno.Location = new System.Drawing.Point(12, 247);
            this.cbOvjereno.Name = "cbOvjereno";
            this.cbOvjereno.Size = new System.Drawing.Size(69, 17);
            this.cbOvjereno.TabIndex = 10;
            this.cbOvjereno.Text = "Ovjereno";
            this.cbOvjereno.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(507, 290);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(111, 42);
            this.btnSacuvaj.TabIndex = 11;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // pbUplata
            // 
            this.pbUplata.Location = new System.Drawing.Point(311, 33);
            this.pbUplata.Name = "pbUplata";
            this.pbUplata.Size = new System.Drawing.Size(307, 168);
            this.pbUplata.TabIndex = 12;
            this.pbUplata.TabStop = false;
            // 
            // btnAddSlika
            // 
            this.btnAddSlika.Location = new System.Drawing.Point(435, 207);
            this.btnAddSlika.Name = "btnAddSlika";
            this.btnAddSlika.Size = new System.Drawing.Size(75, 23);
            this.btnAddSlika.TabIndex = 13;
            this.btnAddSlika.Text = "Dodaj";
            this.btnAddSlika.UseVisualStyleBackColor = true;
            this.btnAddSlika.Click += new System.EventHandler(this.btnAddSlika_Click);
            // 
            // openFileDialogUplata
            // 
            this.openFileDialogUplata.FileName = "openFileDialogUplata";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNovaUplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 349);
            this.Controls.Add(this.btnAddSlika);
            this.Controls.Add(this.pbUplata);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cbOvjereno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateUplata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSvrha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbUplatio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEvidentirao);
            this.Name = "frmNovaUplata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNovaUplata";
            this.Load += new System.EventHandler(this.frmNovaUplata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUplata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEvidentirao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbUplatio;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSvrha;
        private System.Windows.Forms.DateTimePicker dateUplata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbOvjereno;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.PictureBox pbUplata;
        private System.Windows.Forms.Button btnAddSlika;
        private System.Windows.Forms.OpenFileDialog openFileDialogUplata;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}