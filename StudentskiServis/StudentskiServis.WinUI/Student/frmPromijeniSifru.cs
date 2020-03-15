using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Student
{
    public partial class frmPromijeniSifru : Form
    {
        private readonly APIService _service = new APIService("Student");
        int id;
        public frmPromijeniSifru(int _id)
        {
            InitializeComponent();
            id = _id;
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren()) { 
            var stud = await _service.GetById<Models.StudentAdmin>(id);

                if (txtNovaSifra.Text != txtPotvrda.Text)
                {
                    MessageBox.Show("Unesene šifre se ne podudaraju", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNovaSifra.Text == txtPotvrda.Text)
                {
                    var result = await _service.GetById<Models.StudentAdmin>(id);
                    var temp = GenerateHash(result.LozinkaSalt, txtSifra.Text);
                    if (result.LozinkaHash != temp)
                    {
                        MessageBox.Show("Niste unijeli ispravnu šifru", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (result.LozinkaHash == temp)
                    {
                        if (txtNovaSifra.Text == txtPotvrda.Text)
                        {
                            var noviSalt = GenerateSalt();
                            var noviHash = GenerateHash(noviSalt, txtNovaSifra.Text);

                            result.LozinkaSalt = noviSalt;
                            result.LozinkaHash = noviHash;

                            await _service.Update<Models.StudentAdmin>(id, result);
                            MessageBox.Show("Uspješno ste izmijenili lozinku");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void txtSifra_Validating(object sender, CancelEventArgs e)
        {
            if (txtSifra.Text == "") {
                errPassword.SetError(txtSifra, "Morate popuniti polje");
                e.Cancel=true;
            }
            else
                errPassword.SetError(txtSifra, null);
        }

        private void txtNovaSifra_Validating(object sender, CancelEventArgs e)
        {
            if (txtNovaSifra.Text == "")
            {
                errPassword.SetError(txtNovaSifra, "Morate popuniti polje");
                e.Cancel = true;
            }
            else
                errPassword.SetError(txtNovaSifra, null);
        }

        private void txtPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (txtPotvrda.Text == "")
            {
                errPassword.SetError(txtPotvrda, "Morate popuniti polje");
                e.Cancel = true;
            }
            else
                errPassword.SetError(txtPotvrda, null);
        }
    }
}
