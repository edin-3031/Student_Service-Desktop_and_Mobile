using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Obavijest
{
    public partial class frmObavjestenjaDetaljiStudent : Form
    {
        private readonly APIService _service = new APIService("Obavijest");
        int _id;
        public frmObavjestenjaDetaljiStudent(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmObavjestenjaDetaljiStudent_Load(object sender, EventArgs e)
        {
            var result = await _service.GetById<Models.obavijesti>(_id);

            txtProf.Text = result.Objavio;
            txtDatumObjave.Text = result.DatumObjave.ToString();
            txtNaslov.Text = result.Naslov;
            rtbSadrzaj.Text = result.Sadrzaj;
        }
    }
}
