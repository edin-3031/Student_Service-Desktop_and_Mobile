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
    public partial class frmIspitiDetaljiStudent : Form
    {
        int _id;
        private readonly APIService _service = new APIService("Ispit");
        public frmIspitiDetaljiStudent(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmIspitiDetaljiStudent_Load(object sender, EventArgs e)
        {
            var temp = await _service.GetById<Models.ispiti>(_id);

            txtKurs.Text = temp.Kurs;
            txtObjavio.Text = temp.Profesor;
            txtDatumOdrzavanja.Text = temp.Datum.ToString();
            txtUcionica.Text = temp.Ucionica;
            txtTrajanje.Text = temp.Trajanje.ToString();
            txtPitanja.Text = temp.BrojPitanja.ToString();
            txtBodovi.Text = temp.MaxBodova.ToString();

            if (temp.ParcijalnoBodovanje == "da" || temp.ParcijalnoBodovanje == "Da" || temp.ParcijalnoBodovanje == "DA")
                cbParcijalno.Checked = true;
            else if(temp.ParcijalnoBodovanje == "ne" || temp.ParcijalnoBodovanje == "Ne" || temp.ParcijalnoBodovanje == "NE")
                cbParcijalno.Checked = false;
        }
    }
}
