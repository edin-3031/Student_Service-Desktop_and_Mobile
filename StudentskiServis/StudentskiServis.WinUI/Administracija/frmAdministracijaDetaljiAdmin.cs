using Microsoft.EntityFrameworkCore.Storage;
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
using StudentskiServis.Models;
using System.Globalization;

namespace StudentskiServis.WinUI.Administracija
{
    public partial class frmAdministracijaDetaljiAdmin : Form
    {
        private int? _id = null;
        private readonly APIService _service = new APIService("Administracija");
        private readonly APIService _service_uplata = new APIService("Uplata");

        public frmAdministracijaDetaljiAdmin(int? id=null)
        {
            InitializeComponent();

            _id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdministracijaIzmjenaAdmin frm = new frmAdministracijaIzmjenaAdmin(_id);
            frm.Show();
        }

        private async void frmAdministracijaDetaljiAdmin_Load(object sender, EventArgs e)
        {
            if (_id.HasValue == true)
            {
                var admin = await _service.GetById<Models.AdministracijaAdmin>(_id);

                textAdresa.Text = admin.Adresa;
                textIme.Text = admin.Ime;
                textKancelarija.Text = admin.Kancelarija;
                datRodjenje.Text = admin.DatumRodjenja.ToString();
                datPosao.Text = admin.DatumZaposlenja.ToString();
                textMail.Text = admin.Mail;
                textPrezime.Text = admin.Prezime;
                textStaz.Text = admin.Staz.ToString();
                textUgovor.Text = admin.VrstaUgovora;
                textSpol.Text = admin.Spol;
                txtUsernameAdmin.Text = admin.KorisnickoIme;
                Image x = (Bitmap)((new ImageConverter()).ConvertFrom(admin.Slika));
                if (x != null)
                {
                    pictureSlika.Image = x;
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            const string message ="Da li ste sigurni da želite obrisati odabrani podatak?";
            const string caption = "Zatvaranje forme";
            var result = MessageBox.Show(message,caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool postoji = false;
                List<Models.uplate> uplate = await _service_uplata.Get<List<Models.uplate>>(null);

                foreach(var x in uplate)
                {
                    if ((int)x.AdministracijaId == _id)
                    {
                        postoji = true;
                    }
                }
                if (postoji)
                    MessageBox.Show("Morate prvo uklonuti odabranu administraciju sa svih uplata koje je evidentirao","Upozorenje",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                else
                {
                    await _service.Delete(_id);
                    MessageBox.Show("Uspješno ste izvršili brisanje");
                    this.Close();
                }
            }
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            //var admin = await _service.GetById<Models.AdministracijaAdmin>(_id);

            //var result = PictureEditDialog.ShowDialog();

            //if (result == DialogResult.OK)
            //{
            //    var fileName = PictureEditDialog.FileName;

            //    var file = File.ReadAllBytes(fileName);

            //    admin.Slika = file;

            //    //Da se prikaže slika u picture box
            //    Image image = Image.FromFile(fileName);
            //    pictureSlika.Image = image;

            //    await _service.Update<Models.AdministracijaAdmin>(_id,admin);


            //    MessageBox.Show("Uspješno ste izvršili izmjenu slike");

            //}
        }

        private void pictureSlika_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }

}
