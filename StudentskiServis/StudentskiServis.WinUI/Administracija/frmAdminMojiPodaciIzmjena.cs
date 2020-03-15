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

namespace StudentskiServis.WinUI.Administracija
{
    public partial class frmAdminMojiPodaciIzmjena : Form
    {
        int id;
        private readonly APIService _service = new APIService("Administracija");
        public frmAdminMojiPodaciIzmjena(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmAdminMojiPodaciIzmjena_Load(object sender, EventArgs e)
        {
            var result = await _service.GetById<Models.AdministracijaAdmin>(id);

            textLastName.Text = result.Prezime;
            textFirstName.Text = result.Ime;
            textEMail.Text = result.Mail;
            textAddress.Text = result.Adresa;
            editSlika.Image = (Bitmap)(new ImageConverter().ConvertFrom(result.Slika));
        }

        private async void btnIzmjenaSlike_Click(object sender, EventArgs e)
        {
            var admin = await _service.GetById<Models.AdministracijaAdmin>(id);

            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                admin.Slika = file;

                //Da se prikaže slika u picture box
                Image image = Image.FromFile(fileName);
                editSlika.Image = image;
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private async void btnSaveEdit_Click(object sender, EventArgs e)
        {
            var result = await _service.GetById<Models.AdministracijaAdmin>(id);

            result.Prezime = textLastName.Text;
            result.Ime = textFirstName.Text;
            result.Mail = textEMail.Text;
            result.Adresa = textAddress.Text;
            result.Slika = imageToByteArray(editSlika.Image);

            await _service.Update<Models.AdministracijaAdmin>(id, result);
            MessageBox.Show("Uspješno ste izmijenili svoje podatke");
            this.Close();
        }

        private void btnPassEdit_Click(object sender, EventArgs e)
        {
            frmPromjenaŠifre frm = new frmPromjenaŠifre(id);
            frm.Show();
        }

        private void textLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textLastName.Text) == true)
            {
                greska.SetError(textLastName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                greska.SetError(textLastName, null);
            }
        }

        private void textFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textFirstName.Text) == true)
            {
                greska.SetError(textFirstName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                greska.SetError(textFirstName, null);
            }
        }

        private void textEMail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEMail.Text) == true)
            {
                greska.SetError(textEMail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                greska.SetError(textEMail, null);
            }
        }

        private void textAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textAddress.Text) == true)
            {
                greska.SetError(textAddress, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                greska.SetError(textAddress, null);
            }
        }
    }
}
