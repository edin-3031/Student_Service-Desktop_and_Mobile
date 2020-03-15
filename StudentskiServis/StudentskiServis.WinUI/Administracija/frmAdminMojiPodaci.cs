using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Administracija
{
    public partial class frmAdminMojiPodaci : Form
    {
        private readonly APIService _service = new APIService("Administracija");
        int id;
        public frmAdminMojiPodaci(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmAdminMojiPodaci_Load(object sender, EventArgs e)
        {
            var result = await _service.GetById<Models.AdministracijaAdmin>(id);

            textPrezime.Text = result.Prezime;
            textIme.Text = result.Ime;
            textMail.Text = result.Mail;
            textKancelarija.Text = result.Kancelarija;
            textUgovor.Text = result.VrstaUgovora;
            txtUsernameAdmin.Text = result.KorisnickoIme;
            datRodjenje.Text = result.DatumRodjenja.ToString();
            datPosao.Text = result.DatumZaposlenja.ToString();
            textAdresa.Text = result.Adresa;
            textSpol.Text = result.Spol;
            textStaz.Text = result.Staz.ToString();
            pictureSlika.Image = (Bitmap)(new ImageConverter().ConvertFrom(result.Slika));
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmAdminMojiPodaciIzmjena frm = new frmAdminMojiPodaciIzmjena(id);
            frm.Show();
        }
    }
}
