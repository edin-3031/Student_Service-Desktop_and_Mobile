using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Raspored
{
    public partial class MojRasporedDetalji : Form
    {
        int id;
        private readonly APIService _service = new APIService("Raspored");
        public MojRasporedDetalji(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void MojRasporedDetalji_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.Raspored>(id);

            txtNaslov.Text = temp.Naslov;
            txtDatum.Text = temp.Datum.ToString();
            if (temp.Vazno == "DA" || temp.Vazno == "Da" || temp.Vazno == "da")
                cbVazno.Checked = true;
            else if(temp.Vazno == "NE" || temp.Vazno == "Ne" || temp.Vazno == "ne")
                cbVazno.Checked = false;
            rtbOpis.Text = temp.Opis;
        }

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            var t = MessageBox.Show("Da li ste sigurni da želite obrisati odabrani podataka", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (t == DialogResult.Yes)
            {
                await _service.Delete(id);
                MessageBox.Show("Uspješno ste izvršili brisanje");
                this.Close();
            }
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmMojRasporedIzmjena frm = new frmMojRasporedIzmjena(id);
            frm.Show();
        }
    }
}
