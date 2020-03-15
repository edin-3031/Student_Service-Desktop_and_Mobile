using Microsoft.AspNet.SignalR.Infrastructure;
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
    public partial class frmNoviProfesor : Form
    {
        APIService service = new APIService("Profesor");

        public frmNoviProfesor()
        {
            InitializeComponent();
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;

                var file = File.ReadAllBytes(fileName);

                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);

                pictureBox.Image = image;

            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (txtSifra.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Unesene šifre nisu iste", "Provjera šifri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                bool t = await service.Check_Username(txtUsername.Text);

                if (t == true)
                {
                    MessageBox.Show("Uneseno korisničko ime već postoji.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (t == false)
                {
                    if (txtSifra.Text == txtConfirm.Text)
                    {
                        ProfesorAdmin novi = new ProfesorAdmin()
                        {
                            Adresa = txtAdresa.Text,
                            DatumRodjenja = dateRodjenje.Value,
                            DatumZaposlenja = dateZaposlenje.Value,
                            Ime = txtIme.Text,
                            Kancelarija = txtKanelarija.Text,
                            KorisnickoIme = txtUsername.Text,
                            LozinkaHash = txtSifra.Text,
                            LozinkaSalt = txtConfirm.Text,
                            Mail = txtMail.Text,
                            Prezime = txtPrezime.Text,
                            Staz = int.Parse(txtStaz.Text),
                            VrstaUgovora = txtUgovor.Text,
                            Zvanje = txtZvanje.Text,
                        };

                        if (rbtnM.Checked == true)
                            novi.Spol = "M";
                        else if (rbtnZ.Checked == true)
                            novi.Spol = "Ž";

                        novi.Slika = imageToByteArray(pictureBox.Image);

                        await service.Insert(novi);
                        MessageBox.Show("Uspješno ste izvršili dodavanje");
                        this.Close();
                    }
                }
            }
        }
        private void btnBrisi_Click(object sender, EventArgs e)
        {
            var t = MessageBox.Show("Da li želite obrisati unesene podatke?", "Provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (t == DialogResult.Yes)
            {
                txtAdresa.Text = "";
                txtIme.Text = "";
                txtKanelarija.Text = "";
                txtUsername.Text = "";
                txtSifra.Text = "";
                txtConfirm.Text = "";
                txtMail.Text = "";
                txtPrezime.Text = "";
                txtStaz.Text = "";
                txtUgovor.Text = "";
                txtZvanje.Text = "";
                if (rbtnM.Checked == true)
                    rbtnM.Checked = false;
                else if (rbtnZ.Checked == true)
                    rbtnZ.Checked = false;
                txtSlika.Text = "";
                pictureBox.Image = null;
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text)==true)
            {
                errProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtPrezime, null);
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text)==true)
            {
                errProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtIme, null);
            }
        }

        private void txtZvanje_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtZvanje.Text))
            {
                errProvider.SetError(txtZvanje, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtZvanje, null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                errProvider.SetError(txtAdresa, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtAdresa, null);
            }
        }

        private void txtMail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                errProvider.SetError(txtMail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtMail, null);
            }
        }

        private void txtUgovor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUgovor.Text))
            {
                errProvider.SetError(txtUgovor, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtUgovor, null);
            }
        }

        private void txtStaz_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaz.Text))
            {
                errProvider.SetError(txtStaz, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtStaz, null);
            }
        }

        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSlika.Text))
            {
                errProvider.SetError(txtSlika, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtSlika, null);
            }
        }

        private void txtKanelarija_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKanelarija.Text))
            {
                errProvider.SetError(txtKanelarija, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtKanelarija, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errProvider.SetError(txtUsername, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtUsername, null);
            }
        }

        private void txtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifra.Text))
            {
                errProvider.SetError(txtSifra, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtSifra, null);
            }
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                errProvider.SetError(txtConfirm, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(txtConfirm, null);
            }
        }

        private void rbtnZ_Validating(object sender, CancelEventArgs e)
        {
            if (rbtnZ.Checked == false && rbtnM.Checked == false)
            {
                errProvider.SetError(rbtnZ, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errProvider.SetError(rbtnZ, null);
            }
        }
    }
}
