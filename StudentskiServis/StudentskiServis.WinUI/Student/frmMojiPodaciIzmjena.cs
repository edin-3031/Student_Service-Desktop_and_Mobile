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

namespace StudentskiServis.WinUI.Student
{
    public partial class frmMojiPodaciIzmjena : Form
    {
        int id;
        private readonly APIService _service = new APIService("Student");
        public frmMojiPodaciIzmjena(int _id)
        {
            InitializeComponent();

            id = _id;
        }

        private async void frmMojiPodaciIzmjena_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.StudentAdmin>(id);

            textLastName.Text = temp.Prezime;
            textFirstName.Text = temp.Ime;
            textEMail.Text = temp.Mail;
            textAddress.Text = temp.Adresa;
            txtTelefon.Text = temp.Telefon;
            editSlika.Image = (Bitmap)(new ImageConverter().ConvertFrom(temp.Slika));
        }

        private async void btnIzmjenaSlike_Click(object sender, EventArgs e)
        {
            var prof = await _service.GetById<Models.StudentAdmin>(id);

            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                prof.Slika = file;

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
            var result = await _service.GetById<Models.StudentAdmin>(id);

            result.Prezime = textLastName.Text;
            result.Ime = textFirstName.Text;
            result.Mail = textEMail.Text;
            result.Adresa = textAddress.Text;
            result.Slika = imageToByteArray(editSlika.Image);

            await _service.Update<Models.StudentAdmin>(id, result);
            MessageBox.Show("Uspješno ste izmijenili svoje podatke");
            this.Close();
        }

        private void btnPassEdit_Click(object sender, EventArgs e)
        {
            frmPromijeniSifru frm = new frmPromijeniSifru(id);
            frm.Show();
        }
    }
}
