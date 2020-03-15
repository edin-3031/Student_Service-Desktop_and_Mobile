using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Obavijest
{
    public partial class frmDodajObavijest : Form
    {
        private readonly APIService _service = new APIService("Obavijest");
        private readonly APIService _prof_service = new APIService("PROF");

        public frmDodajObavijest()
        {
            InitializeComponent();
        }

        private async void frmDodajObavijest_Load(object sender, EventArgs e)
        {
            await LoadProf();
        }

        private async Task LoadProf()
        {
            var result = await _prof_service.Get<List<Models.PROF>>(null);
            result.Insert(0, new Models.PROF { });
            cbObjavio.DataSource = result;
            cbObjavio.DisplayMember = "Ime";
            cbObjavio.ValueMember = "ProfesorId";
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (cbObjavio.SelectedValue == null)
            {
                errObavijest.SetError(cbObjavio, Properties.Resources.Validation_RequiredField); 
            }
            else {
                errObavijest.SetError(cbObjavio, null);
            }

            if (txtNaslov.Text == "")
            {
                errObavijest.SetError(txtNaslov, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errObavijest.SetError(txtNaslov, null);
            }

            if (cbObjavio.SelectedValue != null && txtNaslov.Text != "")
            {

                Models.obavijesti temp = new Models.obavijesti
                {
                    DatumObjave = datObjava.Value,
                    Naslov = txtNaslov.Text,
                    Sadrzaj = rtbSadrzaj.Text
                };

                int id_prof;
                bool v = int.TryParse(cbObjavio.SelectedValue.ToString(), out id_prof);

                temp.ProfesorID = id_prof;

                await _service.Insert(temp);
                MessageBox.Show("Uspješno ste dodali novu obavijest");
                this.Close();
            }
        }

        private void cbObjavio_Validating(object sender, CancelEventArgs e)
        {
            if ((int)cbObjavio.SelectedValue == 0)
            {
                errObavijest.SetError(cbObjavio, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errObavijest.SetError(cbObjavio, null);
            }
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text) == true)
            {
                errObavijest.SetError(txtNaslov, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errObavijest.SetError(txtNaslov, null);
            }
        }
    }
}
