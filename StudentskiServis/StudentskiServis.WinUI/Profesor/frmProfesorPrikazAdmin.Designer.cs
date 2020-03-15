namespace StudentskiServis.WinUI.Profesor
{
    public partial class frmProfesorPrikazAdmin
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
            this.dgvProfesoriPrikaz = new System.Windows.Forms.DataGridView();
            this.ProfesorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zvanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kancelarija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbProfesori = new System.Windows.Forms.GroupBox();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.txtProfTrazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesoriPrikaz)).BeginInit();
            this.gbProfesori.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(713, 23);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 0;
            this.btnPrikazi.Text = "Prikaži";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvProfesoriPrikaz
            // 
            this.dgvProfesoriPrikaz.AllowUserToAddRows = false;
            this.dgvProfesoriPrikaz.AllowUserToDeleteRows = false;
            this.dgvProfesoriPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesoriPrikaz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfesorID,
            this.Ime,
            this.Prezime,
            this.Zvanje,
            this.Kancelarija,
            this.Detalji});
            this.dgvProfesoriPrikaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfesoriPrikaz.Location = new System.Drawing.Point(3, 16);
            this.dgvProfesoriPrikaz.Name = "dgvProfesoriPrikaz";
            this.dgvProfesoriPrikaz.ReadOnly = true;
            this.dgvProfesoriPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfesoriPrikaz.Size = new System.Drawing.Size(577, 356);
            this.dgvProfesoriPrikaz.TabIndex = 1;
            this.dgvProfesoriPrikaz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesoriPrikaz_CellContentClick);
            // 
            // ProfesorID
            // 
            this.ProfesorID.DataPropertyName = "ProfesorID";
            this.ProfesorID.HeaderText = "ProfesorID";
            this.ProfesorID.Name = "ProfesorID";
            this.ProfesorID.ReadOnly = true;
            this.ProfesorID.Visible = false;
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
            // Zvanje
            // 
            this.Zvanje.DataPropertyName = "Zvanje";
            this.Zvanje.HeaderText = "Zvanje";
            this.Zvanje.Name = "Zvanje";
            this.Zvanje.ReadOnly = true;
            // 
            // Kancelarija
            // 
            this.Kancelarija.DataPropertyName = "Kancelarija";
            this.Kancelarija.HeaderText = "Kancelarija";
            this.Kancelarija.Name = "Kancelarija";
            this.Kancelarija.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.DataPropertyName = "Detalji";
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // gbProfesori
            // 
            this.gbProfesori.Controls.Add(this.dgvProfesoriPrikaz);
            this.gbProfesori.Location = new System.Drawing.Point(12, 63);
            this.gbProfesori.Name = "gbProfesori";
            this.gbProfesori.Size = new System.Drawing.Size(583, 375);
            this.gbProfesori.TabIndex = 2;
            this.gbProfesori.TabStop = false;
            this.gbProfesori.Text = "Profesori";
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Location = new System.Drawing.Point(517, 34);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(75, 23);
            this.btnPrikaz.TabIndex = 3;
            this.btnPrikaz.Text = "Prikaži";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // txtProfTrazi
            // 
            this.txtProfTrazi.Location = new System.Drawing.Point(15, 34);
            this.txtProfTrazi.Name = "txtProfTrazi";
            this.txtProfTrazi.Size = new System.Drawing.Size(198, 20);
            this.txtProfTrazi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tražilica";
            // 
            // frmProfesorPrikazAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfTrazi);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.gbProfesori);
            this.Controls.Add(this.btnPrikazi);
            this.Name = "frmProfesorPrikazAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfesor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesoriPrikaz)).EndInit();
            this.gbProfesori.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridView dgvProfesoriPrikaz;
        private System.Windows.Forms.GroupBox gbProfesori;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfesorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zvanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kancelarija;
        private System.Windows.Forms.DataGridViewButtonColumn Detalji;
        private System.Windows.Forms.TextBox txtProfTrazi;
        private System.Windows.Forms.Label label1;
    }
}