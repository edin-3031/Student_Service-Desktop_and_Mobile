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
    public partial class frmProfesorPrikazAdmin : Form
    {
        private int? _id = null;
        APIService _apiService = new APIService("Profesor");

        public frmProfesorPrikazAdmin(int? profesorId=null)
        {
            InitializeComponent();
        }

        //var search = new AdministracijaSearchRequest()
        //{
        //    Ime = txtPretraga.Text
        //    //Prezime = txtPretraga.Text
        //};


        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new ProfesorSearchRequest();

            var result = await _apiService.Get<List<Models.ProfesorAdmin>>(null);

            dgvProfesoriPrikaz.AutoGenerateColumns = false;
            dgvProfesoriPrikaz.DataSource = result;
        }

        private void dgvProfesoriPrikaz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id = (int)dgvProfesoriPrikaz.SelectedRows[0].Cells[0].Value;

                frmProfesorDetalji frm = new frmProfesorDetalji(id);
                frm.Show();


            }
        }

        private async void btnPrikaz_Click(object sender, EventArgs e)
        {
            var search = new ProfesorSearchRequest()
            {
                Ime = txtProfTrazi.Text//,
                //Prezime = txtProfTrazi.Text
            };

            var result = await _apiService.Get<List<Models.ProfesorAdmin>>(search);

            dgvProfesoriPrikaz.AutoGenerateColumns = false;
            dgvProfesoriPrikaz.DataSource = result;
        }
    }
}
