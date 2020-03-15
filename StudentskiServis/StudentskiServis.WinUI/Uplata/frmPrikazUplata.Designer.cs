namespace StudentskiServis.WinUI.Uplata
{
    partial class frmPrikazUplata
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
            this.btnPrikazUplata = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUplate = new System.Windows.Forms.DataGridView();
            this.UplataId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUplate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazUplata
            // 
            this.btnPrikazUplata.Location = new System.Drawing.Point(183, 37);
            this.btnPrikazUplata.Name = "btnPrikazUplata";
            this.btnPrikazUplata.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazUplata.TabIndex = 0;
            this.btnPrikazUplata.Text = "Prikaži";
            this.btnPrikazUplata.UseVisualStyleBackColor = true;
            this.btnPrikazUplata.Click += new System.EventHandler(this.btnPrikazUplata_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUplate);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 325);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Uplate";
            // 
            // dgvUplate
            // 
            this.dgvUplate.AllowUserToAddRows = false;
            this.dgvUplate.AllowUserToDeleteRows = false;
            this.dgvUplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UplataId,
            this.Svrha,
            this.Detalji});
            this.dgvUplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUplate.Location = new System.Drawing.Point(3, 16);
            this.dgvUplate.Name = "dgvUplate";
            this.dgvUplate.ReadOnly = true;
            this.dgvUplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUplate.Size = new System.Drawing.Size(245, 306);
            this.dgvUplate.TabIndex = 0;
            this.dgvUplate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUplate_CellContentClick);
            // 
            // UplataId
            // 
            this.UplataId.DataPropertyName = "UplataId";
            this.UplataId.HeaderText = "UplataId";
            this.UplataId.Name = "UplataId";
            this.UplataId.ReadOnly = true;
            this.UplataId.Visible = false;
            // 
            // Svrha
            // 
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.Name = "Svrha";
            this.Svrha.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(15, 37);
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(148, 20);
            this.txtSvrha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tražilica";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmPrikazUplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSvrha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrikazUplata);
            this.Name = "frmPrikazUplata";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrikazUplata";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUplate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikazUplata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UplataId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Svrha;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
        private System.Windows.Forms.TextBox txtSvrha;
        private System.Windows.Forms.Label label1;
    }
}