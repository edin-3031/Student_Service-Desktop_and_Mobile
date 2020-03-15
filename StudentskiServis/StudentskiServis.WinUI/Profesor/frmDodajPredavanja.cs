using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Profesor
{
    public partial class frmDodajPredavanja : Form
    {
        private readonly APIService _PROF = new APIService("PROF");
        private readonly APIService _KURS = new APIService("KURS");
        private readonly APIService _predavanja = new APIService("Predavanja");

        public frmDodajPredavanja()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private async void frmDodajPredavanja_Load(object sender, EventArgs e)
        {
            await LoadPROF();

            await LoadKURS();
        }

        private async Task LoadPROF()
        {
            var result = await _PROF.Get<List<Models.PROF>>(null);
            result.Insert(0, new Models.PROF());
            cboxProfesor.DataSource = result;
            cboxProfesor.DisplayMember = "Ime";
            cboxProfesor.ValueMember = "ProfesorId";
        }

        private async Task LoadKURS()
        {
            var result = await _KURS.Get<List<Models.KURS_>>(null);
            result.Insert(0, new Models.KURS_());
            cboxKurs.DataSource = result;
            cboxKurs.DisplayMember = "Naziv";
            cboxKurs.ValueMember = "KursId";
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (cboxProfesor.SelectedValue == null)
                errorProvider.SetError(cboxProfesor, Properties.Resources.Validation_RequiredField);
            else
                errorProvider.SetError(cboxProfesor, null);

            if (cboxKurs.SelectedValue == null)
                errorProvider.SetError(cboxKurs, Properties.Resources.Validation_RequiredField);
            else
                errorProvider.SetError(cboxKurs, null);

            if(rbtnP.Checked==false && rbtnV.Checked == false)
            {
                errorProvider.SetError(rbtnP, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errorProvider.SetError(rbtnP, null);
            }

            if (cboxProfesor.SelectedValue != null && cboxKurs.SelectedValue != null && (rbtnP.Checked != false || rbtnV.Checked != false))
            {
                int idProfesor;
                bool p = int.TryParse(cboxProfesor.SelectedValue.ToString(), out idProfesor);

                int idKurs;
                bool k = int.TryParse(cboxKurs.SelectedValue.ToString(), out idKurs);

                Models.predaje novi = new Models.predaje
                {
                    DatumPredavanja = datePredavanje.Value,
                    KursId = idKurs,
                    Opis = rtbOpis.Text,
                    ProfesorId = idProfesor
                };
                if (rbtnP.Checked == true)
                    novi.Vrsta = "Predavanje";
                if (rbtnV.Checked == true)
                    novi.Vrsta = "Vježbe";
                if (cbOdrzano.Checked == true)
                    novi.Odrzano = "Da";
                else if (cbOdrzano.Checked == false)
                    novi.Odrzano = "Ne";

                await _predavanja.Insert(novi);
                MessageBox.Show("Uspješno ste izvršili unos podataka");
            }
        }

        private void cboxProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
