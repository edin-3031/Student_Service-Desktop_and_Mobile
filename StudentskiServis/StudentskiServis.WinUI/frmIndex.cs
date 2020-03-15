using StudentskiServis.WinUI.Administracija;
using StudentskiServis.WinUI.Ispit;
using StudentskiServis.WinUI.Obavijest;
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
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void detaljiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStudentDetalji frm = new frmStudentDetalji();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void prikazToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmAdministracijaPrikaz frm = new frmAdministracijaPrikaz();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void dodajToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmAdministracijaUnosAdmin frm = new frmAdministracijaUnosAdmin();
            frm.Show();
        }

        private void pRIKAZToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmAdministracijaPrikaz frm = new frmAdministracijaPrikaz();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void prikazToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frmAdministracijaPrikaz frm = new frmAdministracijaPrikaz();
            frm.Show();
        }

        private void dodajToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmAdministracijaUnosAdmin frm = new frmAdministracijaUnosAdmin();
            frm.Show();
        }

        private void detaljiToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmStudentDetalji frm = new frmStudentDetalji();
            frm.Show();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        private void novaAdministracijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void prikazToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        private void prikazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void detaljiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void događajiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void dodajToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            
        }
        private void prikazToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            
        }
        private void dodajToolStripMenuItem9_Click(object sender, EventArgs e)
        {
        }
        private void uplateToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
        private void rasporedToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void profesoriToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void prikazToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frmProfesorPrikazAdmin frm = new frmProfesorPrikazAdmin(null);
            frm.Show();
        }

        private void detaljiPredavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPredavanjaDetalji frm = new frmPredavanjaDetalji();
            frm.Show();
        }

        private void dodajžToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNoviProfesor frm = new frmNoviProfesor();
            frm.Show();
        }

        private void prikazToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            frmStudentPrikaz frm = new frmStudentPrikaz();
            frm.Show();
        }

        private void dodajToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frmNoviStudent frm = new frmNoviStudent();
            frm.Show();
        }

        private void dodajPredavanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajPredavanja frm = new frmDodajPredavanja();
            frm.Show();
        }

        private void dodajPohađanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajPohadjanja frm = new frmDodajPohadjanja();
            frm.Show();
        }

        private void prikazToolStripMenuItem11_Click_1(object sender, EventArgs e)
        {
            frmPrikazUplata frm = new frmPrikazUplata();
            frm.Show();
        }

        private void dodajToolStripMenuItem9_Click_1(object sender, EventArgs e)
        {
            frmNovaUplata frm = new frmNovaUplata();
            frm.Show();
        }

        private void prikazToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            frmObavijest frm = new frmObavijest();
            frm.Show();
        }

        private void dodajToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            frmDodajObavijest frm = new frmDodajObavijest();
            frm.Show();
        }

        private void prikazToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            frmPrikazIspita frm = new frmPrikazIspita();
            frm.Show();
        }

        private void dodajToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            frmDodajIspit frm = new frmDodajIspit();
            frm.Show();
        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void administracijaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmPrikazAdministracijeStudent frm = new frmPrikazAdministracijeStudent();
            frm.Show();
        }

        private void profesoriToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmPrikazProfesoraStudent frm = new frmPrikazProfesoraStudent();
            frm.Show();
        }

        private void obavještenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObavjestenjaStudent frm = new frmObavjestenjaStudent();
            frm.Show();
        }

        private void ispitiToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //frmIspitiPrikazStudent frm = new frmIspitiPrikazStudent();
            //frm.Show();
        }
    }
}
