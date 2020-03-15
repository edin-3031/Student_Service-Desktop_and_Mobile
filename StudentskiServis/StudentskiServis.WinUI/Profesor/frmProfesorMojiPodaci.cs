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
    public partial class frmProfesorMojiPodaci : Form
    {
        int id;
        private readonly APIService _service = new APIService("Profesor");
        public frmProfesorMojiPodaci(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmProfesorMojiPodaci_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.ProfesorAdmin>(id);

            txtPrezime.Text = temp.Prezime;
            txtIme.Text = temp.Ime;
            txtZvanje.Text = temp.Zvanje;
            txtMail.Text = temp.Mail;
            txtKancelarija.Text = temp.Kancelarija;
            txtUgovor.Text = temp.VrstaUgovora;
            datPosao.Text = temp.DatumZaposlenja.ToString();
            datRodjenje.Text = temp.DatumRodjenja.ToString();
            txtUsername.Text = temp.KorisnickoIme;
            txtAdresa.Text = temp.Adresa;
            txtSpol.Text = temp.Spol;
            txtStaz.Text = temp.Staz.ToString();
            pictureProfSlika.Image = (Bitmap)(new ImageConverter().ConvertFrom(temp.Slika));
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmProfesorMojiPodaciIzmjena frm = new frmProfesorMojiPodaciIzmjena(id);
            frm.Show();
        }
    }
}
