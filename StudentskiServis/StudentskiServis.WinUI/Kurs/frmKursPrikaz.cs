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

namespace StudentskiServis.WinUI.Kurs
{
    public partial class frmKursPrikaz : Form
    {
        public frmKursPrikaz()
        {
            InitializeComponent();
        }

        private readonly APIService _service = new APIService("Kurs");

        private void dgvKurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var id = (int)dgvKurs.SelectedRows[0].Cells[0].Value;

                frmDetaljiKurs frm = new frmDetaljiKurs(id);
                frm.Show();
            }
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            KurseviSearchRequest search = new KurseviSearchRequest
            {
                Naziv = txtKurs.Text
            };

            var result = await _service.Get<List<Models.kursevi>>(search);

            dgvKurs.AutoGenerateColumns = false;
            dgvKurs.DataSource = result;
        }
    }
}
