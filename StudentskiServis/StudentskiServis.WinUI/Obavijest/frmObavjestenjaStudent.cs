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
    public partial class frmObavjestenjaStudent : Form
    {
        private readonly APIService _service = new APIService("Obavijest");

        public frmObavjestenjaStudent()
        {
            InitializeComponent();
        }

        private async void frmObavjestenjaStudent_Load(object sender, EventArgs e)
        {
            var temp = await _service.Get<List<Models.obavijesti>>(null);

            dgvObavijestiS.AutoGenerateColumns = false;
            dgvObavijestiS.DataSource = temp;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvObavijestiS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int id = (int)dgvObavijestiS.SelectedRows[0].Cells[0].Value;

                frmObavjestenjaDetaljiStudent frm = new frmObavjestenjaDetaljiStudent(id);
                frm.Show();
            }
        }
    }
}
