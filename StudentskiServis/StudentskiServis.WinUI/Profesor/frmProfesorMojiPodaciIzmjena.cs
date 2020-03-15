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
    public partial class frmProfesorMojiPodaciIzmjena : Form
    {
        int id;
        private readonly APIService _service = new APIService("Profesor");
        public frmProfesorMojiPodaciIzmjena(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmProfesorMojiPodaciIzmjena_Load(object sender, EventArgs e)
        {
            var result = await _service.GetById<Models.ProfesorAdmin>(id);

            textLastName.Text = result.Prezime;
            textFirstName.Text = result.Ime;
            textEMail.Text = result.Mail;
            textAddress.Text = result.Adresa;
            editSlika.Image = (Bitmap)(new ImageConverter().ConvertFrom(result.Slika));
        }

        private async void btnIzmjenaSlike_Click(object sender, EventArgs e)
        {
            var prof = await _service.GetById<Models.ProfesorAdmin>(id);

            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                prof.Slika = file;

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
            var result = await _service.GetById<Models.ProfesorAdmin>(id);

            result.Prezime = textLastName.Text;
            result.Ime = textFirstName.Text;
            result.Mail = textEMail.Text;
            result.Adresa = textAddress.Text;
            result.Slika = imageToByteArray(editSlika.Image);

            await _service.Update<Models.ProfesorAdmin>(id, result);
            MessageBox.Show("Uspješno ste izmijenili svoje podatke");
            this.Close();
        }

        private void btnPassEdit_Click(object sender, EventArgs e)
        {
            frmPromjenaSifre frm = new frmPromjenaSifre(id);
            frm.Show();
        }
    }
}
