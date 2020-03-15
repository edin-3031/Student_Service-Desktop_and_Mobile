using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Profesor
{
    public partial class frmProfesorDetaljiAdmin : Form
    {
        int? _id = null;
        APIService _service = new APIService("Predavanja");
        public frmProfesorDetaljiAdmin(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmProfesorDetaljiAdmin_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var temp = await _service.GetById<Models.predavanja>(_id);

                txtDatum.Text = temp.DatumPredavanja.ToString();
                if (temp.Odrzano == "Da" || temp.Odrzano == "DA" || temp.Odrzano == "da")
                    cBoxOdrzano.Checked = true;
                else if (temp.Odrzano == "Ne" || temp.Odrzano == "NE" || temp.Odrzano == "ne")
                    cBoxOdrzano.Checked = false;

                txtVrsta.Text = temp.Vrsta;
                rtbOpis.Text = temp.Opis;
            }
        }

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            await _service.Delete(_id);
            MessageBox.Show("Uspješno ste uklonuli predavanje/vježbu");
        }

        private async void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmPredavanjeIzmjena frm = new frmPredavanjeIzmjena(_id);
            frm.Show();
        }
    }
}
