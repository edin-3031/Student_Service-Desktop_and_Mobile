namespace StudentskiServis.WinUI.Profesor
{
    partial class frmProfesorMojiPodaciIzmjena
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
            this.btnPassEdit = new System.Windows.Forms.Button();
            this.btnIzmjenaSlike = new System.Windows.Forms.Button();
            this.editSlika = new System.Windows.Forms.PictureBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textEMail = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.editSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPassEdit
            // 
            this.btnPassEdit.Location = new System.Drawing.Point(23, 219);
            this.btnPassEdit.Name = "btnPassEdit";
            this.btnPassEdit.Size = new System.Drawing.Size(115, 23);
            this.btnPassEdit.TabIndex = 139;
            this.btnPassEdit.Text = "Promijeni šifru";
            this.btnPassEdit.UseVisualStyleBackColor = true;
            this.btnPassEdit.Click += new System.EventHandler(this.btnPassEdit_Click);
            // 
            // btnIzmjenaSlike
            // 
            this.btnIzmjenaSlike.Location = new System.Drawing.Point(320, 199);
            this.btnIzmjenaSlike.Name = "btnIzmjenaSlike";
            this.btnIzmjenaSlike.Size = new System.Drawing.Size(115, 23);
            this.btnIzmjenaSlike.TabIndex = 138;
            this.btnIzmjenaSlike.Text = "Promijeni sliku";
            this.btnIzmjenaSlike.UseVisualStyleBackColor = true;
            this.btnIzmjenaSlike.Click += new System.EventHandler(this.btnIzmjenaSlike_Click);
            // 
            // editSlika
            // 
            this.editSlika.Location = new System.Drawing.Point(297, 39);
            this.editSlika.Name = "editSlika";
            this.editSlika.Size = new System.Drawing.Size(156, 154);
            this.editSlika.TabIndex = 137;
            this.editSlika.TabStop = false;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(361, 282);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(92, 33);
            this.btnSaveEdit.TabIndex = 136;
            this.btnSaveEdit.Text = "Sačuvaj";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(23, 39);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(232, 20);
            this.textLastName.TabIndex = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 128;
            this.label5.Text = "Ime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 129;
            this.label7.Text = "Prezime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 131;
            this.label8.Text = "E-mail";
            // 
            // textEMail
            // 
            this.textEMail.Location = new System.Drawing.Point(23, 130);
            this.textEMail.Name = "textEMail";
            this.textEMail.Size = new System.Drawing.Size(232, 20);
            this.textEMail.TabIndex = 132;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(23, 84);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(232, 20);
            this.textFirstName.TabIndex = 135;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(23, 173);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(232, 20);
            this.textAddress.TabIndex = 134;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 157);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 133;
            this.label21.Text = "Adresa";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmProfesorMojiPodaciIzmjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 339);
            this.Controls.Add(this.btnPassEdit);
            this.Controls.Add(this.btnIzmjenaSlike);
            this.Controls.Add(this.editSlika);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEMail);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label21);
            this.Name = "frmProfesorMojiPodaciIzmjena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfesorMojiPodaciIzmjena";
            this.Load += new System.EventHandler(this.frmProfesorMojiPodaciIzmjena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPassEdit;
        private System.Windows.Forms.Button btnIzmjenaSlike;
        private System.Windows.Forms.PictureBox editSlika;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textEMail;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}