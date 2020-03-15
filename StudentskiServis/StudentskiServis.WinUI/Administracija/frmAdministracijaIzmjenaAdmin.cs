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
    public partial class frmAdministracijaIzmjenaAdmin : Form
    {
        private readonly int? _id = null;
        APIService _service = new APIService("Administracija");
        public frmAdministracijaIzmjenaAdmin(int? id = null)
        {
            InitializeComponent();
            if (id.HasValue == true)
            {
                _id = id;
            }
        }

        private async void frmAdministracijaIzmjenaAdmin_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.AdministracijaAdmin>(_id);

            textLastName.Text = temp.Prezime;
            textFirstName.Text = temp.Ime;
            textEMail.Text = temp.Mail;
            textOffice.Text = temp.Kancelarija;
            textContract.Text = temp.VrstaUgovora;
            datBirth.Value = temp.DatumRodjenja.Value;
            datHire.Value = temp.DatumZaposlenja.Value;
            textAddress.Text = temp.Adresa;
            if (temp.Spol == "M")
                radioM.Checked = true;
            if(temp.Spol=="Ž")
                radioZ.Checked = true;
            textWorking.Text = temp.Staz.ToString();
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(temp.Slika));
            if (x != null)
            {
                editSlika.Image = x;
            }

        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var temp = new Models.AdministracijaAdmin
            {
                Adresa = textAddress.Text,
                DatumRodjenja = datBirth.Value,
                DatumZaposlenja = datHire.Value,
                Ime = textFirstName.Text,
                Prezime = textLastName.Text,
                Kancelarija = textOffice.Text,
                Mail = textEMail.Text,
                Staz = int.Parse(textWorking.Text),
                VrstaUgovora = textContract.Text
            };
            if (radioM.Checked == true)
                temp.Spol = "M";
            if (radioZ.Checked == true)
                temp.Spol = "Ž";

            temp.Slika = imageToByteArray(editSlika.Image);

            var posotjeci = await _service.GetById<Models.AdministracijaAdmin>(_id);

            temp.LozinkaHash = posotjeci.LozinkaHash;
            temp.LozinkaSalt = posotjeci.LozinkaSalt;
            temp.KorisnickoIme = posotjeci.KorisnickoIme;

            await _service.Update<Models.AdministracijaAdmin>(_id, temp);

            MessageBox.Show("Uspješno ste izvršili izmjene");
            this.Close();
        }

        private async void btnIzmjenaSlike_Click(object sender, EventArgs e)
        {
            var admin = await _service.GetById<Models.AdministracijaAdmin>(_id);

            var result = izmjenaSlike.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = izmjenaSlike.FileName;

                var file = File.ReadAllBytes(fileName);

                admin.Slika = file;

                //Da se prikaže slika u picture box
                Image image = Image.FromFile(fileName);
                editSlika.Image = image;

                await _service.Update<Models.AdministracijaAdmin>(_id, admin);

                MessageBox.Show("Uspješno ste izvršili izmjenu slike");

            }
        }

        private void editSlika_Click(object sender, EventArgs e)
        {

        }

        private void textLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textLastName.Text) == true)
            {
                error.SetError(textLastName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(textLastName, null);
            }
        }

        private void textFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textFirstName.Text) == true)
            {
                error.SetError(textFirstName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(textFirstName, null);
            }
        }

        private void textEMail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEMail.Text) == true)
            {
                error.SetError(textEMail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(textEMail, null);
            }
        }

        private void textContract_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textContract.Text) == true)
            {
                error.SetError(textContract, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(textContract, null);
            }
        }

        private void textWorking_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textWorking.Text) == true)
            {
                error.SetError(textWorking, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(textWorking, null);
            }
        }

        private void textOffice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textOffice.Text) == true)
            {
                error.SetError(textOffice, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(textOffice, null);
            }
        }

        private void textAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textAddress.Text) == true)
            {
                error.SetError(textAddress, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(textAddress, null);
            }
        }

        private void radioZ_Validating(object sender, CancelEventArgs e)
        {
            if (radioZ.Checked==false && radioM.Checked == false)
            {
                error.SetError(radioZ, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(radioZ, null);
            }
        }
    }
}
