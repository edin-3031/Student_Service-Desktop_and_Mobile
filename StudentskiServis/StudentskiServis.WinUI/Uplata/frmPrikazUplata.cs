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

namespace StudentskiServis.WinUI.Uplata
{
    public partial class frmPrikazUplata : Form
    {
        private readonly APIService _service = new APIService("Uplata");
        public frmPrikazUplata()
        {
            InitializeComponent();
        }

        private async void btnPrikazUplata_Click(object sender, EventArgs e)
        {
            var search = new UplataSearchRequest()
            {
                Svrha=txtSvrha.Text
            };

            var result = await _service.Get<List<Models.uplate>>(search);

            dgvUplate.AutoGenerateColumns = false;
            dgvUplate.DataSource = result;
        }

        private void dgvUplate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==2)
            {
                int id = (int)dgvUplate.SelectedRows[0].Cells[0].Value;

                frmDetaljiUplata frm = new frmDetaljiUplata(id);
                frm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
