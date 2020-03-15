using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Uplata
{
    public partial class frmUplantnica : Form
    {
        Image temp;
        public frmUplantnica(Image _temp)
        {
            temp = _temp;

            InitializeComponent();
        }

        private void uplatnica_Click(object sender, EventArgs e)
        {

        }

        private void frmUplantnica_Load(object sender, EventArgs e)
        {
            uplatnica.Image = temp;
        }
    }
}
