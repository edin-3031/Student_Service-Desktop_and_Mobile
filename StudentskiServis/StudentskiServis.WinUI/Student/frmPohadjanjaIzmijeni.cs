using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Student
{
    public partial class frmPohadjanjaIzmijeni : Form
    {
        int? id;
        APIService _service = new APIService("Pohadjanja");

        public frmPohadjanjaIzmijeni(int? _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmPohadjanjaIzmijeni_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.pohadjanja>(id);
            //KURS
            txtKurs.Text = temp.Naziv;

            //AKTIVAN
            if (temp.Aktivan == "Da" || temp.Aktivan == "DA" || temp.Aktivan == "da")
                cbAktivan.Checked = true;
            else if(temp.Aktivan == "Ne" || temp.Aktivan == "NE" || temp.Aktivan == "ne")
                cbAktivan.Checked = false;

            //OBNAVLJA
            if (temp.Obnavlja == "Da" || temp.Obnavlja == "DA" || temp.Obnavlja == "da")
                cbObnavlja.Checked = true;
            else if(temp.Obnavlja == "Ne" || temp.Obnavlja == "NE" || temp.Obnavlja == "ne")
                cbObnavlja.Checked = false;
            txtBrojObnavljanja.Text = temp.BrojObnavljanja.ToString();

            if (cbObnavlja.Checked == false)
            {
                txtBrojObnavljanja.Enabled = false;
            }

            //POLOŽIO
            if (temp.Polozio == "Da" || temp.Polozio == "DA" || temp.Polozio == "da")
                cbPolozio.Checked = true;
            else if(temp.Polozio == "Ne" || temp.Polozio == "NE" || temp.Polozio == "ne")
                cbPolozio.Checked = false;
            txtOcjena.Text = temp.Ocjena.ToString();

            if (cbPolozio.Checked == false)
            {
                txtOcjena.Enabled = false;
            }
        }

        private void cbObnavlja_CheckedChanged(object sender, EventArgs e)
        {
            if (cbObnavlja.Checked == true)
                txtBrojObnavljanja.Enabled = true;
            else if (cbObnavlja.Checked == false)
                txtBrojObnavljanja.Enabled = false;
        }

        private void cbPolozio_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPolozio.Checked == false)
                txtOcjena.Enabled = false;
            else if (cbPolozio.Checked == true)
                txtOcjena.Enabled = true;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.pohadjanja>(id);

            temp.Naziv = txtKurs.Text;

            if (cbAktivan.Checked == true)
                temp.Aktivan = "Da";
            else if (cbAktivan.Checked == false)
                temp.Aktivan = "Ne";

            if (cbObnavlja.Checked == true)
            {
                temp.Obnavlja = "Da";
                temp.BrojObnavljanja = int.Parse(txtBrojObnavljanja.Text);
            }
            else if (cbObnavlja.Checked == false)
            {
                temp.Obnavlja = "Ne";
            }

            if (cbPolozio.Checked == true)
            {
                temp.Polozio = "Da";
                temp.Ocjena = int.Parse(txtOcjena.Text);
            }
            else if (cbPolozio.Checked == false)
            {
                temp.Polozio = "Ne";
                temp.Ocjena = 0;
            }

            await _service.Update<Models.pohadjanja>(id, temp);

            MessageBox.Show("Uspješno ste izmijenili podatke");
            this.Close();
        }
    }
}
