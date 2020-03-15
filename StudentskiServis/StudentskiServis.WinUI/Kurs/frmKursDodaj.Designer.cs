namespace StudentskiServis.WinUI.Kurs
{
    partial class frmKursDodaj
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
            this.cb_Praksa = new System.Windows.Forms.CheckBox();
            this.cb_Seminarski = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txt_ECTS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Naziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errKurs = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errKurs)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Praksa
            // 
            this.cb_Praksa.AutoSize = true;
            this.cb_Praksa.Location = new System.Drawing.Point(72, 195);
            this.cb_Praksa.Name = "cb_Praksa";
            this.cb_Praksa.Size = new System.Drawing.Size(107, 17);
            this.cb_Praksa.TabIndex = 28;
            this.cb_Praksa.Text = "Posjeduje praksu";
            this.cb_Praksa.UseVisualStyleBackColor = true;
            // 
            // cb_Seminarski
            // 
            this.cb_Seminarski.AutoSize = true;
            this.cb_Seminarski.Location = new System.Drawing.Point(72, 154);
            this.cb_Seminarski.Name = "cb_Seminarski";
            this.cb_Seminarski.Size = new System.Drawing.Size(142, 17);
            this.cb_Seminarski.TabIndex = 27;
            this.cb_Seminarski.Text = "Posjeduje seminarski rad";
            this.cb_Seminarski.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(91, 271);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(101, 35);
            this.btnSacuvaj.TabIndex = 26;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txt_ECTS
            // 
            this.txt_ECTS.Location = new System.Drawing.Point(72, 108);
            this.txt_ECTS.Name = "txt_ECTS";
            this.txt_ECTS.Size = new System.Drawing.Size(151, 20);
            this.txt_ECTS.TabIndex = 25;
            this.txt_ECTS.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ECTS_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ECTS";
            // 
            // txt_Naziv
            // 
            this.txt_Naziv.Location = new System.Drawing.Point(72, 57);
            this.txt_Naziv.Name = "txt_Naziv";
            this.txt_Naziv.Size = new System.Drawing.Size(151, 20);
            this.txt_Naziv.TabIndex = 23;
            this.txt_Naziv.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Naziv_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Naziv";
            // 
            // errKurs
            // 
            this.errKurs.ContainerControl = this;
            // 
            // frmKursDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 338);
            this.Controls.Add(this.cb_Praksa);
            this.Controls.Add(this.cb_Seminarski);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txt_ECTS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Naziv);
            this.Controls.Add(this.label1);
            this.Name = "frmKursDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKursDodaj";
            ((System.ComponentModel.ISupportInitialize)(this.errKurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_Praksa;
        private System.Windows.Forms.CheckBox cb_Seminarski;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txt_ECTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Naziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errKurs;
    }
}