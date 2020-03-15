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
    public partial class frmMojRasporedIzmjena : Form
    {
        int id;
        private readonly APIService _service = new APIService("Raspored");
        public frmMojRasporedIzmjena(int _id)
        {
            id = _id;
            InitializeComponent();
        }

        private async void frmMojRasporedIzmjena_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.Raspored>(id);

            txtNaslov.Text = temp.Naslov;
            dateDatum.Value = temp.Datum.Value;
            if (temp.Vazno == "DA" || temp.Vazno == "Da" || temp.Vazno == "da")
                cbVazno.Checked = true;
            else if(temp.Vazno == "NE" || temp.Vazno == "Ne" || temp.Vazno == "ne")
                cbVazno.Checked = false;
            rtbOpis.Text = temp.Opis;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.Raspored>(id);

            temp.Datum = dateDatum.Value;
            temp.Naslov = txtNaslov.Text;
            temp.Opis = rtbOpis.Text;
            if (cbVazno.Checked == true)
                temp.Vazno = "Da";
            else if (cbVazno.Checked == false)
                temp.Vazno = "Ne";

            await _service.Update<Models.Raspored>(id, temp);
            MessageBox.Show("Uspješno ste sačuvali izmjnene");
            this.Close();
        }
    }
}
