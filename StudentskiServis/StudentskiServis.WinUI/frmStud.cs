using StudentskiServis.WinUI.Administracija;
using StudentskiServis.WinUI.Ispit;
using StudentskiServis.WinUI.Login;
using StudentskiServis.WinUI.Obavijest;
using StudentskiServis.WinUI.Profesor;
using StudentskiServis.WinUI.Raspored;
using StudentskiServis.WinUI.Student;
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
    public partial class frmStud : Form
    {
        int studId;
        public frmStud(int studID)
        {
            InitializeComponent();
            studId = studID;
        }

        private void administracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazAdministracijeStudent frm = new frmPrikazAdministracijeStudent();
            frm.Show();
        }

        private void profesoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazProfesoraStudent frm = new frmPrikazProfesoraStudent();
            frm.Show();
        }

        private void obavještenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObavjestenjaStudent frm = new frmObavjestenjaStudent();
            frm.Show();
        }

        private void ispitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIspitiPrikazStudent frm = new frmIspitiPrikazStudent(studId);
            frm.Show();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mojiPodaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMojiPodaci frm = new frmMojiPodaci(studId);
            frm.Show();
        }

        private void mojeUplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMojeUplate frm = new frmMojeUplate(studId);
            frm.Show();
        }

        private void mojRasporedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void prikažiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMojRaspored frm = new frmMojRaspored(studId);
            frm.Show();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMojRasporedDodaj frm = new frmMojRasporedDodaj(studId);
            frm.Show();
        }

        private void mojiKurseviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMojiKursevi frm = new frmMojiKursevi(studId);
            frm.Show();
        }
    }
}
