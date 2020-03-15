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
    public partial class frmProfesorDetalji : Form
    {
        int? _id = null;
        private readonly APIService service = new APIService("Profesor");
        private readonly APIService service_predaje = new APIService("Predavanja");
        private readonly APIService service_ispit = new APIService("Ispit");
        public frmProfesorDetalji(int? id=null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmProfesorDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue == true)
            {
                var prof = await service.GetById<ProfesorAdmin>(_id);

                txtProfAdresa.Text = prof.Adresa;
                txtProfIme.Text = prof.Ime;
                txtProfKancelarija.Text = prof.Kancelarija;
                txtProfMail.Text = prof.Mail;
                txtProfPrezime.Text = prof.Prezime;
                txtProfSpol.Text = prof.Spol;
                txtProfStaz.Text = prof.Staz.ToString();
                txtProfUgovor.Text = prof.VrstaUgovora;
                txtProfZvanje.Text = prof.Zvanje;
                datProfPosao.Text = prof.DatumZaposlenja.ToString();
                datProfRodjenje.Text = prof.DatumRodjenja.ToString();
                txtUsername.Text = prof.KorisnickoIme;
                Image image = (Bitmap)((new ImageConverter()).ConvertFrom(prof.Slika));
                pictureProfSlika.Image = image;

            }
        }

        private async void buttonBrisi_Click(object sender, EventArgs e)
        {
            const string message = "Da li ste sigurni da želite obrisati odabrani podatak?";
            const string caption = "Zatvaranje forme";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            bool postojiIspit = false;
            bool postojiPredaje = false;

            var listaIspita = await service_ispit.Get<List<Models.ispiti>>(null);
            var listaPredavanja = await service_predaje.Get<List<Models.predavanja>>(null);

            foreach(var x in listaIspita)
            {
                if (x.ProfesorId == _id)
                    postojiIspit = true;
            }

            foreach(var y in listaPredavanja)
            {
                if (y.ProfesorId == _id)
                    postojiPredaje = true;
            }

            if (postojiIspit==true)
                MessageBox.Show("Prvo morate izmijeniti ispite koje je odabrani profesor evidentirao","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            if (postojiPredaje == true)
                MessageBox.Show("Prvo morate izmijeniti predavanja koja su za odabranog profesora evidentirana", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (postojiIspit == true && postojiPredaje == true)
                MessageBox.Show("Prvo morate izmijeniti predavanja i ispite koja su za odabranog profesora evidentirana", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes && _id.HasValue == true && postojiPredaje==false && postojiIspit==false) {
                await service.Delete(_id);
                MessageBox.Show("Uspješno ste obrisali podatak");
                this.Close();
            }
        }

        private async void btnIzmjenaSlike_Click(object sender, EventArgs e)
        {
            //var prof = await service.GetById<Models.ProfesorAdmin>(_id);

            //var result = profFileDialog.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    var fileName = profFileDialog.FileName;

            //    var file = File.ReadAllBytes(fileName);

            //    prof.Slika = file;

            //    //Da se prikaže slika u picture box
            //    Image image = Image.FromFile(fileName);
            //    pictureProfSlika.Image = image;

            //    await service.Update<Models.AdministracijaAdmin>(_id, prof);


            //    MessageBox.Show("Uspješno ste izvršili izmjenu slike");

            //}
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            ProfesorIzmjenaAdmin frm = new ProfesorIzmjenaAdmin(_id);
            frm.Show();
        }
    }
}
