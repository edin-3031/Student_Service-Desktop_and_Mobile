using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Student
{
    public partial class frmMojeUplate : Form
    {
        int? id=null;
        private readonly APIService _service = new APIService("Uplata");
        public frmMojeUplate(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void frmMojeUplate_Load(object sender, EventArgs e)
        {
            List<Models.uplate> temp = await _service.Get<List<Models.uplate>>(null);
            dgvMojeUplate.AutoGenerateColumns = false;

            var result = new List<Models.uplate>();

            foreach(var x in temp)
            {
                if (x.StudentId == id)
                {
                    result.Insert(0, new Models.uplate
                    {
                        AdministracijaId = x.AdministracijaId,
                        DatumUplate = x.DatumUplate,
                        Evidentirao = x.Evidentirao,
                        Iznos = x.Iznos,
                        Ovjereno = x.Ovjereno,
                        Slika = x.Slika,
                        StudentId = x.StudentId,
                        Svrha = x.Svrha,
                        UplataId = x.UplataId,
                        Uplatio = x.Uplatio
                    });
                }
            }

            dgvMojeUplate.DataSource = result;
        }

        private void dgvMojeUplate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int UplataId = (int)dgvMojeUplate.SelectedRows[0].Cells[0].Value;

                frmMojaUplataDetalji frm = new frmMojaUplataDetalji(UplataId);
                frm.Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
