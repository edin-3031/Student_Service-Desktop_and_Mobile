namespace StudentskiServis.WinUI.Student
{
    partial class frmStudentDetalji
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
            this.cmbSTUD = new System.Windows.Forms.ComboBox();
            this.dgvPohadja = new System.Windows.Forms.DataGridView();
            this.KursId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PohadjaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Obnavlja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojObnavljanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPohadja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // cmbSTUD
            // 
            this.cmbSTUD.FormattingEnabled = true;
            this.cmbSTUD.Location = new System.Drawing.Point(167, 43);
            this.cmbSTUD.Name = "cmbSTUD";
            this.cmbSTUD.Size = new System.Drawing.Size(236, 21);
            this.cmbSTUD.TabIndex = 1;
            this.cmbSTUD.SelectedIndexChanged += new System.EventHandler(this.cmbSTUD_SelectedIndexChanged);
            // 
            // dgvPohadja
            // 
            this.dgvPohadja.AllowUserToAddRows = false;
            this.dgvPohadja.AllowUserToDeleteRows = false;
            this.dgvPohadja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPohadja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KursId,
            this.PohadjaId,
            this.Naziv,
            this.Aktivan,
            this.Obnavlja,
            this.BrojObnavljanja,
            this.StudentId,
            this.Detalji});
            this.dgvPohadja.Location = new System.Drawing.Point(12, 104);
            this.dgvPohadja.Name = "dgvPohadja";
            this.dgvPohadja.ReadOnly = true;
            this.dgvPohadja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPohadja.Size = new System.Drawing.Size(544, 334);
            this.dgvPohadja.TabIndex = 3;
            this.dgvPohadja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPohadja_CellContentClick);
            this.dgvPohadja.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPohadja_MouseDoubleClick);
            // 
            // KursId
            // 
            this.KursId.DataPropertyName = "KursId";
            this.KursId.HeaderText = "KursId";
            this.KursId.Name = "KursId";
            this.KursId.ReadOnly = true;
            this.KursId.Visible = false;
            // 
            // PohadjaId
            // 
            this.PohadjaId.DataPropertyName = "PohadjaId";
            this.PohadjaId.HeaderText = "PohadjaId";
            this.PohadjaId.Name = "PohadjaId";
            this.PohadjaId.ReadOnly = true;
            this.PohadjaId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Kurs";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Aktivan
            // 
            this.Aktivan.DataPropertyName = "Aktivan";
            this.Aktivan.HeaderText = "Aktivan";
            this.Aktivan.Name = "Aktivan";
            this.Aktivan.ReadOnly = true;
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
            this.BrojObnavljanja.HeaderText = "BrojObnavljanja";
            this.BrojObnavljanja.Name = "BrojObnavljanja";
            this.BrojObnavljanja.ReadOnly = true;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // frmStudentDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.dgvPohadja);
            this.Controls.Add(this.cmbSTUD);
            this.Controls.Add(this.label1);
            this.Name = "frmStudentDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStudentDetalji";
            this.Load += new System.EventHandler(this.frmStudentDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPohadja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSTUD;
        private System.Windows.Forms.DataGridView dgvPohadja;
        private System.Windows.Forms.DataGridViewTextBoxColumn KursId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PohadjaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aktivan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Obnavlja;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojObnavljanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
    }
}