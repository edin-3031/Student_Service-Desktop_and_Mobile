using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Profesor
{
    public partial class frmProfesorDetaljiStudent : Form
    {
        private readonly APIService _service = new APIService("Profesor");
        int _id;
        public frmProfesorDetaljiStudent(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmProfesorDetaljiStudent_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.ProfesorAll>(_id);

            txtIme.Text = temp.Ime;
            txtZvanje.Text = temp.Zvanje;
            txtPrezime.Text = temp.Prezime;
            txtMail.Text = temp.Mail;
            txtKancelarija.Text = temp.Kancelarija;
            picSlika.Image = (Bitmap)(new ImageConverter().ConvertFrom(temp.Slika));
        }
    }
}
