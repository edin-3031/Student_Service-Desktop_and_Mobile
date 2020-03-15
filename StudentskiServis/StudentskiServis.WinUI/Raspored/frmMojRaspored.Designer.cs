namespace StudentskiServis.WinUI.Raspored
{
    partial class frmMojRaspored
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
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.RasporedId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRaspored);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moj raspored";
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.AllowUserToAddRows = false;
            this.dgvRaspored.AllowUserToDeleteRows = false;
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RasporedId,
            this.Naslov,
            this.Datum,
            this.Detalji});
            this.dgvRaspored.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRaspored.Location = new System.Drawing.Point(3, 16);
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.ReadOnly = true;
            this.dgvRaspored.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRaspored.Size = new System.Drawing.Size(345, 407);
            this.dgvRaspored.TabIndex = 0;
            this.dgvRaspored.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRaspored_CellContentClick);
            // 
            // RasporedId
            // 
            this.RasporedId.DataPropertyName = "RasporedId";
            this.RasporedId.HeaderText = "RasporedId";
            this.RasporedId.Name = "RasporedId";
            this.RasporedId.ReadOnly = true;
            this.RasporedId.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // frmMojRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMojRaspored";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMojRaspored";
            this.Load += new System.EventHandler(this.frmMojRaspored_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.DataGridViewTextBoxColumn RasporedId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
    }
}