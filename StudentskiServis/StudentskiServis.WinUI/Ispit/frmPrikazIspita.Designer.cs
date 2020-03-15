namespace StudentskiServis.WinUI.Ispit
{
    partial class frmPrikazIspita
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
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.Ispiti = new System.Windows.Forms.GroupBox();
            this.dgvIspiti = new System.Windows.Forms.DataGridView();
            this.IspitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucionica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtKurs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ispiti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspiti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(386, 37);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 0;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // Ispiti
            // 
            this.Ispiti.Controls.Add(this.dgvIspiti);
            this.Ispiti.Location = new System.Drawing.Point(12, 80);
            this.Ispiti.Name = "Ispiti";
            this.Ispiti.Size = new System.Drawing.Size(449, 358);
            this.Ispiti.TabIndex = 1;
            this.Ispiti.TabStop = false;
            this.Ispiti.Text = "Ispiti";
            // 
            // dgvIspiti
            // 
            this.dgvIspiti.AllowUserToAddRows = false;
            this.dgvIspiti.AllowUserToDeleteRows = false;
            this.dgvIspiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIspiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IspitId,
            this.Kurs,
            this.Datum,
            this.Ucionica,
            this.Detalji});
            this.dgvIspiti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIspiti.Location = new System.Drawing.Point(3, 16);
            this.dgvIspiti.Name = "dgvIspiti";
            this.dgvIspiti.ReadOnly = true;
            this.dgvIspiti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIspiti.Size = new System.Drawing.Size(443, 339);
            this.dgvIspiti.TabIndex = 0;
            this.dgvIspiti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIspiti_CellContentClick);
            // 
            // IspitId
            // 
            this.IspitId.DataPropertyName = "IspitId";
            this.IspitId.HeaderText = "IspitId";
            this.IspitId.Name = "IspitId";
            this.IspitId.ReadOnly = true;
            this.IspitId.Visible = false;
            // 
            // Kurs
            // 
            this.Kurs.DataPropertyName = "Kurs";
            this.Kurs.HeaderText = "Kurs";
            this.Kurs.Name = "Kurs";
            this.Kurs.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum održavanja";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Ucionica
            // 
            this.Ucionica.DataPropertyName = "Ucionica";
            this.Ucionica.HeaderText = "Učionica";
            this.Ucionica.Name = "Ucionica";
            this.Ucionica.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // txtKurs
            // 
            this.txtKurs.Location = new System.Drawing.Point(15, 39);
            this.txtKurs.Name = "txtKurs";
            this.txtKurs.Size = new System.Drawing.Size(183, 20);
            this.txtKurs.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tražilica";
            // 
            // frmPrikazIspita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKurs);
            this.Controls.Add(this.Ispiti);
            this.Controls.Add(this.btnPrikazi);
            this.Name = "frmPrikazIspita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrikazIspita";
            this.Ispiti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIspiti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.GroupBox Ispiti;
        private System.Windows.Forms.DataGridView dgvIspiti;
        private System.Windows.Forms.DataGridViewTextBoxColumn IspitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucionica;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
        private System.Windows.Forms.TextBox txtKurs;
        private System.Windows.Forms.Label label1;
    }
}