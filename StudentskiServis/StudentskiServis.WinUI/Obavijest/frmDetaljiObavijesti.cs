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
    public partial class frmDetaljiObavijesti : Form
    {
        int? _id=null;
        private readonly APIService _service = new APIService("Obavijest");

        public frmDetaljiObavijesti(int id)
        {
            _id = id;

            InitializeComponent();
        }

        private async void frmDetaljiObavijesti_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.obavijesti>(_id);

            txtProf.Text = temp.Objavio;
            txtDatumObjave.Text = temp.DatumObjave.ToString();
            txtNaslov.Text = temp.Naslov;
            rtbSadrzaj.Text = temp.Sadrzaj;
        }

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            var t=MessageBox.Show("Da li ste sigurni da želite obrisati odabranu uplatu?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (t == DialogResult.Yes)
            {
                await _service.Delete(_id);
                MessageBox.Show("Uspješno ste uklonuli uplatu");
                this.Close();
            }
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            frmIzmjenaObavijesti frm = new frmIzmjenaObavijesti(_id);
            frm.Show();
        }
    }
}
