using StudentskiServis.Models.Requests;
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
    public partial class frmPredavanjaDetalji : Form
    {
        private readonly APIService _PROF = new APIService("PROF");
        private readonly APIService _predavanja = new APIService("Predavanja");


        public frmPredavanjaDetalji()
        {
            InitializeComponent();
        }

        private async void frmPredavanjaDetalji_Load_1(object sender, EventArgs e)
        {
            await LoadPROF();
        }

        private async Task LoadPROF()
        {
            var result = await _PROF.Get<List<Models.PROF>>(null);
            result.Insert(0, new Models.PROF());
            cmbPROF.DisplayMember = "Ime";
            cmbPROF.ValueMember = "ProfesorId";
            cmbPROF.DataSource = result;
        }

        private async void cmbPROF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPROF.SelectedValue != null) {
                var idObj = cmbPROF.SelectedValue;
                if (int.TryParse(idObj.ToString(), out int id))
                {
                    await LoadPredavanja(id);
                }
            }
        }

        private async Task LoadPredavanja(int _id)
        {
            var result = await _predavanja.Get<List<Models.predavanja>>(new PredavanjaSearchRequest()
            {
                ProfesorId = _id
            });

            dvgPredavanja.AutoGenerateColumns = false;
            dvgPredavanja.DataSource = result;
        }

        private async void frmPredavanjaDetalji_Load(object sender, EventArgs e)
        {
            
        }

        private void dvgPredavanja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dvgPredavanja.SelectedRows[0].Cells[0].Value;

            frmProfesorDetaljiAdmin frm = new frmProfesorDetaljiAdmin(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
