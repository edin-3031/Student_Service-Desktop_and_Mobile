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
    public partial class frmPredavanjeIzmjena : Form
    {
        private readonly APIService _service = new APIService("Predavanja");

        int? _id=null;
        public frmPredavanjeIzmjena(int? id)
        {
            InitializeComponent();

            _id = id;
        }

        private async void frmPredavanjeIzmjena_Load(object sender, EventArgs e)
        {
            Models.predavanja t = await _service.GetById<Models.predavanja>(_id);

            datDatum.Value = t.DatumPredavanja.Value;

            if (t.Vrsta == "Predavanje")
                rbPredavanje.Checked = true;
            else if (t.Vrsta == "Vježbe")
                rbVjezba.Checked = true;

            if (t.Odrzano == "DA" || t.Odrzano == "Da" || t.Odrzano == "da")
                cBoxOdrzano.Checked = true;
            else if (t.Odrzano == "NE" || t.Odrzano == "Ne" || t.Odrzano == "ne")
                cBoxOdrzano.Checked = false;

            rtbOpis.Text = t.Opis;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Models.predavanja postojeci = await _service.GetById<Models.predavanja>(_id);

            Models.predavanja temp = new Models.predavanja
            {
                DatumPredavanja = datDatum.Value,
                KursId = postojeci.KursId,
                Naziv = postojeci.Naziv,
                Opis = rtbOpis.Text,
                ProfesorId = postojeci.ProfesorId,
                PredajeId = postojeci.PredajeId
            };
            if (cBoxOdrzano.Checked==true)
                temp.Odrzano = "Da";
            else if (cBoxOdrzano.Checked==false)
                temp.Odrzano = "Ne";

            if (rbVjezba.Checked == true)
                temp.Vrsta = "Vježbe";
            else if (rbPredavanje.Checked==true)
                temp.Vrsta = "Predavanje";


            await _service.Update<Models.predavanja>(_id, temp);
            MessageBox.Show("Uspješno ste izmijenili podatke o predavanju");
            this.Close();
        }
    }
}
