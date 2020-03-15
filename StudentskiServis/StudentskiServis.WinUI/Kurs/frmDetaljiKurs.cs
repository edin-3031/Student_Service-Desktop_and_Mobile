using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Kurs
{
    public partial class frmDetaljiKurs : Form
    {
        int id;
        private readonly APIService _service = new APIService("Kurs");
        public frmDetaljiKurs(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmDetaljiKurs_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.kursevi>(id);

            txtNaziv.Text = temp.Naziv;
            txtECTS.Text = temp.Ects.ToString();
            txtSeminarski.Text = temp.PosjedujeSeminarski;
            txtPraksa.Text = temp.PosjedujePraksu;
        }

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            var t = MessageBox.Show("Da li ste sigurni da želite obrisati odabrani kurs", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (t == DialogResult.Yes) {
                await _service.Delete(id);
                MessageBox.Show("Uspješno ste uklonuli kurs");
                this.Close();
            }
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmKursIzmijeni frm = new frmKursIzmijeni(id);
            frm.Show();
        }
    }
}
