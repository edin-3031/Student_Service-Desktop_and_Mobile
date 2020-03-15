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
    public partial class frmIspitiPrikazStudent : Form
    {
        int id;
        private readonly APIService _service = new APIService("Ispit");
        private readonly APIService _service_pohadjanja = new APIService("Pohadjanja");
        public frmIspitiPrikazStudent(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmIspitiPrikazStudent_Load(object sender, EventArgs e)
        {
            var temp = await _service.Get<List<Models.ispiti>>(null);

            int[] niz = new int[30];
            int brojac = 0;

            var pohadjanja = await _service_pohadjanja.Get<List<Models.pohadjanja>>(null);

            foreach(var x in pohadjanja)
            {
                if (x.StudentId == id)
                {
                    niz[brojac] = (int)x.KursId;
                    brojac++;
                }
            }

            var listaIspita = new List<Models.ispiti>();

            foreach(var y in temp)
            {
                while (brojac >= 0)
                {
                    if (y.KursId == niz[brojac])
                    {
                        listaIspita.Add(new Models.ispiti { 
                            BrojPitanja=y.BrojPitanja,
                            Datum=y.Datum,
                            IspitId=y.IspitId,
                            Kurs=y.Kurs,
                            KursId=y.KursId,
                            MaxBodova=y.MaxBodova,
                            ParcijalnoBodovanje=y.ParcijalnoBodovanje,
                            Profesor=y.Profesor,
                            ProfesorId=y.ProfesorId,
                            Trajanje=y.Trajanje,
                            Ucionica=y.Ucionica
                        });
                    }
                    brojac--;
                }
            }

            dgvIspitiS.AutoGenerateColumns = false;
            dgvIspitiS.DataSource = listaIspita;
        }

        private void dgvIspitiS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                int id = (int)dgvIspitiS.SelectedRows[0].Cells[0].Value;

                frmIspitiDetaljiStudent frm = new frmIspitiDetaljiStudent(id);
                frm.Show();
            }
        }
    }
}
