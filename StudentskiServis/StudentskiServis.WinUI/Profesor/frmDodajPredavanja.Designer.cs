namespace StudentskiServis.WinUI.Profesor
{
    partial class frmDodajPredavanja
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
            this.cboxProfesor = new System.Windows.Forms.ComboBox();
            this.cboxKurs = new System.Windows.Forms.ComboBox();
            this.datePredavanje = new System.Windows.Forms.DateTimePicker();
            this.cbOdrzano = new System.Windows.Forms.CheckBox();
            this.rbtnV = new System.Windows.Forms.RadioButton();
            this.rbtnP = new System.Windows.Forms.RadioButton();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxProfesor
            // 
            this.cboxProfesor.FormattingEnabled = true;
            this.cboxProfesor.Location = new System.Drawing.Point(10, 38);
            this.cboxProfesor.Name = "cboxProfesor";
            this.cboxProfesor.Size = new System.Drawing.Size(200, 21);
            this.cboxProfesor.TabIndex = 0;
            this.cboxProfesor.SelectedIndexChanged += new System.EventHandler(this.cboxProfesor_SelectedIndexChanged);
            // 
            // cboxKurs
            // 
            this.cboxKurs.FormattingEnabled = true;
            this.cboxKurs.Location = new System.Drawing.Point(233, 38);
            this.cboxKurs.Name = "cboxKurs";
            this.cboxKurs.Size = new System.Drawing.Size(200, 21);
            this.cboxKurs.TabIndex = 1;
            // 
            // datePredavanje
            // 
            this.datePredavanje.Location = new System.Drawing.Point(459, 39);
            this.datePredavanje.MaxDate = new System.DateTime(2109, 12, 28, 0, 0, 0, 0);
            this.datePredavanje.Name = "datePredavanje";
            this.datePredavanje.Size = new System.Drawing.Size(200, 20);
            this.datePredavanje.TabIndex = 2;
            // 
            // cbOdrzano
            // 
            this.cbOdrzano.AutoSize = true;
            this.cbOdrzano.Location = new System.Drawing.Point(459, 131);
            this.cbOdrzano.Name = "cbOdrzano";
            this.cbOdrzano.Size = new System.Drawing.Size(66, 17);
            this.cbOdrzano.TabIndex = 3;
            this.cbOdrzano.Text = "Održano";
            this.cbOdrzano.UseVisualStyleBackColor = true;
            // 
            // rbtnV
            // 
            this.rbtnV.AutoSize = true;
            this.rbtnV.Location = new System.Drawing.Point(459, 89);
            this.rbtnV.Name = "rbtnV";
            this.rbtnV.Size = new System.Drawing.Size(57, 17);
            this.rbtnV.TabIndex = 0;
            this.rbtnV.Text = "Vježba";
            this.rbtnV.UseVisualStyleBackColor = true;
            // 
            // rbtnP
            // 
            this.rbtnP.AutoSize = true;
            this.rbtnP.Location = new System.Drawing.Point(568, 89);
            this.rbtnP.Name = "rbtnP";
            this.rbtnP.Size = new System.Drawing.Size(79, 17);
            this.rbtnP.TabIndex = 1;
            this.rbtnP.Text = "Predavanje";
            this.rbtnP.UseVisualStyleBackColor = true;
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(10, 65);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(423, 218);
            this.rtbOpis.TabIndex = 4;
            this.rtbOpis.Text = "";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(559, 242);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(110, 41);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kurs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum predavanja";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vrsta";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmDodajPredavanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 298);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.rbtnP);
            this.Controls.Add(this.rbtnV);
            this.Controls.Add(this.cbOdrzano);
            this.Controls.Add(this.datePredavanje);
            this.Controls.Add(this.cboxKurs);
            this.Controls.Add(this.cboxProfesor);
            this.Name = "frmDodajPredavanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDodajPredavanja";
            this.Load += new System.EventHandler(this.frmDodajPredavanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxProfesor;
        private System.Windows.Forms.ComboBox cboxKurs;
        private System.Windows.Forms.DateTimePicker datePredavanje;
        private System.Windows.Forms.CheckBox cbOdrzano;
        private System.Windows.Forms.RadioButton rbtnV;
        private System.Windows.Forms.RadioButton rbtnP;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}