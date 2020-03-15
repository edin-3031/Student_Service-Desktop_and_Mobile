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
    public partial class frmMojaUplataDetalji : Form
    {
        private readonly APIService _servie = new APIService("Uplata");
        int id;
        public frmMojaUplataDetalji(int _id)
        {
            InitializeComponent();

            id = _id;
        }

        private async void frmMojaUplataDetalji_Load(object sender, EventArgs e)
        {
            var temp = await _servie.GetById<Models.uplate>(id);

            txtSvrha.Text = temp.Svrha;
            txtIznos.Text = temp.Iznos.ToString();
            txtDatUplate.Text = temp.DatumUplate.ToString();
            txtEvidentirao.Text = temp.Evidentirao;

            if (temp.Ovjereno == "Da" || temp.Ovjereno == "DA" || temp.Ovjereno == "da")
                cbOvjereno.Checked = true;
            else if (temp.Ovjereno == "Ne" || temp.Ovjereno == "NE" || temp.Ovjereno == "ne")
                cbOvjereno.Checked = false;

            if (temp.Slika == null)
                pictureBoxUplata.Image =Properties.Resources.No_Picture;
            else if (temp.Slika != null)
                pictureBoxUplata.Image = (Bitmap)(new ImageConverter().ConvertFrom(temp.Slika));
        }
    }
}
