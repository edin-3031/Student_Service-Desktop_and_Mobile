using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Raspored
{
    public partial class frmMojRasporedDodaj : Form
    {
        private readonly APIService _service = new APIService("Raspored");

        int studentId;
        public frmMojRasporedDodaj(int id)
        {
            InitializeComponent();
            studentId = id;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Models.Raspored temp = new Models.Raspored
            {
                Datum = dateDatum.Value,
                Naslov = txtNaslov.Text,
                Opis = rtbOpis.Text,
                StudentId = studentId
            };

            if (cbVazno.Checked == true)
                temp.Vazno = "Da";

            else if (cbVazno.Checked == false)
                temp.Vazno = "Ne";

            await _service.Insert(temp);

            MessageBox.Show("Uspješno ste dodali novi podatak");
            this.Close();
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text))
            {
                errorRaspored.SetError(txtNaslov, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorRaspored.SetError(txtNaslov, null);
            }
        }
    }
}
