using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Profesor
{
    public partial class ProfesorIzmjenaAdmin : Form
    {
        int? _id = null;
        APIService _service = new APIService("Profesor");

        public ProfesorIzmjenaAdmin(int? id=null)
        {
            InitializeComponent();

            _id = id;
        }

        private async void ProfesorIzmjenaAdmin_Load(object sender, EventArgs e)
        {
            if (_id.HasValue == true)
            {
                var prof = await _service.GetById<ProfesorAdmin>(_id);

                txtProfAdresa.Text = prof.Adresa;
                txtProfIme.Text = prof.Ime;
                txtProfKancelarija.Text = prof.Kancelarija;
                txtProfMail.Text = prof.Mail;
                txtProfPrezime.Text = prof.Prezime;
                txtProfStaz.Text = prof.Staz.ToString();
                txtProfUgovor.Text = prof.VrstaUgovora;
                txtProfZvanje.Text = prof.Zvanje;
                datPickProfPosao.Value = prof.DatumZaposlenja.Value;
                datPickProfRodjenje.Value = prof.DatumRodjenja.Value;
                if (prof.Spol == "M")
                    rProfM.Checked = true;
                else if (prof.Spol == "Ž")
                    rProfZ.Checked = true;
                pictureProfSlika.Image= (Bitmap)((new ImageConverter()).ConvertFrom(prof.Slika));
            }
        }

        private async void btnIzmjenaSlike_Click(object sender, EventArgs e)
        {
            var prof = await _service.GetById<Models.ProfesorAdmin>(_id);

            var result = profFileDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = profFileDialog2.FileName;

                var file = File.ReadAllBytes(fileName);

                prof.Slika = file;

                //Da se prikaže slika u picture box
                Image image = Image.FromFile(fileName);
                pictureProfSlika.Image = image;

                await _service.Update<Models.AdministracijaAdmin>(_id, prof);

            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private async void btnProfSačuvaj_Click(object sender, EventArgs e)
        {

            ProfesorAdmin temp = new ProfesorAdmin
            {
                Adresa = txtProfAdresa.Text,
                DatumRodjenja = datPickProfRodjenje.Value,
                DatumZaposlenja = datPickProfPosao.Value,
                Ime = txtProfIme.Text,
                Kancelarija = txtProfKancelarija.Text,
                Mail = txtProfMail.Text,
                Prezime = txtProfPrezime.Text,
                Slika = imageToByteArray(pictureProfSlika.Image),
                Staz = int.Parse(txtProfStaz.Text),
                VrstaUgovora = txtProfUgovor.Text,
                Zvanje = txtProfZvanje.Text
            };
            if (rProfM.Checked == true)
                temp.Spol = "M";
            if (rProfZ.Checked == true)
                temp.Spol = "Ž";

            var postojeci = await _service.GetById<ProfesorAdmin>(_id);
            temp.LozinkaHash = postojeci.LozinkaHash;
            temp.LozinkaSalt = postojeci.LozinkaSalt;

            await _service.Update<ProfesorAdmin>(_id, temp);
            MessageBox.Show("Uspješno ste izmjenili podatke");
            this.Close();
        }
    }
}