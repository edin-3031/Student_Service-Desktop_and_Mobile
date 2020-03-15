using StudentskiServis.WinUI.Ispit;
using StudentskiServis.WinUI.Login;
using StudentskiServis.WinUI.Obavijest;
using StudentskiServis.WinUI.Profesor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI
{
    public partial class frmProf : Form
    {
        int profId;
        public frmProf(int profID)
        {
            InitializeComponent();

            profId = profID;
        }

        private void prikažiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObavijest frm = new frmObavijest();
            frm.Show();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajObavijest frm = new frmDodajObavijest();
            frm.Show();
        }

        private void prikažiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrikazIspita frm = new frmPrikazIspita();
            frm.Show();
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDodajIspit frm = new frmDodajIspit();
            frm.Show();
        }

        private void odjeaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mojiPodaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfesorMojiPodaci frm = new frmProfesorMojiPodaci(profId);
            frm.Show();
        }
    }
}
