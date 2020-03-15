using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Student
{
    public partial class frmDodajPohadjanja : Form
    {
        private readonly APIService _stud = new APIService("STUD");
        private readonly APIService _kurs = new APIService("KURS_");
        private readonly APIService _pohadja = new APIService("Pohadjanja");

        public frmDodajPohadjanja()
        {
            InitializeComponent();
        }

        private async void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void frmDodajPohadjanja_Load(object sender, EventArgs e)
        {
            await LoadKurs();
            await LoadStud();
        }

        private async Task LoadKurs()
        {
            var result = await _kurs.Get<List<Models.KURS_>>(null);
            result.Insert(0, new Models.KURS_());
            cbKurs.DataSource = result;
            cbKurs.ValueMember = "KursId";
            cbKurs.DisplayMember = "Naziv";
        }

        private async Task LoadStud()
        {
            var result = await _stud.Get<List<Models.STUD>>(null);
            result.Insert(0, new Models.STUD());
            cbStudent.DataSource = result;
            cbStudent.DisplayMember = "Ime";
            cbStudent.ValueMember = "StudentId";
        }

        private void rbtnobnavljaDA_CheckedChanged(object sender, EventArgs e)
        {
            txtOcjena.Enabled = true;
        }

        private void rbtnobnavljaNE_CheckedChanged(object sender, EventArgs e)
        {
            txtOcjena.Enabled = false;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                int idStudent;
                bool p = int.TryParse(cbStudent.SelectedValue.ToString(), out idStudent);


                int idKurs;
                bool v2 = int.TryParse(cbKurs.SelectedIndex.ToString(), out idKurs);

                Models.pohadjanja novi = new Models.pohadjanja
                {
                    StudentId = idStudent,
                    KursId = idKurs,
                };
                //AKTIVAN
                if (rbtnaktivanDA.Checked == true)
                    novi.Aktivan = "Da";
                else if (rbtnaktivanNE.Checked == true)
                    novi.Aktivan = "Ne";

                //OBNAVLJA
                if (rbObnavljaDA.Checked == true)
                {
                    novi.Obnavlja = "Da";
                    novi.BrojObnavljanja = int.Parse(txtBrojObnavljanja.Text);
                }
                else if (rbObnavljaNE.Checked == true)
                {
                    novi.Obnavlja = "Ne";
                    novi.BrojObnavljanja = 0;
                }

                //POLOŽIO
                if (rbtnPolozioDA.Checked == true)
                {
                    novi.Polozio = "Da";
                    novi.Ocjena = int.Parse(txtOcjena.Text);
                }
                else if (rbtnPolozioNE.Checked == true)
                {
                    novi.Polozio = "Ne";
                    novi.Ocjena = 0;
                }

                await _pohadja.Insert(novi);
                MessageBox.Show("Uspješno ste snimili podatke");
                this.Close();
            }
        }

        private void rbObnavljaNE_CheckedChanged(object sender, EventArgs e)
        {
            txtBrojObnavljanja.Enabled = false;
        }

        private void rbObnavljaDA_CheckedChanged(object sender, EventArgs e)
        {
            txtBrojObnavljanja.Enabled = true;
        }

        private void cbStudent_Validating(object sender, CancelEventArgs e)
        {
            if ((int)cbStudent.SelectedValue == 0 || cbStudent.SelectedValue == null)
            {
                error.SetError(cbStudent, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(cbStudent, null);
            }
        }

        private void cbKurs_Validating(object sender, CancelEventArgs e)
        {
            if ((int)cbKurs.SelectedValue == 0 || cbKurs == null)
            {
                error.SetError(cbKurs, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(cbKurs, null);
            }
        }

        private void groupBox2_Validating(object sender, CancelEventArgs e)
        {

        }

        private void groupBox3_Validating(object sender, CancelEventArgs e)
        {

        }

        private void rbtnaktivanNE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnaktivanNE_Validating(object sender, CancelEventArgs e)
        {
            if (rbtnaktivanDA.Checked == false && rbtnaktivanNE.Checked == false)
            {
                error.SetError(rbtnaktivanNE, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(rbtnaktivanNE, null);
            }
        }

        private void rbObnavljaNE_Validating(object sender, CancelEventArgs e)
        {
            if (rbObnavljaDA.Checked == false && rbObnavljaNE.Checked == false)
            {
                error.SetError(rbObnavljaNE, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(rbObnavljaNE, null);
            }
        }

        private void rbtnPolozioNE_Validating(object sender, CancelEventArgs e)
        {
            if (rbtnPolozioDA.Checked == false && rbtnPolozioNE.Checked == false)
            {
                error.SetError(rbtnPolozioNE, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                error.SetError(rbtnPolozioNE, null);

            }
        }

        private void txtBrojObnavljanja_Validating(object sender, CancelEventArgs e)
        {
            if (this.Enabled == true)
            {
                if (txtBrojObnavljanja.Text == "")
                {
                    error.SetError(txtBrojObnavljanja, Properties.Resources.Validation_RequiredField);
                }
                else
                {
                    error.SetError(txtBrojObnavljanja, null);
                }
            }
        }

        private void txtOcjena_Validating(object sender, CancelEventArgs e)
        {
            if (txtOcjena.Text == "")
            {
                error.SetError(txtOcjena, Properties.Resources.Validation_RequiredField);
            }
            else
            {
                error.SetError(txtOcjena, null);
            }
        }
    }
}
