namespace StudentskiServis.WinUI.Ispit
{
    partial class frmIspitiPrikazStudent
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
            this.dgvIspitiS = new System.Windows.Forms.DataGridView();
            this.IspitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspitiS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIspitiS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zakazani ispiti";
            // 
            // dgvIspitiS
            // 
            this.dgvIspitiS.AllowUserToAddRows = false;
            this.dgvIspitiS.AllowUserToDeleteRows = false;
            this.dgvIspitiS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIspitiS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IspitId,
            this.Datum,
            this.Kurs,
            this.Detalji});
            this.dgvIspitiS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIspitiS.Location = new System.Drawing.Point(3, 16);
            this.dgvIspitiS.Name = "dgvIspitiS";
            this.dgvIspitiS.ReadOnly = true;
            this.dgvIspitiS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIspitiS.Size = new System.Drawing.Size(345, 407);
            this.dgvIspitiS.TabIndex = 0;
            this.dgvIspitiS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIspitiS_CellContentClick);
            // 
            // IspitId
            // 
            this.IspitId.DataPropertyName = "ispitId";
            this.IspitId.HeaderText = "IspitId";
            this.IspitId.Name = "IspitId";
            this.IspitId.ReadOnly = true;
            this.IspitId.Visible = false;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Kurs
            // 
            this.Kurs.DataPropertyName = "Kurs";
            this.Kurs.HeaderText = "Kurs";
            this.Kurs.Name = "Kurs";
            this.Kurs.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // frmIspitiPrikazStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIspitiPrikazStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIspitiPrikazStudent";
            this.Load += new System.EventHandler(this.frmIspitiPrikazStudent_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspitiS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIspitiS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IspitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
    }
}