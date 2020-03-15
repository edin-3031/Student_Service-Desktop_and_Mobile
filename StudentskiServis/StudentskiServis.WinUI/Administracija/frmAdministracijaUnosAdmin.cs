using Microsoft.AspNet.SignalR.Infrastructure;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Administracija
{
    public partial class frmAdministracijaUnosAdmin : Form
    {
        private int? _id = null;
        APIService _service = new APIService("Administracija");

        public frmAdministracijaUnosAdmin(int? administracijaId=null)
        {
            InitializeComponent();
            _id = administracijaId;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                return  Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
            return null;
        }
        private async void frmAdministracijaDetaljiAdmin_Load(object sender, EventArgs e)
        {

            //if (_id.HasValue)
            //{
            //    var admin = await _service.GetById<Models.AdministracijaAdmin>(_id);

            //    txtAdresa.Text = admin.Adresa;
            //    txtIme.Text = admin.Ime;
            //    txtKancelarija.Text = admin.Kancelarija;
            //    dateRodjenje.Text = admin.DatumRodjenja.ToString();
            //    dateZaposlenje.Text = admin.DatumZaposlenja.ToString();
            //    txtMail.Text = admin.Mail;
            //    txtPassword.Text = admin.LozinkaHash;
            //    txtPasswordConfirmation.Text = admin.LozinkaSalt;
            //    txtPrezime.Text = admin.Prezime;
            //    txtStaz.Text = admin.Staz.ToString();
            //    txtUgovor.Text = admin.VrstaUgovora;
            //    txtUsername.Text = admin.KorisnickoIme;
            //    Image x = (Bitmap)((new ImageConverter()).ConvertFrom(admin.Slika));
            //    if (x != null)
            //    {
            //        picSlika.Image = x;
            //    }
            //}
        }

        Models.Requests.AdministracijaInsertRequest request = new Models.Requests.AdministracijaInsertRequest();

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (txtPassword.Text != txtPasswordConfirmation.Text)
                    MessageBox.Show("Unesene šifre nisu jednake", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                bool t = await _service.Check_Username(txtUsername.Text);

                if (t == true)
                {
                    MessageBox.Show("Uneseno korisničko ime već postoji.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (t == false)
                {
                    if (txtPassword.Text == txtPasswordConfirmation.Text)
                    {
                        Models.AdministracijaAdmin novi = new Models.AdministracijaAdmin();
                        novi.Adresa = txtAdresa.Text;
                        novi.DatumRodjenja = dateRodjenje.Value;
                        novi.DatumZaposlenja = dateZaposlenje.Value;
                        novi.Ime = txtIme.Text;
                        novi.Kancelarija = txtKancelarija.Text;
                        novi.KorisnickoIme = txtUsername.Text;
                        novi.Mail = txtMail.Text;
                        novi.LozinkaHash = txtPassword.Text;
                        novi.LozinkaSalt = txtPasswordConfirmation.Text;
                        novi.Prezime = txtPrezime.Text;

                        if (rbtnMusko.Checked = true)
                        {
                            novi.Spol = "M";
                        }
                        else if (rbtnZensko.Checked = true)
                        {
                            novi.Spol = "Ž";
                        }
                        else
                        {
                            novi.Spol = "-";

                        }
                        novi.Staz = int.Parse(txtStaz.Text);
                        novi.VrstaUgovora = txtUgovor.Text;

                        novi.Slika = imageToByteArray(picSlika.Image);

                        await _service.Insert(novi);

                        MessageBox.Show("Operacija upsješna");
                        this.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);

                picSlika.Image = image;

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text) == true)
            {
                err.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtPrezime, null);
            }
        }
    private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                err.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                err.SetError(txtIme, null);
            }
        }

        private void picSlika_Click(object sender, EventArgs e)
        {

        }

        //private void txtPrezime_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtPrezime.Text))
        //    {
        //        errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        errorProvider.SetError(txtPrezime, null);
        //    }
        //}

        private void txtMail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                err.SetError(txtMail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(txtMail, null);
            }
        }

        private void txtKancelarija_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKancelarija.Text))
            {
                err.SetError(txtKancelarija, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(txtKancelarija, null);
            }
        }

        private void txtUgovor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUgovor.Text))
            {
                err.SetError(txtUgovor, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(txtUgovor, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                err.SetError(txtUsername, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                err.SetError(txtPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(txtPassword, null);
            }
        }

        private void txtPasswordConfirmation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordConfirmation.Text))
            {
                err.SetError(txtPasswordConfirmation, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(txtPasswordConfirmation, null);
            }
        }

        private void dateRodjenje_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateRodjenje.Text))
            {
                err.SetError(dateRodjenje, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(dateRodjenje, null);
            }
        }

        private void dateZaposlenje_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateZaposlenje.Text))
            {
                err.SetError(dateZaposlenje, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(dateZaposlenje, null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                err.SetError(txtAdresa, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(txtAdresa, null);
            }
        }

        private void txtSpol_Validating(object sender, CancelEventArgs e)
        {
            if (rbtnMusko.Checked==false && rbtnZensko.Checked==false)
            {
                err.SetError(rbtnMusko, Properties.Resources.Validation_RequiredField);
                err.SetError(rbtnZensko, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(rbtnMusko, null);
                err.SetError(rbtnZensko, null);
            }
        }

        private void txtStaz_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaz.Text))
            {
                err.SetError(txtStaz, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(txtStaz, null);
            }
        }

        private void txtSlika_TextChanged(object sender, EventArgs e)
        {

        }

        private async void picSlika_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSlika.Text))
            {
                err.SetError(txtSlika, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(txtSlika, null);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var t = MessageBox.Show("Da li ste sigurni da želite obrisati unesene podatke?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (t==DialogResult.Yes)
            {
                txtAdresa.Text = "";
                txtIme.Text = "";
                txtKancelarija.Text = "";
                dateRodjenje.Text = "";
                dateZaposlenje.Text = "";
                txtMail.Text = "";
                txtPassword.Text = "";
                txtPasswordConfirmation.Text = "";
                txtPrezime.Text = "";
                if (rbtnZensko.Checked == true)
                    rbtnZensko.Checked = false;
                if (rbtnMusko.Checked == true)
                    rbtnMusko.Checked = false;
                txtStaz.Text = "";
                txtUgovor.Text = "";
                txtUsername.Text = "";
                txtSlika.Text = "";
                picSlika.Image = null;
                MessageBox.Show("Uspješno ste izvršili brisanje unesenih podataka");
            }
        }

        private void rbtnZensko_Validating(object sender, CancelEventArgs e)
        {
            if (rbtnMusko.Checked==false && rbtnZensko.Checked == false)
            {
                err.SetError(rbtnZensko, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                err.SetError(rbtnZensko, null);
            }
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateRodjenje_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
