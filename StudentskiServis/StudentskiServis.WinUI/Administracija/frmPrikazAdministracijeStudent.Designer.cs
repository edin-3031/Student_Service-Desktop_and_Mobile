namespace StudentskiServis.WinUI.Administracija
{
    partial class frmPrikazAdministracijeStudent
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
            this.dgvAdminS = new System.Windows.Forms.DataGridView();
            this.AdministracijaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdminS
            // 
            this.dgvAdminS.AllowUserToAddRows = false;
            this.dgvAdminS.AllowUserToDeleteRows = false;
            this.dgvAdminS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdministracijaId,
            this.Ime,
            this.Prezime,
            this.Detalji});
            this.dgvAdminS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdminS.Location = new System.Drawing.Point(3, 16);
            this.dgvAdminS.Name = "dgvAdminS";
            this.dgvAdminS.ReadOnly = true;
            this.dgvAdminS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminS.Size = new System.Drawing.Size(344, 407);
            this.dgvAdminS.TabIndex = 0;
            this.dgvAdminS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdminS_CellContentClick);
            // 
            // AdministracijaId
            // 
            this.AdministracijaId.DataPropertyName = "AdministracijaId";
            this.AdministracijaId.HeaderText = "AdministracijaId";
            this.AdministracijaId.Name = "AdministracijaId";
            this.AdministracijaId.ReadOnly = true;
            this.AdministracijaId.Visible = false;
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
            // Detalji
            // 
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAdminS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administracija";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frmPrikazAdministracijeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazAdministracijeStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrikazAdministracijeStudent";
            this.Load += new System.EventHandler(this.frmPrikazAdministracijeStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdminS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdministracijaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
    }
}