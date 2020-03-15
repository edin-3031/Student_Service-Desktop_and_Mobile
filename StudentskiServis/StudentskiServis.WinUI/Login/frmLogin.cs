using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Login
{
    public partial class frmLogin : Form
    {
        private readonly APIService _service_uloga = new APIService("Uloga");
        private readonly APIService _service_auth = new APIService("Auth");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void frmLogin_Load(object sender, EventArgs e)
        {
            await LoadUloge();
        }

        private async Task LoadUloge()
        {
            List<Models.ULOGA> result = await _service_uloga.Get<List<Models.ULOGA>>(null);

            result.Insert(0, new Models.ULOGA());

            cbRole.DataSource = result;

            cbRole.ValueMember = "UlogaId";
            cbRole.DisplayMember = "Naziv";
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPass.Text != "" && ((int)cbRole.SelectedValue!=0))
            {

                string username = txtUsername.Text;
                string pass = txtPass.Text;
                int ulogaId = (int)cbRole.SelectedValue;

                try
                {
                    var id = await _service_auth.Auth(username, pass, ulogaId);

                    ULOGA u = await _service_uloga.GetById<ULOGA>(ulogaId);

                    if (id != null)
                    {
                        this.MinimizeBox = true;
                        if (u.Naziv== "Administrator")
                        {
                            frmAdmin frm = new frmAdmin((int)id[0]);
                            frm.Show();
                        }
                        else if (u.Naziv == "Student")
                        {
                            frmStud frm = new frmStud((int)id[0]);
                            frm.Show();
                        }
                        else if (u.Naziv == "Profesor")
                        {
                            frmProf frm = new frmProf((int)id[0]);
                            frm.Show();
                        }

                    }
                    //else if (id == null)
                    //{
                    //    MessageBox.Show("Unijeli ste pogrešne podatke", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                catch(Exception except)
                {
                    MessageBox.Show("Molimo unesite ispravne podatke", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                
            }
            else MessageBox.Show("Molimo unesite ispravne podatke", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRole_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
