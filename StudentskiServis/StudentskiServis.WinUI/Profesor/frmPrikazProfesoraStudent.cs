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
    public partial class frmPrikazProfesoraStudent : Form
    {
        private readonly APIService _service = new APIService("Profesor");

        public frmPrikazProfesoraStudent()
        {
            InitializeComponent();
        }

        private async void frmPrikazProfesoraStudent_Load(object sender, EventArgs e)
        {
            var temp = await _service.Get<List<Models.ProfesorAll>>(null);

            dgvProfS.AutoGenerateColumns = false;
            dgvProfS.DataSource = temp;
        }

        private void dgvProfS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id = (int)dgvProfS.SelectedRows[0].Cells[0].Value;

                frmProfesorDetaljiStudent frm = new frmProfesorDetaljiStudent(id);

                frm.Show();
            }
        }
    }
}
