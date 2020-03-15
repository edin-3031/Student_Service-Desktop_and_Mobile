using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Administracija
{
    public partial class frmAdministracijaDetaljiStudent : Form
    {
        private readonly APIService _service = new APIService("Administracija");
        int _id;

        public frmAdministracijaDetaljiStudent(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void frmAdministracijaDetaljiStudent_Load(object sender, EventArgs e)
        {
            var result = await _service.GetById<Models.AdministracijaAll>(_id);

            txtIme.Text = result.Ime;
            txtPrezime.Text = result.Prezime;
            txtMail.Text = result.Mail;
            txtKancelarija.Text = result.Kancelarija;
            picSlika.Image = (Bitmap)(new ImageConverter().ConvertFrom(result.Slika));
        }
    }
}
