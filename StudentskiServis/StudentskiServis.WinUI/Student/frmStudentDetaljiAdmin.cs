using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentskiServis.Models.Requests;


namespace StudentskiServis.WinUI.Student
{
    public partial class frmStudentDetaljiAdmin : Form
    {
        private int? _id_kurs = null;
        private int? _id_pohadja = null;
        APIService _service = new APIService("Kurs");
        APIService _service_pohadjanje = new APIService("Pohadjanja");

        public frmStudentDetaljiAdmin(int? kursId = null,int? pohadjaId=null)
        {
            InitializeComponent();
            _id_kurs  = kursId;
            _id_pohadja = pohadjaId;
        }

        private async void frmStudentDetaljiAdmin_Load(object sender, EventArgs e)
        {
            if (_id_kurs.HasValue)
            {
                var kurs = await _service.GetById<Models.kursevi>(_id_kurs);
                var pohadja = await _service_pohadjanje.GetById<Models.pohadjanja>(_id_pohadja);

                txtNaziv.Text = kurs.Naziv;
                txtECTS.Text = kurs.Ects.ToString();
                txtPraksa.Text = kurs.PosjedujePraksu;
                txtSeminiarski.Text = kurs.PosjedujeSeminarski;

                txtObnavlja.Text = pohadja.Obnavlja;
                txtBrojObnavljanja.Text = pohadja.BrojObnavljanja.ToString();
                txtAktivan.Text = pohadja.Aktivan;
                txtPolozio.Text = pohadja.Polozio;
                if (pohadja.Ocjena == 0 || pohadja.Ocjena == null)
                {
                    txtOcjena.Text = "N/A";
                }
                else
                    txtOcjena.Text = pohadja.Ocjena.ToString();

            }
        }

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            await _service_pohadjanje.Delete(_id_pohadja);
            MessageBox.Show("Uspješno ste obrisali pohađanje");
            this.Close();
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmPohadjanjaIzmijeni frm = new frmPohadjanjaIzmijeni(_id_pohadja);
            frm.Show();
        }
    }
}
