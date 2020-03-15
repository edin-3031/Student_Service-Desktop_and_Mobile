namespace StudentskiServis.WinUI.Obavijest
{
    partial class frmDodajObavijest
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbSadrzaj = new System.Windows.Forms.RichTextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.datObjava = new System.Windows.Forms.DateTimePicker();
            this.cbObjavio = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errObavijest = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errObavijest)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Naslov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Datum objavljivanja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Objavljuje";
            // 
            // rtbSadrzaj
            // 
            this.rtbSadrzaj.Location = new System.Drawing.Point(18, 115);
            this.rtbSadrzaj.Name = "rtbSadrzaj";
            this.rtbSadrzaj.Size = new System.Drawing.Size(640, 307);
            this.rtbSadrzaj.TabIndex = 28;
            this.rtbSadrzaj.Text = "";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(585, 43);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(200, 20);
            this.txtNaslov.TabIndex = 27;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaslov_Validating);
            // 
            // datObjava
            // 
            this.datObjava.Location = new System.Drawing.Point(301, 44);
            this.datObjava.Name = "datObjava";
            this.datObjava.Size = new System.Drawing.Size(200, 20);
            this.datObjava.TabIndex = 26;
            // 
            // cbObjavio
            // 
            this.cbObjavio.FormattingEnabled = true;
            this.cbObjavio.Location = new System.Drawing.Point(18, 44);
            this.cbObjavio.Name = "cbObjavio";
            this.cbObjavio.Size = new System.Drawing.Size(200, 21);
            this.cbObjavio.TabIndex = 25;
            this.cbObjavio.Validating += new System.ComponentModel.CancelEventHandler(this.cbObjavio_Validating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(683, 248);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(102, 37);
            this.btnSacuvaj.TabIndex = 24;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // errObavijest
            // 
            this.errObavijest.ContainerControl = this;
            // 
            // frmDodajObavijest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbSadrzaj);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.datObjava);
            this.Controls.Add(this.cbObjavio);
            this.Controls.Add(this.btnSacuvaj);
            this.Name = "frmDodajObavijest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDodajObavijest";
            this.Load += new System.EventHandler(this.frmDodajObavijest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errObavijest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbSadrzaj;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.DateTimePicker datObjava;
        private System.Windows.Forms.ComboBox cbObjavio;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errObavijest;
    }
}