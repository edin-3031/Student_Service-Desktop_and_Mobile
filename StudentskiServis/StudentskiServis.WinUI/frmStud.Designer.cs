namespace StudentskiServis.WinUI
{
    partial class frmStud
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obavještenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ispitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojRasporedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojiKurseviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojeUplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mojiPodaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obavještenjaToolStripMenuItem,
            this.ispitiToolStripMenuItem,
            this.mojRasporedToolStripMenuItem,
            this.mojiKurseviToolStripMenuItem,
            this.mojeUplateToolStripMenuItem,
            this.mojiPodaciToolStripMenuItem,
            this.administracijaToolStripMenuItem,
            this.profesoriToolStripMenuItem,
            this.odjaviSeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obavještenjaToolStripMenuItem
            // 
            this.obavještenjaToolStripMenuItem.Name = "obavještenjaToolStripMenuItem";
            this.obavještenjaToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.obavještenjaToolStripMenuItem.Text = "Obavještenja";
            this.obavještenjaToolStripMenuItem.Click += new System.EventHandler(this.obavještenjaToolStripMenuItem_Click);
            // 
            // ispitiToolStripMenuItem
            // 
            this.ispitiToolStripMenuItem.Name = "ispitiToolStripMenuItem";
            this.ispitiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ispitiToolStripMenuItem.Text = "Ispiti";
            this.ispitiToolStripMenuItem.Click += new System.EventHandler(this.ispitiToolStripMenuItem_Click);
            // 
            // mojRasporedToolStripMenuItem
            // 
            this.mojRasporedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiToolStripMenuItem,
            this.dodajToolStripMenuItem});
            this.mojRasporedToolStripMenuItem.Name = "mojRasporedToolStripMenuItem";
            this.mojRasporedToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.mojRasporedToolStripMenuItem.Text = "Moj raspored";
            this.mojRasporedToolStripMenuItem.Click += new System.EventHandler(this.mojRasporedToolStripMenuItem_Click);
            // 
            // prikažiToolStripMenuItem
            // 
            this.prikažiToolStripMenuItem.Name = "prikažiToolStripMenuItem";
            this.prikažiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prikažiToolStripMenuItem.Text = "Prikaži";
            this.prikažiToolStripMenuItem.Click += new System.EventHandler(this.prikažiToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Image = global::StudentskiServis.WinUI.Properties.Resources.plus_flat;
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // mojiKurseviToolStripMenuItem
            // 
            this.mojiKurseviToolStripMenuItem.Name = "mojiKurseviToolStripMenuItem";
            this.mojiKurseviToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.mojiKurseviToolStripMenuItem.Text = "Moji kursevi";
            this.mojiKurseviToolStripMenuItem.Click += new System.EventHandler(this.mojiKurseviToolStripMenuItem_Click);
            // 
            // mojeUplateToolStripMenuItem
            // 
            this.mojeUplateToolStripMenuItem.Name = "mojeUplateToolStripMenuItem";
            this.mojeUplateToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.mojeUplateToolStripMenuItem.Text = "Moje uplate";
            this.mojeUplateToolStripMenuItem.Click += new System.EventHandler(this.mojeUplateToolStripMenuItem_Click);
            // 
            // mojiPodaciToolStripMenuItem
            // 
            this.mojiPodaciToolStripMenuItem.Name = "mojiPodaciToolStripMenuItem";
            this.mojiPodaciToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.mojiPodaciToolStripMenuItem.Text = "Moji podaci";
            this.mojiPodaciToolStripMenuItem.Click += new System.EventHandler(this.mojiPodaciToolStripMenuItem_Click);
            // 
            // administracijaToolStripMenuItem
            // 
            this.administracijaToolStripMenuItem.Name = "administracijaToolStripMenuItem";
            this.administracijaToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administracijaToolStripMenuItem.Text = "Administracija";
            this.administracijaToolStripMenuItem.Click += new System.EventHandler(this.administracijaToolStripMenuItem_Click);
            // 
            // profesoriToolStripMenuItem
            // 
            this.profesoriToolStripMenuItem.Name = "profesoriToolStripMenuItem";
            this.profesoriToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.profesoriToolStripMenuItem.Text = "Profesori";
            this.profesoriToolStripMenuItem.Click += new System.EventHandler(this.profesoriToolStripMenuItem_Click);
            // 
            // odjaviSeToolStripMenuItem
            // 
            this.odjaviSeToolStripMenuItem.Name = "odjaviSeToolStripMenuItem";
            this.odjaviSeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.odjaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjaviSeToolStripMenuItem_Click);
            // 
            // frmStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStud";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mojiPodaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojeUplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obavještenjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojRasporedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ispitiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjaviSeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mojiKurseviToolStripMenuItem;
    }
}