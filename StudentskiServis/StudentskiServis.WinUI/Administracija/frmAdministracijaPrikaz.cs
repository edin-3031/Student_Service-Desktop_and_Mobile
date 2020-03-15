using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using StudentskiServis.Models.Requests;

namespace StudentskiServis.WinUI.Administracija
{
    public partial class frmAdministracijaPrikaz : Form
    {
        private int? _id = null;
        APIService _apiService=new APIService("Administracija");

        public frmAdministracijaPrikaz(int? administracijaId = null)
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new AdministracijaSearchRequest()
            {
                Ime = txtPretraga.Text
                //Prezime = txtPretraga.Text
            };

            var result = await _apiService.Get<List<Models.AdministracijaAll>>(search);

            dgvAdministracija.AutoGenerateColumns = false;
            dgvAdministracija.DataSource = result;
        }

        private void dgvAdministracija_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id = (int)dgvAdministracija.SelectedRows[0].Cells[0].Value;

                //frmAdministracijaUnosAdmin frm = new frmAdministracijaUnosAdmin(int.Parse(id.ToString()));
                //frm.Show();

                frmAdministracijaDetaljiAdmin frm = new frmAdministracijaDetaljiAdmin(id);
                frm.Show();

                
            }
        }

        private async void dgvAdministracija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void frmAdministracijaPrikaz_Load(object sender, EventArgs e)
        {

        }
        private void dgvAdministracija_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //var id = dgvAdministracija.SelectedRows[0].Cells[0].Value;

            //frmAdministracijaDetaljiAdmin frm = new frmAdministracijaDetaljiAdmin(int.Parse(id.ToString()));
            //frm.Show();
        }
        private void dgvAdministracija_Click(object sender, EventArgs e)
        {

            //var id = dgvAdministracija.SelectedRows[0].Cells[0].Value;

            //frmAdministracijaDetaljiAdmin frm = new frmAdministracijaDetaljiAdmin(int.Parse(id.ToString()));
            //frm.Show();
        }

        private void dgvAdministracija_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
