namespace StudentskiServis.WinUI.Profesor
{
    partial class frmPrikazProfesoraStudent
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
            this.dgvProfS = new System.Windows.Forms.DataGridView();
            this.ProfesorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zvanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProfS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesori";
            // 
            // dgvProfS
            // 
            this.dgvProfS.AllowUserToAddRows = false;
            this.dgvProfS.AllowUserToDeleteRows = false;
            this.dgvProfS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfesorId,
            this.Zvanje,
            this.Ime,
            this.Prezime,
            this.Detalji});
            this.dgvProfS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfS.Location = new System.Drawing.Point(3, 16);
            this.dgvProfS.Name = "dgvProfS";
            this.dgvProfS.ReadOnly = true;
            this.dgvProfS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfS.Size = new System.Drawing.Size(444, 441);
            this.dgvProfS.TabIndex = 0;
            this.dgvProfS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfS_CellContentClick);
            // 
            // ProfesorId
            // 
            this.ProfesorId.DataPropertyName = "ProfesorId";
            this.ProfesorId.HeaderText = "ProfesorId";
            this.ProfesorId.Name = "ProfesorId";
            this.ProfesorId.ReadOnly = true;
            this.ProfesorId.Visible = false;
            // 
            // Zvanje
            // 
            this.Zvanje.DataPropertyName = "Zvanje";
            this.Zvanje.HeaderText = "Zvanje";
            this.Zvanje.Name = "Zvanje";
            this.Zvanje.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "ime";
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
            // frmPrikazProfesoraStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 484);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrikazProfesoraStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrikazProfesoraStudent";
            this.Load += new System.EventHandler(this.frmPrikazProfesoraStudent_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProfS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zvanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
    }
}