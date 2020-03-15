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
    public partial class frmNoviStudent : Form
    {
        APIService service = new APIService("Student");

        public frmNoviStudent()
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

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtIndeks_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIndeks.Text))
            {
                errorProvider.SetError(txtIndeks, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIndeks, null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                errorProvider.SetError(txtAdresa, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAdresa, null);
            }
        }

        private void txtMail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                errorProvider.SetError(txtMail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtMail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTelefon, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUsername, null);
            }
        }

        private void txtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifra.Text))
            {
                errorProvider.SetError(txtSifra, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSifra, null);
            }
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                errorProvider.SetError(txtConfirm, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtConfirm, null);
            }
        }

        private void txtSlika_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSlika.Text))
            {
                errorProvider.SetError(txtSlika, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSlika, null);
            }
        }

        private void txtStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                errorProvider.SetError(txtStatus, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtStatus, null);
            }
        }

        private void txtUpisaniSemestar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUpisaniSemestar.Text))
            {
                errorProvider.SetError(txtUpisaniSemestar, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUpisaniSemestar, null);
            }
        }

        private void txtOvjerenSemestar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOvjerenSemestar.Text))
            {
                errorProvider.SetError(txtOvjerenSemestar, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtOvjerenSemestar, null);
            }
        }

        private void rbtnZ_Validating(object sender, CancelEventArgs e)
        {
            if(rbtnZ.Checked==false && rbtnM.Checked == false)
            {
                errorProvider.SetError(rbtnZ, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(rbtnZ, null);
            }
        }

        private void rbtnV_Validating(object sender, CancelEventArgs e)
        {
            if (rbtnV.Checked == false && rbtnIC.Checked == false && rbtnDL.Checked==false)
            {
                errorProvider.SetError(rbtnV, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(rbtnV, null);
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (txtSifra.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Unesene šifre nisu iste");
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
                        Models.StudentAdmin novi = new Models.StudentAdmin
                        {
                            Adresa = txtAdresa.Text,
                            DatumRodjenja = dateRodjenje.Value,
                            DatumUpisa = dateUpis.Value,
                            Ime = txtIme.Text,
                            Indeks = txtIndeks.Text,
                            KorisnickoIme = txtUsername.Text,
                            LozinkaHash = txtSifra.Text,
                            LozinkaSalt = txtConfirm.Text,
                            Mail = txtMail.Text,
                            OvjerenSemestar = int.Parse(txtOvjerenSemestar.Text),
                            Prezime = txtPrezime.Text,
                            Slika = imageToByteArray(pictureBox.Image),
                            Status = txtStatus.Text,
                            Telefon = txtTelefon.Text,
                            UpisanSemestar = int.Parse(txtUpisaniSemestar.Text),
                            ProsjecnaOcjena = 0
                        };

                        if (rbtnM.Checked)
                            novi.Spol = "M";
                        if (rbtnZ.Checked)
                            novi.Spol = "Ž";

                        if (rbtnIC.Checked)
                            novi.NacinStudiranja = "IN-CLASS";
                        if (rbtnDL.Checked)
                            novi.NacinStudiranja = "DL";
                        if (rbtnV.Checked)
                            novi.NacinStudiranja = "Vanredno";

                        if (cbObnavlja.Checked)
                            novi.ObnavljaGodinu = "Da";
                        if (!cbObnavlja.Checked)
                            novi.ObnavljaGodinu = "Ne";

                        await service.Insert(novi);
                        MessageBox.Show("Uspješno ste unijeli podatke");
                        this.Close();
                    }
                }
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            var t = MessageBox.Show("Da li ste sigurni da želite obrisati unesene podatke?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (t == DialogResult.Yes)
            {
                txtPrezime.Text = "";
                txtIme.Text = "";
                txtIndeks.Text = "";
                txtAdresa.Text = "";
                txtMail.Text = "";
                txtTelefon.Text = "";
                txtUsername.Text = "";
                txtSifra.Text = "";
                txtConfirm.Text = "";
                txtSlika.Text = "";
                pictureBox.Image = null;
                txtStatus.Text = "";
                txtUpisaniSemestar.Text = "";
                txtOvjerenSemestar.Text = "";
                if(rbtnM.Checked==true || rbtnZ.Checked == true)
                    rbtnM.Checked = rbtnZ.Checked = false;
                if (rbtnIC.Checked == true || rbtnDL.Checked == true || rbtnV.Checked == true)
                    rbtnIC.Checked = rbtnDL.Checked = rbtnV.Checked = false;
                if (cbObnavlja.Checked == true)
                    cbObnavlja.Checked = false;

                MessageBox.Show("Uspješno ste obrisali unesene podatke");
            }
        }
    }
}
