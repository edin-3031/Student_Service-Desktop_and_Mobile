using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Ispit
{
    public partial class frmDetaljiIspita : Form
    {
        int _id;
        APIService _service = new APIService("Ispit");
        public frmDetaljiIspita(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmDetaljiIspita_Load(object sender, EventArgs e)
        {
            var result = await _service.GetById<Models.ispiti>(_id);

            txtKurs.Text = result.Kurs;
            txtObjavio.Text = result.Profesor;
            txtDatumOdrzavanja.Text = result.Datum.ToString();
            txtUcionica.Text = result.Ucionica;
            txtTrajanje.Text = result.Trajanje.ToString();
            txtPitanja.Text = result.BrojPitanja.ToString();
            txtBodovi.Text = result.MaxBodova.ToString();

            if (result.ParcijalnoBodovanje == "Da" || result.ParcijalnoBodovanje == "da" || result.ParcijalnoBodovanje == "DA")
                cbParcijalno.Checked = true;
            else if (result.ParcijalnoBodovanje == "Ne" || result.ParcijalnoBodovanje == "ne" || result.ParcijalnoBodovanje == "NE")
                cbParcijalno.Checked = false;
        }

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            var t = MessageBox.Show("Da li ste sigurni da želite obrisati odabrani ispit", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (t == DialogResult.Yes) {
                await _service.Delete(_id);
                MessageBox.Show("Uspješno ste uklonuli ispit");
                this.Close();
            }
        }

        private async void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmIzmijeniIspit frm = new frmIzmijeniIspit(_id);
            frm.Show();
        }
    }
}
