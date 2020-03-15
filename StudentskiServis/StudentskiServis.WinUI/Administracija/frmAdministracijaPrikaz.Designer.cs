namespace StudentskiServis.WinUI.Administracija
{
    partial class frmAdministracijaPrikaz
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
            this.dgvAdministracija = new System.Windows.Forms.DataGridView();
            this.AdministracijaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kancelarija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministracija)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAdministracija);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administracija";
            // 
            // dgvAdministracija
            // 
            this.dgvAdministracija.AllowUserToAddRows = false;
            this.dgvAdministracija.AllowUserToDeleteRows = false;
            this.dgvAdministracija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdministracija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdministracijaID,
            this.Ime,
            this.Prezime,
            this.Kancelarija,
            this.btn_detalji});
            this.dgvAdministracija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdministracija.Location = new System.Drawing.Point(3, 16);
            this.dgvAdministracija.Name = "dgvAdministracija";
            this.dgvAdministracija.ReadOnly = true;
            this.dgvAdministracija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdministracija.Size = new System.Drawing.Size(497, 343);
            this.dgvAdministracija.TabIndex = 0;
            this.dgvAdministracija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdministracija_CellContentClick_1);
            this.dgvAdministracija.Click += new System.EventHandler(this.dgvAdministracija_Click_1);
            this.dgvAdministracija.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvAdministracija_MouseDoubleClick);
            // 
            // AdministracijaID
            // 
            this.AdministracijaID.DataPropertyName = "AdministracijaID";
            this.AdministracijaID.HeaderText = "AdministracijaID";
            this.AdministracijaID.Name = "AdministracijaID";
            this.AdministracijaID.ReadOnly = true;
            this.AdministracijaID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AdministracijaID.Visible = false;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Kancelarija
            // 
            this.Kancelarija.DataPropertyName = "Kancelarija";
            this.Kancelarija.HeaderText = "Kancelarija";
            this.Kancelarija.Name = "Kancelarija";
            this.Kancelarija.ReadOnly = true;
            // 
            // btn_detalji
            // 
            this.btn_detalji.HeaderText = "Akcija";
            this.btn_detalji.Name = "btn_detalji";
            this.btn_detalji.ReadOnly = true;
            this.btn_detalji.Text = "Detalji";
            this.btn_detalji.UseColumnTextForButtonValue = true;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(194, 32);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(15, 34);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(157, 20);
            this.txtPretraga.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tražilica";
            // 
            // frmAdministracijaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdministracijaPrikaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdministracijaPrikaz";
            this.Load += new System.EventHandler(this.frmAdministracijaPrikaz_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministracija)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAdministracija;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdministracijaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kancelarija;
        private System.Windows.Forms.DataGridViewButtonColumn btn_detalji;
    }
}