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
    public partial class frmMojiPodaci : Form
    {
        int id;
        private readonly APIService _service = new APIService("Student");
        private readonly APIService _service_pohadjanja = new APIService("Pohadjanja");

        public frmMojiPodaci(int _id)
        {
            InitializeComponent();

            id = _id;
        }

        private async void frmMojiPodaci_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.StudentAdmin>(id);

            txtPrezime.Text = temp.Prezime;
            txtIme.Text = temp.Ime;
            txtIndeks.Text = temp.Indeks;
            txtUsername.Text = temp.KorisnickoIme;
            txtRodjenje.Text = temp.DatumRodjenja.ToString();
            txtUpis.Text = temp.DatumUpisa.ToString();
            txtMail.Text = temp.Mail;
            txtAdresa.Text = temp.Adresa;
            txtTelefon.Text = temp.Telefon;
            txtSpol.Text = temp.Spol;
            txtStatus.Text = temp.Status;
            txtNS.Text = temp.NacinStudiranja;
            txtUpisanS.Text = temp.UpisanSemestar.ToString();
            txtOvjerenS.Text = temp.OvjerenSemestar.ToString();
            txtObnavlja.Text = temp.ObnavljaGodinu;
            pictureBoxStud.Image = (Bitmap)(new ImageConverter().ConvertFrom(temp.Slika));

            var tmp = await _service_pohadjanja.Get<List<Models.pohadjanja>>(null);

            float brojac = 0;
            List<Models.pohadja> pohadjanja = new List<Models.pohadja>();

            foreach (var x in tmp)
            {
                if (x.StudentId == id)
                {
                    pohadjanja.Add(new Models.pohadja
                    {
                        Aktivan = x.Aktivan,
                        BrojObnavljanja = x.BrojObnavljanja,
                        StudentId = x.StudentId,
                        KursId = x.KursId,
                        Obnavlja = x.Obnavlja,
                        Ocjena = x.Ocjena,
                        PohadjaId = x.PohadjaId,
                        Polozio = x.Polozio
                    });
                }
            }

            float suma = 0;

            foreach (var y in pohadjanja)
            {
                if (y.Polozio == "Da")
                {
                    brojac++;
                    suma += (float)y.Ocjena;
                }
            }

            var prosjek = suma / brojac;

            txtOcjena.Text = prosjek.ToString();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmMojiPodaciIzmjena frm = new frmMojiPodaciIzmjena(id);
            frm.Show();
        }
    }
}
