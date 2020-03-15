using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Kurs
{
    public partial class frmKursDodaj : Form
    {
        private readonly APIService _service = new APIService("Kurs");
        public frmKursDodaj()
        {
            InitializeComponent();
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (txt_ECTS.Text == "")
            {
                errKurs.SetError(txt_ECTS, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                errKurs.SetError(txt_ECTS, null);

                Models.kursevi noviKurs = new Models.kursevi
                {
                    Ects = int.Parse(txt_ECTS.Text),
                    Naziv = txt_Naziv.Text
                };
                if (cb_Seminarski.Checked == true)
                    noviKurs.PosjedujeSeminarski = "Da";
                else if (cb_Seminarski.Checked == false)
                    noviKurs.PosjedujeSeminarski = "Ne";

                if (cb_Praksa.Checked == true)
                    noviKurs.PosjedujePraksu = "Da";
                else if (cb_Praksa.Checked == false)
                    noviKurs.PosjedujePraksu = "Ne";

                await _service.Insert(noviKurs);
                MessageBox.Show("Uspješno ste dodali novi kurs");
                this.Close();
            }
        }

        private void txt_Naziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Naziv.Text) == true)
            {
                errKurs.SetError(txt_Naziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errKurs.SetError(txt_Naziv, null);
            }
        }

        private void txt_ECTS_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ECTS.Text) == true)
            {
                errKurs.SetError(txt_ECTS, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errKurs.SetError(txt_ECTS, null);
            }
        }
    }
}
