namespace StudentskiServis.WinUI.Profesor
{
    partial class frmPredavanjaDetalji
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
            this.cmbPROF = new System.Windows.Forms.ComboBox();
            this.dvgPredavanja = new System.Windows.Forms.DataGridView();
            this.PredajeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPredavanja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profesor";
            // 
            // cmbPROF
            // 
            this.cmbPROF.FormattingEnabled = true;
            this.cmbPROF.Location = new System.Drawing.Point(96, 58);
            this.cmbPROF.Name = "cmbPROF";
            this.cmbPROF.Size = new System.Drawing.Size(216, 21);
            this.cmbPROF.TabIndex = 2;
            this.cmbPROF.SelectedIndexChanged += new System.EventHandler(this.cmbPROF_SelectedIndexChanged);
            // 
            // dvgPredavanja
            // 
            this.dvgPredavanja.AllowUserToAddRows = false;
            this.dvgPredavanja.AllowUserToDeleteRows = false;
            this.dvgPredavanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPredavanja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PredajeId,
            this.Naziv,
            this.Vrsta,
            this.Detalji});
            this.dvgPredavanja.Location = new System.Drawing.Point(12, 140);
            this.dvgPredavanja.Name = "dvgPredavanja";
            this.dvgPredavanja.ReadOnly = true;
            this.dvgPredavanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgPredavanja.Size = new System.Drawing.Size(345, 298);
            this.dvgPredavanja.TabIndex = 3;
            this.dvgPredavanja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPredavanja_CellContentClick);
            // 
            // PredajeId
            // 
            this.PredajeId.DataPropertyName = "PredajeId";
            this.PredajeId.HeaderText = "PredajeId";
            this.PredajeId.Name = "PredajeId";
            this.PredajeId.ReadOnly = true;
            this.PredajeId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Kurs";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // frmPredavanjaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.dvgPredavanja);
            this.Controls.Add(this.cmbPROF);
            this.Controls.Add(this.label1);
            this.Name = "frmPredavanjaDetalji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPredavanjaDetalji";
            this.Load += new System.EventHandler(this.frmPredavanjaDetalji_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPredavanja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPROF;
        private System.Windows.Forms.DataGridView dvgPredavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredajeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vrsta;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
    }
}