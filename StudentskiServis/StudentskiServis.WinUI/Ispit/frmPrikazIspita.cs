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

namespace StudentskiServis.WinUI.Ispit
{
    public partial class frmPrikazIspita : Form
    {
        private APIService _service = new APIService("Ispit");

        public frmPrikazIspita()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            IspitSearchRequest search = new IspitSearchRequest
            {
                Kurs = txtKurs.Text
            };

            var result = await _service.Get<List<Models.ispiti>>(search);

            dgvIspiti.AutoGenerateColumns = false;
            dgvIspiti.DataSource = result;
        }

        private void dgvIspiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id=(int)dgvIspiti.SelectedRows[0].Cells[0].Value;

                frmDetaljiIspita frm = new frmDetaljiIspita(id);
                frm.Show();
            }
        }
    }
}
