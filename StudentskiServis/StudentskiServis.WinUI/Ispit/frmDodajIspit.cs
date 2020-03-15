using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Ispit
{
    public partial class frmDodajIspit : Form
    {
        public frmDodajIspit()
        {
            InitializeComponent();
        }

        private readonly APIService _service_ispit = new APIService("Ispit");
        private readonly APIService _service_kurs = new APIService("KURS_");
        private readonly APIService _service_prof = new APIService("PROF");

        private async void frmDodajIspit_Load(object sender, EventArgs e)
        {
            await LoadProf();
            await LoadKurs();
        }

        private async Task LoadProf()
        {
            var result = await _service_prof.Get<List<Models.PROF>>(null);
            result.Insert(0, new Models.PROF());

            cbObjavljuje.DataSource = result;
            cbObjavljuje.DisplayMember = "Ime";
            cbObjavljuje.ValueMember = "ProfesorId";
        }

        private async Task LoadKurs()
        {
            var result = await _service_kurs.Get<List<Models.KURS_>>(null);
            result.Insert(0, new Models.KURS_());

            cbKurs.DataSource = result;
            cbKurs.DisplayMember = "Naziv";
            cbKurs.ValueMember = "KursId";
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            int idKurs, idProf;

            if(cbKurs.SelectedValue==null)
                greskaV.SetError(cbKurs, Properties.Resources.Validation_RequiredField);
            else
                greskaV.SetError(cbKurs, null);

            if (cbObjavljuje.SelectedValue == null)
                greskaV.SetError(cbObjavljuje, Properties.Resources.Validation_RequiredField);
            else
                greskaV.SetError(cbObjavljuje, null);

            if(string.IsNullOrWhiteSpace(txtTrajanje.Text) == true)
                greskaV.SetError(txtTrajanje, Properties.Resources.Validation_RequiredField);
            else
                greskaV.SetError(txtTrajanje, null);

            if (string.IsNullOrWhiteSpace(txtBodovi.Text) == true)
                greskaV.SetError(txtBodovi, Properties.Resources.Validation_RequiredField);
            else
                greskaV.SetError(txtBodovi, null);

            if (string.IsNullOrWhiteSpace(txtPitanja.Text) == true)
                greskaV.SetError(txtPitanja, Properties.Resources.Validation_RequiredField);
            else
                greskaV.SetError(txtPitanja, null);

            if (string.IsNullOrWhiteSpace(txtUcionica.Text) == true)
                greskaV.SetError(txtUcionica, Properties.Resources.Validation_RequiredField);
            else
                greskaV.SetError(txtUcionica, null);


            if (cbKurs.SelectedValue != null && cbObjavljuje.SelectedValue != null && txtTrajanje.Text!="" && txtBodovi.Text!="" && txtPitanja.Text!="" && txtUcionica.Text!="")
            {
                bool? v1 = int.TryParse(cbKurs.SelectedValue.ToString(), out idKurs);
                bool? v2 = int.TryParse(cbObjavljuje.SelectedValue.ToString(), out idProf);

                Models.ispiti temp = new Models.ispiti()
                {
                    BrojPitanja = int.Parse(txtPitanja.Text),
                    Datum = dateDatum.Value,
                    KursId = idKurs,
                    MaxBodova = int.Parse(txtBodovi.Text),
                    ParcijalnoBodovanje = txtBodovi.Text,
                    ProfesorId = idProf,
                    Trajanje = int.Parse(txtTrajanje.Text),
                    Ucionica = txtUcionica.Text
                };

                if (cbParcijalno.Checked == true)
                    temp.ParcijalnoBodovanje = "Da";
                else if (cbParcijalno.Checked == false)
                    temp.ParcijalnoBodovanje = "Ne";

                await _service_ispit.Insert(temp);

                MessageBox.Show("Uspješno ste dodali novi ispit");
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbObjavljuje_Validating(object sender, CancelEventArgs e)
        {
            if (cbObjavljuje.SelectedIndex == -1)
            {
                greskaV.SetError(cbObjavljuje, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                greskaV.SetError(cbObjavljuje, null);
            }
        }

        private void cbKurs_Validating(object sender, CancelEventArgs e)
        {
            if (cbKurs.SelectedIndex == -1)
            {
                greskaV.SetError(cbKurs, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                greskaV.SetError(cbKurs, null);
            }
        }

        private void txtUcionica_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUcionica.Text) == true)
            {
                greskaV.SetError(txtUcionica, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                greskaV.SetError(txtUcionica, null);
            }
        }

        private void txtTrajanje_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrajanje.Text) == true)
            {
                greskaV.SetError(txtTrajanje, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                greskaV.SetError(txtTrajanje, null);
            }
        }

        private void txtBodovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBodovi.Text) == true)
            {
                greskaV.SetError(txtBodovi, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                greskaV.SetError(txtBodovi, null);
            }
        }

        private void txtPitanja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPitanja.Text) == true)
            {
                greskaV.SetError(txtPitanja, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                greskaV.SetError(txtPitanja, null);
            }
        }
    }
}
