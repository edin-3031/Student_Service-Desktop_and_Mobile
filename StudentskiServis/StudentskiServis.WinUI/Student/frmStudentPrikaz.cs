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
    public partial class frmStudentPrikaz : Form
    {
        private int? _id = null;
        APIService _apiService = new APIService("Student");
        public frmStudentPrikaz()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new StudentSearchRequest()
            {
                //Ime = txtStudent.Text,
                //Prezime = txtStudent.Text,
                Indeks = txtStudent.Text
            };

            var result = await _apiService.Get<List<Models.StudentAdmin>>(search);

            dgvStudent.AutoGenerateColumns = false;
            dgvStudent.DataSource = result;
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id = (int)dgvStudent.SelectedRows[0].Cells[0].Value;

                frmDetaljiStudenta frm = new frmDetaljiStudenta(id);
                frm.Show();
            }
        }
    }
}
