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
    public partial class frmIzmjenaObavijesti : Form
    {
        int? _id = null;
        private APIService _service = new APIService("Obavijest");
        private APIService _prof_service = new APIService("PROF");
        public frmIzmjenaObavijesti(int? id)
        {
            InitializeComponent();
            _id = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void frmIzmjenaObavijesti_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.obavijesti>(_id);
            var prof = await _prof_service.Get<List<Models.PROF>>(null);

            txtNaslov.Text = temp.Naslov;
            datObjava.Value = temp.DatumObjave;
            rtbSadrzaj.Text = temp.Sadrzaj;

            prof.Insert(0, new Models.PROF
            {
                ProfesorId=temp.ProfesorID,
                Ime=temp.Objavio
            });

            cbObjavio.DataSource = prof;
            cbObjavio.DisplayMember = "Ime";
            cbObjavio.ValueMember = "ProfesorId";

        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Models.obavijesti temp = await _service.GetById<Models.obavijesti>(_id);

            int idProf;
            bool v = int.TryParse(cbObjavio.SelectedValue.ToString(), out idProf);

            temp.DatumObjave = datObjava.Value;
            temp.Naslov = txtNaslov.Text;
            temp.Sadrzaj = rtbSadrzaj.Text;
            temp.ProfesorID = idProf;

            await _service.Update<Models.obavijesti>(_id, temp);
            MessageBox.Show("Uspješno ste izvršili izmjene nad odabranom obavijesti");
            this.Close();
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text) == true)
            {
                errIzmjena.SetError(txtNaslov, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errIzmjena.SetError(txtNaslov, null);
            }
        }

        private void cbObjavio_Validating(object sender, CancelEventArgs e)
        {
            if ((int)cbObjavio.SelectedValue==0)
            {
                errIzmjena.SetError(cbObjavio, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errIzmjena.SetError(cbObjavio, null);
            }
        }
    }
}
