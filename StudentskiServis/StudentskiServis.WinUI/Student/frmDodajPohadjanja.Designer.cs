namespace StudentskiServis.WinUI.Student
{
    partial class frmDodajPohadjanja
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
            this.components = new System.ComponentModel.Container();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.cbKurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnPolozioNE = new System.Windows.Forms.RadioButton();
            this.rbtnPolozioDA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnaktivanNE = new System.Windows.Forms.RadioButton();
            this.rbtnaktivanDA = new System.Windows.Forms.RadioButton();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtOcjena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBrojObnavljanja = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbObnavljaNE = new System.Windows.Forms.RadioButton();
            this.rbObnavljaDA = new System.Windows.Forms.RadioButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStudent
            // 
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(12, 37);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(200, 21);
            this.cbStudent.TabIndex = 0;
            this.cbStudent.SelectedIndexChanged += new System.EventHandler(this.cbStudent_SelectedIndexChanged);
            this.cbStudent.Validating += new System.ComponentModel.CancelEventHandler(this.cbStudent_Validating);
            // 
            // cbKurs
            // 
            this.cbKurs.FormattingEnabled = true;
            this.cbKurs.Location = new System.Drawing.Point(218, 37);
            this.cbKurs.Name = "cbKurs";
            this.cbKurs.Size = new System.Drawing.Size(200, 21);
            this.cbKurs.TabIndex = 1;
            this.cbKurs.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.cbKurs.Validating += new System.ComponentModel.CancelEventHandler(this.cbKurs_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kurs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnPolozioNE);
            this.groupBox1.Controls.Add(this.rbtnPolozioDA);
            this.groupBox1.Location = new System.Drawing.Point(83, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 67);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Položio";
            // 
            // rbtnPolozioNE
            // 
            this.rbtnPolozioNE.AutoSize = true;
            this.rbtnPolozioNE.Location = new System.Drawing.Point(68, 36);
            this.rbtnPolozioNE.Name = "rbtnPolozioNE";
            this.rbtnPolozioNE.Size = new System.Drawing.Size(39, 17);
            this.rbtnPolozioNE.TabIndex = 1;
            this.rbtnPolozioNE.TabStop = true;
            this.rbtnPolozioNE.Text = "Ne";
            this.rbtnPolozioNE.UseVisualStyleBackColor = true;
            this.rbtnPolozioNE.CheckedChanged += new System.EventHandler(this.rbtnobnavljaNE_CheckedChanged);
            this.rbtnPolozioNE.Validating += new System.ComponentModel.CancelEventHandler(this.rbtnPolozioNE_Validating);
            // 
            // rbtnPolozioDA
            // 
            this.rbtnPolozioDA.AutoSize = true;
            this.rbtnPolozioDA.Location = new System.Drawing.Point(6, 36);
            this.rbtnPolozioDA.Name = "rbtnPolozioDA";
            this.rbtnPolozioDA.Size = new System.Drawing.Size(39, 17);
            this.rbtnPolozioDA.TabIndex = 0;
            this.rbtnPolozioDA.TabStop = true;
            this.rbtnPolozioDA.Text = "Da";
            this.rbtnPolozioDA.UseVisualStyleBackColor = true;
            this.rbtnPolozioDA.CheckedChanged += new System.EventHandler(this.rbtnobnavljaDA_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnaktivanNE);
            this.groupBox2.Controls.Add(this.rbtnaktivanDA);
            this.groupBox2.Location = new System.Drawing.Point(83, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 67);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktivan";
            this.groupBox2.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox2_Validating);
            // 
            // rbtnaktivanNE
            // 
            this.rbtnaktivanNE.AutoSize = true;
            this.rbtnaktivanNE.Location = new System.Drawing.Point(68, 36);
            this.rbtnaktivanNE.Name = "rbtnaktivanNE";
            this.rbtnaktivanNE.Size = new System.Drawing.Size(39, 17);
            this.rbtnaktivanNE.TabIndex = 3;
            this.rbtnaktivanNE.TabStop = true;
            this.rbtnaktivanNE.Text = "Ne";
            this.rbtnaktivanNE.UseVisualStyleBackColor = true;
            this.rbtnaktivanNE.CheckedChanged += new System.EventHandler(this.rbtnaktivanNE_CheckedChanged);
            this.rbtnaktivanNE.Validating += new System.ComponentModel.CancelEventHandler(this.rbtnaktivanNE_Validating);
            // 
            // rbtnaktivanDA
            // 
            this.rbtnaktivanDA.AutoSize = true;
            this.rbtnaktivanDA.Location = new System.Drawing.Point(6, 36);
            this.rbtnaktivanDA.Name = "rbtnaktivanDA";
            this.rbtnaktivanDA.Size = new System.Drawing.Size(39, 17);
            this.rbtnaktivanDA.TabIndex = 2;
            this.rbtnaktivanDA.TabStop = true;
            this.rbtnaktivanDA.Text = "Da";
            this.rbtnaktivanDA.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(159, 348);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(107, 38);
            this.btnSacuvaj.TabIndex = 6;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtOcjena
            // 
            this.txtOcjena.Location = new System.Drawing.Point(237, 266);
            this.txtOcjena.Name = "txtOcjena";
            this.txtOcjena.Size = new System.Drawing.Size(100, 20);
            this.txtOcjena.TabIndex = 7;
            this.txtOcjena.Validating += new System.ComponentModel.CancelEventHandler(this.txtOcjena_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ocjena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Broj obnavljanja";
            // 
            // txtBrojObnavljanja
            // 
            this.txtBrojObnavljanja.Location = new System.Drawing.Point(237, 193);
            this.txtBrojObnavljanja.Name = "txtBrojObnavljanja";
            this.txtBrojObnavljanja.Size = new System.Drawing.Size(100, 20);
            this.txtBrojObnavljanja.TabIndex = 10;
            this.txtBrojObnavljanja.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojObnavljanja_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbObnavljaNE);
            this.groupBox3.Controls.Add(this.rbObnavljaDA);
            this.groupBox3.Location = new System.Drawing.Point(83, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 67);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Obnavlja";
            this.groupBox3.Validating += new System.ComponentModel.CancelEventHandler(this.groupBox3_Validating);
            // 
            // rbObnavljaNE
            // 
            this.rbObnavljaNE.AutoSize = true;
            this.rbObnavljaNE.Location = new System.Drawing.Point(68, 36);
            this.rbObnavljaNE.Name = "rbObnavljaNE";
            this.rbObnavljaNE.Size = new System.Drawing.Size(39, 17);
            this.rbObnavljaNE.TabIndex = 1;
            this.rbObnavljaNE.TabStop = true;
            this.rbObnavljaNE.Text = "Ne";
            this.rbObnavljaNE.UseVisualStyleBackColor = true;
            this.rbObnavljaNE.CheckedChanged += new System.EventHandler(this.rbObnavljaNE_CheckedChanged);
            this.rbObnavljaNE.Validating += new System.ComponentModel.CancelEventHandler(this.rbObnavljaNE_Validating);
            // 
            // rbObnavljaDA
            // 
            this.rbObnavljaDA.AutoSize = true;
            this.rbObnavljaDA.Location = new System.Drawing.Point(6, 36);
            this.rbObnavljaDA.Name = "rbObnavljaDA";
            this.rbObnavljaDA.Size = new System.Drawing.Size(39, 17);
            this.rbObnavljaDA.TabIndex = 0;
            this.rbObnavljaDA.TabStop = true;
            this.rbObnavljaDA.Text = "Da";
            this.rbObnavljaDA.UseVisualStyleBackColor = true;
            this.rbObnavljaDA.CheckedChanged += new System.EventHandler(this.rbObnavljaDA_CheckedChanged);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmDodajPohadjanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 405);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrojObnavljanja);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOcjena);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKurs);
            this.Controls.Add(this.cbStudent);
            this.Name = "frmDodajPohadjanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDodajPohadjanja";
            this.Load += new System.EventHandler(this.frmDodajPohadjanja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.ComboBox cbKurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtOcjena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnPolozioNE;
        private System.Windows.Forms.RadioButton rbtnPolozioDA;
        private System.Windows.Forms.RadioButton rbtnaktivanNE;
        private System.Windows.Forms.RadioButton rbtnaktivanDA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBrojObnavljanja;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbObnavljaNE;
        private System.Windows.Forms.RadioButton rbObnavljaDA;
        private System.Windows.Forms.ErrorProvider error;
    }
}