namespace StudentskiServis.WinUI.Student
{
    partial class frmMojiKursevi
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
            this.dgvNepolozeni = new System.Windows.Forms.DataGridView();
            this.PohadjaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obnavlja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojObnavljanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Položeni = new System.Windows.Forms.GroupBox();
            this.dgvPolozeni = new System.Windows.Forms.DataGridView();
            this.Pohadja_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojObnavljanja_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNepolozeni)).BeginInit();
            this.Položeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeni)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNepolozeni);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nepoloženi";
            // 
            // dgvNepolozeni
            // 
            this.dgvNepolozeni.AllowUserToAddRows = false;
            this.dgvNepolozeni.AllowUserToDeleteRows = false;
            this.dgvNepolozeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNepolozeni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PohadjaId,
            this.Kurs,
            this.Obnavlja,
            this.BrojObnavljanja,
            this.Aktivan});
            this.dgvNepolozeni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNepolozeni.Location = new System.Drawing.Point(3, 16);
            this.dgvNepolozeni.Name = "dgvNepolozeni";
            this.dgvNepolozeni.ReadOnly = true;
            this.dgvNepolozeni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNepolozeni.Size = new System.Drawing.Size(445, 310);
            this.dgvNepolozeni.TabIndex = 0;
            // 
            // PohadjaId
            // 
            this.PohadjaId.DataPropertyName = "PohadjaId";
            this.PohadjaId.HeaderText = "PohadjaId";
            this.PohadjaId.Name = "PohadjaId";
            this.PohadjaId.ReadOnly = true;
            this.PohadjaId.Visible = false;
            // 
            // Kurs
            // 
            this.Kurs.DataPropertyName = "Naziv";
            this.Kurs.HeaderText = "Kurs";
            this.Kurs.Name = "Kurs";
            this.Kurs.ReadOnly = true;
            // 
            // Obnavlja
            // 
            this.Obnavlja.DataPropertyName = "Obnavlja";
            this.Obnavlja.HeaderText = "Obnavlja";
            this.Obnavlja.Name = "Obnavlja";
            this.Obnavlja.ReadOnly = true;
            // 
            // BrojObnavljanja
            // 
            this.BrojObnavljanja.DataPropertyName = "BrojObnavljanja";
            this.BrojObnavljanja.HeaderText = "Broj obnavljanja";
            this.BrojObnavljanja.Name = "BrojObnavljanja";
            this.BrojObnavljanja.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
            // 
            // Položeni
            // 
            this.Položeni.Controls.Add(this.dgvPolozeni);
            this.Položeni.Location = new System.Drawing.Point(12, 348);
            this.Položeni.Name = "Položeni";
            this.Položeni.Size = new System.Drawing.Size(451, 329);
            this.Položeni.TabIndex = 1;
            this.Položeni.TabStop = false;
            this.Položeni.Text = "Položeni";
            this.Položeni.Enter += new System.EventHandler(this.Položeni_Enter);
            // 
            // dgvPolozeni
            // 
            this.dgvPolozeni.AllowUserToAddRows = false;
            this.dgvPolozeni.AllowUserToDeleteRows = false;
            this.dgvPolozeni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolozeni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pohadja_Id,
            this.Kurs_,
            this.BrojObnavljanja_,
            this.Ocjena});
            this.dgvPolozeni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPolozeni.Location = new System.Drawing.Point(3, 16);
            this.dgvPolozeni.Name = "dgvPolozeni";
            this.dgvPolozeni.ReadOnly = true;
            this.dgvPolozeni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolozeni.Size = new System.Drawing.Size(445, 310);
            this.dgvPolozeni.TabIndex = 0;
            this.dgvPolozeni.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolozeni_CellContentClick);
            // 
            // Pohadja_Id
            // 
            this.Pohadja_Id.DataPropertyName = "PohadjaId";
            this.Pohadja_Id.HeaderText = "PohadjaId";
            this.Pohadja_Id.Name = "Pohadja_Id";
            this.Pohadja_Id.ReadOnly = true;
            this.Pohadja_Id.Visible = false;
            // 
            // Kurs_
            // 
            this.Kurs_.DataPropertyName = "Naziv";
            this.Kurs_.HeaderText = "Kurs";
            this.Kurs_.Name = "Kurs_";
            this.Kurs_.ReadOnly = true;
            // 
            // BrojObnavljanja_
            // 
            this.BrojObnavljanja_.DataPropertyName = "BrojObnavljanja";
            this.BrojObnavljanja_.HeaderText = "Broj obnavljanja";
            this.BrojObnavljanja_.Name = "BrojObnavljanja_";
            this.BrojObnavljanja_.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // frmMojiKursevi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 689);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Položeni);
            this.Name = "frmMojiKursevi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMojiKursevi";
            this.Load += new System.EventHandler(this.frmMojiKursevi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNepolozeni)).EndInit();
            this.Položeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolozeni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNepolozeni;
        private System.Windows.Forms.GroupBox Položeni;
        private System.Windows.Forms.DataGridView dgvPolozeni;
        private System.Windows.Forms.DataGridViewTextBoxColumn PohadjaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obnavlja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojObnavljanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pohadja_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs_;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojObnavljanja_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
    }
}