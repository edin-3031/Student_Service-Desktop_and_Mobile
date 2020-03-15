using StudentskiServis.WinUI.Administracija;
using StudentskiServis.WinUI.Kurs;
using StudentskiServis.WinUI.Login;
using StudentskiServis.WinUI.Profesor;
using StudentskiServis.WinUI.Student;
using StudentskiServis.WinUI.Uplata;
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
    public partial class frmAdmin : Form
    {
        int adminId;
        public frmAdmin(int adminID)
        {
            InitializeComponent();
            adminId = adminID;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
        }

        private void prikažiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministracijaPrikaz frm = new frmAdministracijaPrikaz();
            frm.Show();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministracijaUnosAdmin frm = new frmAdministracijaUnosAdmin();
            frm.Show();
        }

        private void prikažiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProfesorPrikazAdmin frm = new frmProfesorPrikazAdmin(null);
            frm.Show();
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNoviProfesor frm = new frmNoviProfesor();
            frm.Show();
        }

        private void detaljiPredavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPredavanjaDetalji frm = new frmPredavanjaDetalji();
            frm.Show();
        }

        private void dodajPredavanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajPredavanja frm = new frmDodajPredavanja();
            frm.Show();
        }

        private void prikazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentPrikaz frm = new frmStudentPrikaz();
            frm.Show();
        }

        private void dodajToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmNoviStudent frm = new frmNoviStudent();
            frm.Show();
        }

        private void detaljiPohađanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentDetalji frm = new frmStudentDetalji();
            frm.Show();
        }

        private void dodajPohađanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajPohadjanja frm = new frmDodajPohadjanja();
            frm.Show();
        }

        private void prikažiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPrikazUplata frm = new frmPrikazUplata();
            frm.Show();
        }

        private void dodajToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmNovaUplata frm = new frmNovaUplata();
            frm.Show();
        }

        private void odjaviSeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mojiPodaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminMojiPodaci frm = new frmAdminMojiPodaci(adminId);
            frm.Show();
        }

        private void prikažiToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmKursPrikaz frm = new frmKursPrikaz();
            frm.Show();
        }

        private void dodajToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmKursDodaj frm = new frmKursDodaj();
            frm.Show();
        }
    }
}
