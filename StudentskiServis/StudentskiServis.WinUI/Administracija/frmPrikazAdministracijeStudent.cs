using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Administracija
{
    public partial class frmPrikazAdministracijeStudent : Form
    {

        private readonly APIService _service = new APIService("Administracija");

        public frmPrikazAdministracijeStudent()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void frmPrikazAdministracijeStudent_Load(object sender, EventArgs e)
        {
            var result = await _service.Get < List<Models.AdministracijaAll>>(null);

            dgvAdminS.AutoGenerateColumns = false;
            dgvAdminS.DataSource = result;
        }

        private void dgvAdminS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int id =(int)dgvAdminS.SelectedRows[0].Cells[0].Value;

                frmAdministracijaDetaljiStudent frm = new frmAdministracijaDetaljiStudent(id);
                frm.Show();
            }
        }
    }
}
