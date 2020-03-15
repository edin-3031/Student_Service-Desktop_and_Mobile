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
    public partial class frmIzmijeniIspit : Form
    {
        int _id;
        private readonly APIService _service_prof = new APIService("PROF");
        private readonly APIService _service_ispit = new APIService("Ispit");
        private readonly APIService _service_kurs = new APIService("KURS");


        public frmIzmijeniIspit(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmIzmijeniIspit_Load(object sender, EventArgs e)
        {
            await LoadKurs();
            await LoadProf();

            Models.ispiti temp = await _service_ispit.GetById<Models.ispiti>(_id);

            txtUcionica.Text = temp.Ucionica;
            dateIspit.Value = temp.Datum.Value;
            txtTrajanje.Text = temp.Trajanje.ToString();
            txtPitanja.Text = temp.BrojPitanja.ToString();
            txtBodovi.Text = temp.MaxBodova.ToString();
            if (temp.ParcijalnoBodovanje == "Da" || temp.ParcijalnoBodovanje == "da" || temp.ParcijalnoBodovanje == "DA")
                cbParcijalno.Checked = true;
            else if(temp.ParcijalnoBodovanje == "Ne" || temp.ParcijalnoBodovanje == "ne" || temp.ParcijalnoBodovanje == "NE")
                cbParcijalno.Checked = false;

            
        }

        private async Task LoadKurs()
        {
            var temp = await _service_kurs.Get<List<Models.KURS_>>(null);
            Models.ispiti postojeci = await _service_ispit.GetById<Models.ispiti>(_id);

            temp.Insert(0, new Models.KURS_ { 
                KursId=postojeci.KursId.Value,
                Naziv=postojeci.Kurs
            });
            cbKurs.DataSource = temp;
            cbKurs.DisplayMember = "Naziv";
            cbKurs.ValueMember = "KursId";
        }

        private async Task LoadProf()
        {
            var temp = await _service_prof.Get<List<Models.PROF>>(null);
            Models.ispiti postojeci = await _service_ispit.GetById<Models.ispiti>(_id);

            temp.Insert(0, new Models.PROF { 
                Ime=postojeci.Profesor,
                ProfesorId=postojeci.ProfesorId.Value
            });
            cbObjavio.DataSource = temp;
            cbObjavio.DisplayMember = "Ime";
            cbObjavio.ValueMember = "ProfesorId";
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            int idKurs, idProf;

            bool v1 = int.TryParse(cbKurs.SelectedValue.ToString(), out idKurs);
            bool v2 = int.TryParse(cbObjavio.SelectedValue.ToString(), out idProf);

            Models.ispiti temp = new Models.ispiti
            {
                BrojPitanja = int.Parse(txtPitanja.Text),
                Datum = dateIspit.Value,
                IspitId = _id,
                KursId = idKurs,
                MaxBodova = int.Parse(txtBodovi.Text),
                Trajanje = int.Parse(txtTrajanje.Text),
                ProfesorId = idProf,
                Ucionica=txtUcionica.Text
            };
            if (cbParcijalno.Checked)
                temp.ParcijalnoBodovanje = "Da";
            else if(!cbParcijalno.Checked)
                temp.ParcijalnoBodovanje = "Ne";

            await _service_ispit.Update<Models.ispiti>(_id, temp);
            MessageBox.Show("Uspješno ste izmijenili ispit");
            this.Close();
        }

        private void cbKurs_Validating(object sender, CancelEventArgs e)
        {
            if ((int)cbKurs.SelectedValue != 0)
            {
                errorIzmjena.SetError(cbKurs, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorIzmjena.SetError(cbKurs, null);
            }
        }

        private void cbObjavio_Validating(object sender, CancelEventArgs e)
        {
            if ((int)cbObjavio.SelectedValue != 0)
            {
                errorIzmjena.SetError(cbObjavio, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorIzmjena.SetError(cbObjavio, null);
            }
        }

        private void txtUcionica_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUcionica.Text) == true)
            {
                errorIzmjena.SetError(txtUcionica, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorIzmjena.SetError(txtUcionica, null);
            }
        }

        private void txtTrajanje_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrajanje.Text) == true)
            {
                errorIzmjena.SetError(txtTrajanje, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorIzmjena.SetError(txtTrajanje, null);
            }
        }

        private void txtPitanja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPitanja.Text) == true)
            {
                errorIzmjena.SetError(txtPitanja, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorIzmjena.SetError(txtPitanja, null);
            }
        }

        private void txtBodovi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBodovi.Text) == true)
            {
                errorIzmjena.SetError(txtBodovi, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorIzmjena.SetError(txtBodovi, null);
            }

        }
    }
}
