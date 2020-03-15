using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Uplata
{
    public partial class frmDetaljiUplata : Form
    {
        int _id;
        APIService _service = new APIService("Uplata");
        public frmDetaljiUplata(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmDetaljiUplata_Load(object sender, EventArgs e)
        {
            var uplata = await _service.GetById<Models.uplate>(_id);

            txtSvrha.Text = uplata.Svrha;
            txtIznos.Text = uplata.Iznos.ToString();
            txtDatUplate.Text = uplata.DatumUplate.ToString();
            txtUplatio.Text = uplata.Uplatio;
            txtEvidentirao.Text = uplata.Evidentirao;

            if (uplata.Ovjereno == "DA" || uplata.Ovjereno == "Da" || uplata.Ovjereno == "da")
                cbOvjereno.Checked = true;
            else if (uplata.Ovjereno == "NE" || uplata.Ovjereno == "Ne" || uplata.Ovjereno == "ne")
                cbOvjereno.Checked = false;

            if (uplata.Slika == null)
                pictureBoxUplata.Image = Properties.Resources.No_Picture;
            else if (uplata.Slika != null)
                pictureBoxUplata.Image = (Bitmap)(new ImageConverter().ConvertFrom(uplata.Slika));
        }
        private void pictureBoxUplata_Click(object sender, EventArgs e)
        {

        }

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            var t = MessageBox.Show("Da li ste sigurni da želite obrisati podatak?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (t == DialogResult.Yes)
            {
                if (_id != null)
                {
                    await _service.Delete(_id);
                    MessageBox.Show("Uspješno ste obrisali uplatu");
                    this.Close();
                }
            }
        }


        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmIzmjenaUplata frm = new frmIzmjenaUplata(_id);
            frm.Show();
        }

        private void frmDetaljiUplata_Shown(object sender, EventArgs e)
        {
        }

        private void pictureBoxUplata_DoubleClick(object sender, EventArgs e)
        {
            var pic = pictureBoxUplata.Image;

            frmUplantnica frm = new frmUplantnica(pic);
            frm.Show();
        }

        private void pictureBoxUplata_DoubleClick_1(object sender, EventArgs e)
        {
            var pic = pictureBoxUplata.Image;

            frmUplantnica frm = new frmUplantnica(pic);
            frm.Show();
        }
    }
}
