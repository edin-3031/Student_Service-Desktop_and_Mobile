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
    public partial class frmDetaljiStudenta : Form
    {
        int? _id = null;
        private readonly APIService _service = new APIService("Student");
        private readonly APIService _service_pohadjanja = new APIService("Pohadjanja");

        public frmDetaljiStudenta(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmDetaljiStudenta_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var temp=await _service.GetById<Models.StudentAdmin>(_id);

                txtPrezime.Text = temp.Prezime;
                txtIme.Text = temp.Ime;
                txtIndeks.Text = temp.Indeks;
                txtUsername.Text = temp.KorisnickoIme;
                txtRodjenje.Text = temp.DatumRodjenja.ToString();
                txtUpis.Text = temp.DatumUpisa.ToString();
                txtMail.Text = temp.Mail;
                txtTelefon.Text = temp.Telefon;
                txtSpol.Text = temp.Spol;
                txtStatus.Text = temp.Status;
                txtNS.Text = temp.NacinStudiranja;
                txtUpisanS.Text = temp.UpisanSemestar.ToString();
                txtOvjerenS.Text = temp.OvjerenSemestar.ToString();
                txtObnavlja.Text = temp.ObnavljaGodinu;
                txtAdresa.Text = temp.Adresa;
                pictureBoxStud.Image = (Bitmap)((new ImageConverter().ConvertFrom(temp.Slika)));

                var tmp = await _service_pohadjanja.Get<List<Models.pohadjanja>>(null);

                float brojac=0;
                List<Models.pohadja> pohadjanja = new List<Models.pohadja>();

                foreach (var x in tmp)
                {
                    if (x.StudentId == _id)
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

                float suma=0;

                foreach(var y in pohadjanja)
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void buttonBrisi_Click(object sender, EventArgs e)
        {
            var t = MessageBox.Show("Da li ste digurni da želite obrisati zapis?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (t == DialogResult.Yes)
            {
                if (_id.HasValue)
                {
                    await _service.Delete(_id);
                    this.Close();
                }
            }
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmIzmjenaStudenta frm = new frmIzmjenaStudenta(_id);
            frm.Show();
        }
    }
}
