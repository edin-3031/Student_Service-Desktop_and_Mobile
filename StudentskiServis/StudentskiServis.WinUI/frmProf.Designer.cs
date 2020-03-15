namespace StudentskiServis.WinUI
{
    partial class frmProf
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
            this.mojiPodaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obavještenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ispitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikažiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odjeaviSeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mojiPodaciToolStripMenuItem,
            this.obavještenjaToolStripMenuItem,
            this.ispitiToolStripMenuItem,
            this.odjeaviSeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mojiPodaciToolStripMenuItem
            // 
            this.mojiPodaciToolStripMenuItem.Name = "mojiPodaciToolStripMenuItem";
            this.mojiPodaciToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.mojiPodaciToolStripMenuItem.Text = "Moji podaci";
            this.mojiPodaciToolStripMenuItem.Click += new System.EventHandler(this.mojiPodaciToolStripMenuItem_Click);
            // 
            // obavještenjaToolStripMenuItem
            // 
            this.obavještenjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiToolStripMenuItem,
            this.dodajToolStripMenuItem});
            this.obavještenjaToolStripMenuItem.Name = "obavještenjaToolStripMenuItem";
            this.obavještenjaToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.obavještenjaToolStripMenuItem.Text = "Obavještenja";
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
            // ispitiToolStripMenuItem
            // 
            this.ispitiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiToolStripMenuItem1,
            this.dodajToolStripMenuItem1});
            this.ispitiToolStripMenuItem.Name = "ispitiToolStripMenuItem";
            this.ispitiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ispitiToolStripMenuItem.Text = "Ispiti";
            // 
            // prikažiToolStripMenuItem1
            // 
            this.prikažiToolStripMenuItem1.Name = "prikažiToolStripMenuItem1";
            this.prikažiToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.prikažiToolStripMenuItem1.Text = "Prikaži";
            this.prikažiToolStripMenuItem1.Click += new System.EventHandler(this.prikažiToolStripMenuItem1_Click);
            // 
            // dodajToolStripMenuItem1
            // 
            this.dodajToolStripMenuItem1.Image = global::StudentskiServis.WinUI.Properties.Resources.plus_flat;
            this.dodajToolStripMenuItem1.Name = "dodajToolStripMenuItem1";
            this.dodajToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dodajToolStripMenuItem1.Text = "Dodaj";
            this.dodajToolStripMenuItem1.Click += new System.EventHandler(this.dodajToolStripMenuItem1_Click);
            // 
            // odjeaviSeToolStripMenuItem
            // 
            this.odjeaviSeToolStripMenuItem.Name = "odjeaviSeToolStripMenuItem";
            this.odjeaviSeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.odjeaviSeToolStripMenuItem.Text = "Odjavi se";
            this.odjeaviSeToolStripMenuItem.Click += new System.EventHandler(this.odjeaviSeToolStripMenuItem_Click);
            // 
            // frmProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProf";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mojiPodaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obavještenjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ispitiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikažiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odjeaviSeToolStripMenuItem;
    }
}