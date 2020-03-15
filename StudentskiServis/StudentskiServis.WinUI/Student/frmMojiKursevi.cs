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
    public partial class frmMojiKursevi : Form
    {
        private readonly APIService _service = new APIService("Pohadjanja");
        int id;
        public frmMojiKursevi(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private async void frmMojiKursevi_Load(object sender, EventArgs e)
        {
            var result = await _service.Get<List<Models.pohadjanja>>(null);

            List<Models.pohadjanja> polozeni = new List<Models.pohadjanja>();
            List<Models.pohadjanja> nepolozeni = new List<Models.pohadjanja>();

            foreach(var x in result)
            {
                if(x.StudentId==id && x.Polozio == "Da")
                {
                    polozeni.Add(new Models.pohadjanja
                    {
                        Aktivan = x.Aktivan,
                        BrojObnavljanja = x.BrojObnavljanja,
                        Naziv = x.Naziv,
                        KursId = x.KursId,
                        Obnavlja = x.Obnavlja,
                        Ocjena = x.Ocjena,
                        PohadjaId = x.PohadjaId,
                        Polozio = x.Polozio,
                        StudentId = x.StudentId
                    });
                }

                else if(x.StudentId == id && x.Polozio == "Ne")
                {
                    nepolozeni.Add(new Models.pohadjanja
                    {
                        Aktivan = x.Aktivan,
                        BrojObnavljanja = x.BrojObnavljanja,
                        Naziv = x.Naziv,
                        KursId = x.KursId,
                        Obnavlja = x.Obnavlja,
                        Ocjena = x.Ocjena,
                        PohadjaId = x.PohadjaId,
                        Polozio = x.Polozio,
                        StudentId = x.StudentId
                    });
                }
            }

            dgvPolozeni.AutoGenerateColumns = false;
            dgvNepolozeni.AutoGenerateColumns = false;

            dgvPolozeni.DataSource = polozeni;
            dgvNepolozeni.DataSource = nepolozeni;

        }

        private void dgvPolozeni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Položeni_Enter(object sender, EventArgs e)
        {

        }
    }
}
