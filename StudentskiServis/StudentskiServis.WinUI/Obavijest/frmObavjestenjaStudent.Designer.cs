namespace StudentskiServis.WinUI.Obavijest
{
    partial class frmObavjestenjaStudent
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
            this.dgvObavijestiS = new System.Windows.Forms.DataGridView();
            this.ObavijestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijestiS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvObavijestiS);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 414);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obavijesti";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvObavijestiS
            // 
            this.dgvObavijestiS.AllowUserToAddRows = false;
            this.dgvObavijestiS.AllowUserToDeleteRows = false;
            this.dgvObavijestiS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijestiS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObavijestId,
            this.Naslov,
            this.DatumObjave,
            this.Detalji});
            this.dgvObavijestiS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObavijestiS.Location = new System.Drawing.Point(3, 16);
            this.dgvObavijestiS.Name = "dgvObavijestiS";
            this.dgvObavijestiS.ReadOnly = true;
            this.dgvObavijestiS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObavijestiS.Size = new System.Drawing.Size(344, 395);
            this.dgvObavijestiS.TabIndex = 0;
            this.dgvObavijestiS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObavijestiS_CellContentClick);
            // 
            // ObavijestId
            // 
            this.ObavijestId.DataPropertyName = "ObavijestId";
            this.ObavijestId.HeaderText = "ObavijestId";
            this.ObavijestId.Name = "ObavijestId";
            this.ObavijestId.ReadOnly = true;
            this.ObavijestId.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // DatumObjave
            // 
            this.DatumObjave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumObjave.DataPropertyName = "DatumObjave";
            this.DatumObjave.HeaderText = "Datum objave";
            this.DatumObjave.Name = "DatumObjave";
            this.DatumObjave.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // frmObavjestenjaStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 438);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmObavjestenjaStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmObavjestenjaStudent";
            this.Load += new System.EventHandler(this.frmObavjestenjaStudent_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijestiS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvObavijestiS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObavijestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
    }
}