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

namespace StudentskiServis.WinUI.Obavijest
{
    public partial class frmObavijest : Form
    {
        private readonly APIService _service = new APIService("Obavijest");
        public frmObavijest()
        {
            InitializeComponent();
        }

        private async void btnPrikaz_Click(object sender, EventArgs e)
        {
            ObavijestSearchRequest search = new ObavijestSearchRequest
            {
                Naslov = txtNaslov.Text
            };

            var result=await _service.Get<List<Models.obavijesti>>(search);

            dgvObavijesti.AutoGenerateColumns = false;
            dgvObavijesti.DataSource = result;
        }

        private void dgvObavijesti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var id = (int)dgvObavijesti.SelectedRows[0].Cells[0].Value;

                frmDetaljiObavijesti frm = new frmDetaljiObavijesti(id);
                frm.Show();
            }
        }
    }
}
