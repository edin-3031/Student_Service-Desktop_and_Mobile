using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Kurs
{
    public partial class frmKursIzmijeni : Form
    {
        int id;
        private readonly APIService _service = new APIService("Kurs");
        public frmKursIzmijeni(int _id)
        {
            InitializeComponent();
            id = _id;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void frmKursIzmijeni_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.kursevi>(id);

            txtNaziv.Text = temp.Naziv;
            txtECTS.Text = temp.Ects.ToString();

            if (temp.PosjedujePraksu == "DA" || temp.PosjedujePraksu == "Da" || temp.PosjedujePraksu == "da")
                cbPraksa.Checked = true;
            else if(temp.PosjedujePraksu == "NE" || temp.PosjedujePraksu == "Ne" || temp.PosjedujePraksu == "ne")
                cbPraksa.Checked = false;

            if (temp.PosjedujeSeminarski == "DA" || temp.PosjedujeSeminarski == "Da" || temp.PosjedujeSeminarski == "da")
                cbSeminarski.Checked = true;
            else if (temp.PosjedujeSeminarski == "NE" || temp.PosjedujeSeminarski == "Ne" || temp.PosjedujeSeminarski == "ne")
                cbSeminarski.Checked = false;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Models.kursevi temp = await _service.GetById<Models.kursevi>(id);

            temp.Naziv = txtNaziv.Text;
            temp.Ects = int.Parse(txtECTS.Text);

            if (cbPraksa.Checked == true)
                temp.PosjedujePraksu = "Da";
            else if(cbPraksa.Checked == false)
                temp.PosjedujePraksu = "Ne";

            if (cbSeminarski.Checked == true)
                temp.PosjedujeSeminarski = "Da";
            else if (cbSeminarski.Checked == false)
                temp.PosjedujeSeminarski = "Ne";

            await _service.Update<Models.kursevi>(id, temp);
            MessageBox.Show("Uspješno ste izmijenili odabrani kurs");
            this.Close();
        }
    }
}
