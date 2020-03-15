using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Raspored
{
    public partial class frmMojRaspored : Form
    {
        private readonly APIService _service = new APIService("Raspored");
        int id;
        public frmMojRaspored(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmMojRaspored_Load(object sender, EventArgs e)
        {
            var lista = await _service.Get<List<Models.Raspored>>(null);

            var result = new List<Models.Raspored>();

            foreach(var x in lista)
            {
                if (x.StudentId == id)
                {
                    result.Add(new Models.Raspored
                    {
                        Datum=x.Datum,
                        Naslov=x.Naslov,
                        RasporedId=x.RasporedId,
                        StudentId=x.StudentId,
                        Vazno=x.Vazno,
                        Opis=x.Opis
                    });
                }
            }

            dgvRaspored.AutoGenerateColumns = false;
            dgvRaspored.DataSource = result;
        }

        private void dgvRaspored_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3)
            {
                int RasporedId = (int)dgvRaspored.SelectedRows[0].Cells[0].Value;

                MojRasporedDetalji frm = new MojRasporedDetalji(RasporedId);
                frm.Show();
            }
        }
    }
}
