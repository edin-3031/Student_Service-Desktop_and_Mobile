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
    public partial class frmIzmjenaStudenta : Form
    {
        private readonly APIService _service = new APIService("Student");
        int? _id = null;
        public frmIzmjenaStudenta(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmIzmjenaStudenta_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.StudentAdmin>(_id);

            txtIme.Text = temp.Ime;
            txtPrezime.Text = temp.Prezime;
            txtIndeks.Text = temp.Indeks;
            txtMail.Text = temp.Mail;
            txtAdresa.Text = temp.Adresa;
            txtTelefon.Text = temp.Telefon;
            if (temp.Spol == "M" || temp.Spol == "m")
                rbtnM.Checked = true;
            else if (temp.Spol == "Ž" || temp.Spol == "ž" || temp.Spol == "Z" || temp.Spol == "z")
                rbtnZ.Checked = true;
            txtStatus.Text = temp.Status;
            dateRodjenje.Value = temp.DatumRodjenja.Value;
            dateUpis.Value = temp.DatumUpisa.Value;
            if (temp.NacinStudiranja == "IN-CLASS")
                rbtnIC.Checked = true;
            else if (temp.NacinStudiranja == "DL")
                rbtnDL.Checked = true;
            else if (temp.NacinStudiranja == "Vanredno")
                rbtnV.Checked = true;
            if (temp.ObnavljaGodinu == "Da" || temp.ObnavljaGodinu == "da" || temp.ObnavljaGodinu == "DA")
                rbtnDA.Checked = true;
            else if (temp.ObnavljaGodinu == "Ne" || temp.ObnavljaGodinu == "ne" || temp.ObnavljaGodinu == "NE")
                rbtnNE.Checked = true;
            txtUpisanS.Text = temp.UpisanSemestar.ToString();
            txtOvjerenS.Text = temp.OvjerenSemestar.ToString();
            txtOcjena.Text = temp.ProsjecnaOcjena.ToString();
            editSlika.Image = (Bitmap)(new ImageConverter().ConvertFrom(temp.Slika));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rbtnDA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void btnIzmjenaSlike_Click(object sender, EventArgs e)
        {
            var student = await _service.GetById<Models.StudentAdmin>(_id);

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;

                var file = File.ReadAllBytes(fileName);

                student.Slika = file;

                //Da se prikaže slika u picture box
                Image image = Image.FromFile(fileName);
                editSlika.Image = image;

                await _service.Update<Models.AdministracijaAdmin>(_id, student);
                MessageBox.Show("Uspješno ste izmjenili sliku");

            }


        }

        private async void btnSaveEdit_Click(object sender, EventArgs e)
        {
            var postojeci = await _service.GetById<Models.StudentAdmin>(_id);

            Models.StudentAdmin temp = new Models.StudentAdmin
            {
                Adresa = txtAdresa.Text,
                DatumRodjenja = dateRodjenje.Value,
                DatumUpisa = dateUpis.Value,
                Ime = txtIme.Text,
                Indeks = txtIndeks.Text,
                KorisnickoIme = postojeci.KorisnickoIme,
                LozinkaHash = postojeci.LozinkaHash,
                LozinkaSalt = postojeci.LozinkaSalt,
                Mail = txtMail.Text,
                OvjerenSemestar = int.Parse(txtOvjerenS.Text),
                Prezime = txtPrezime.Text,
                ProsjecnaOcjena = float.Parse(txtOcjena.Text),
                Slika = postojeci.Slika,
                Status = txtStatus.Text,
                Telefon = txtTelefon.Text,
                UpisanSemestar = int.Parse(txtUpisanS.Text)
            };
            if (rbtnM.Checked)
                temp.Spol = "M";
            else if (rbtnZ.Checked)
                temp.Spol = "Ž";

            if (rbtnIC.Checked)
                temp.NacinStudiranja = "IN-CLASS";
            else if (rbtnDL.Checked)
                temp.NacinStudiranja = "DL";
            else if (rbtnV.Checked)
                temp.NacinStudiranja = "Vanredno";

            if (rbtnDA.Checked)
                temp.ObnavljaGodinu = "Da";
            else if (rbtnNE.Checked)
                temp.ObnavljaGodinu = "Ne";

            await _service.Update<Models.StudentAdmin>(_id, temp);
            MessageBox.Show("Uspješno ste izvršili izmjene");
            this.Close();
        }
    }
}
