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

namespace StudentskiServis.WinUI.Student
{
    public partial class frmStudentDetalji : Form
    {
        private readonly APIService _STUD = new APIService("STUD");
        private readonly APIService _pohadjanja = new APIService("Pohadjanja");

        public frmStudentDetalji()
        {
            InitializeComponent();
        }

        private async void frmStudentDetalji_Load(object sender, EventArgs e)
        {
            await LoadSTUD();
        }

        private async Task LoadSTUD()
        {
            var result = await _STUD.Get<List<Models.STUD>>(null);
            result.Insert(0, new Models.STUD());
            cmbSTUD.DisplayMember = "Ime";
            cmbSTUD.ValueMember = "StudentID";
            cmbSTUD.DataSource = result;
        }

        private async void cmbSTUD_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbSTUD.SelectedValue;
            if (idObj != null)
            {
                if (int.TryParse(idObj.ToString(), out int id))
                {
                    await LoadPohadjanja(id);
                }
            }
        }

        private async Task LoadPohadjanja(int _id)
        {
            var result = await _pohadjanja.Get<List<Models.pohadjanja>>(new PohadjanjaSearchRequest()
            {
                StudentId = _id
            });

            dgvPohadja.AutoGenerateColumns = false;
            dgvPohadja.DataSource = result;
        }

        private void dgvPohadja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int id_kurs = (int)dgvPohadja.SelectedRows[0].Cells[0].Value;
                int id_pohadja = (int)dgvPohadja.SelectedRows[0].Cells[1].Value;

                frmStudentDetaljiAdmin frm = new frmStudentDetaljiAdmin(id_kurs,id_pohadja);
                frm.Show();
            }
        }

        private void dgvPohadja_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
