using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis.WinUI.Uplata
{
    public partial class frmNovaUplata : Form
    {
        private readonly APIService stud_service = new APIService("STUD");
        private readonly APIService admin_service = new APIService("ADMIN");
        private readonly APIService uplata_service = new APIService("Uplata");

        public frmNovaUplata()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnAddSlika_Click(object sender, EventArgs e)
        {
            var result = openFileDialogUplata.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialogUplata.FileName;

                var file = File.ReadAllBytes(fileName);

                Image image = Image.FromFile(fileName);
                pbUplata.Image = image;
            }
        }

        private async void frmNovaUplata_Load(object sender, EventArgs e)
        {
            await LoadAdmin();
            await LoadStud();
        }

        public async Task LoadAdmin()
        {
            var result = await admin_service.Get<List<Models.ADMIN>>(null);

            result.Insert(0, new Models.ADMIN() { });
            cbEvidentirao.DataSource = result;
            cbEvidentirao.DisplayMember = "Ime";    
            cbEvidentirao.ValueMember = "AdministracijaId";
        }
        public async Task LoadStud()
        {
            var result = await stud_service.Get<List<Models.STUD>>(null);

            result.Insert(0, new Models.STUD() { });
            cbUplatio.DataSource = result;
            cbUplatio.DisplayMember = "Ime";
            cbUplatio.ValueMember = "StudentId";
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {

                if ((int)cbUplatio.SelectedValue == 0)
                {
                    errorProvider1.SetError(cbUplatio, "Morate odabrati polje");
                }
                if ((int)cbEvidentirao.SelectedValue == 0)
                {
                    errorProvider1.SetError(cbEvidentirao, "Morate odabrati polje");
                }
                if ((int)cbUplatio.SelectedValue != 0 && (int)cbEvidentirao.SelectedValue != 0 && txtSvrha.Text != "" && txtIznos.Text != "")
                {
                    errorProvider1.SetError(cbUplatio, null);
                    errorProvider1.SetError(cbEvidentirao, null);

                    int AdminID, StudID;

                    bool v1 = int.TryParse(cbEvidentirao.SelectedValue.ToString(), out AdminID);
                    bool v2 = int.TryParse(cbUplatio.SelectedValue.ToString(), out StudID);

                    Models.uplate temp = new Models.uplate
                    {
                        AdministracijaId = AdminID,
                        DatumUplate = dateUplata.Value,
                        Iznos = float.Parse(txtIznos.Text),
                        StudentId = StudID,
                        Svrha = txtSvrha.Text
                    };

                    if (pbUplata.Image != null)
                    {
                        temp.Slika = imageToByteArray(pbUplata.Image);
                    }
                    else if (pbUplata.Image == null)
                    {
                        temp.Slika = imageToByteArray(Properties.Resources.No_Picture);
                    }

                    if (cbOvjereno.Checked)
                        temp.Ovjereno = "Da";
                    else if (!cbOvjereno.Checked)
                        temp.Ovjereno = "Ne";

                    await uplata_service.Insert(temp);
                    MessageBox.Show("Uspješno ste dodali novu uplatu");
                    this.Close();
                }
            }
        }

        private void cbEvidentirao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEvidentirao_Validating(object sender, CancelEventArgs e)
        {
            if (cbEvidentirao.SelectedValue == null)
            {
                errorProvider1.SetError(cbEvidentirao, "Morate odabrati polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbEvidentirao, null);
            }
        }

        private void cbUplatio_Validating(object sender, CancelEventArgs e)
        {
            if (cbUplatio.SelectedValue == null)
            {
                errorProvider1.SetError(cbUplatio, "Morate odabrati polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbUplatio, null);
            }
        }

        private void txtSvrha_Validating(object sender, CancelEventArgs e)
        {
            if (txtSvrha.Text=="")
            {
                errorProvider1.SetError(txtSvrha, "Morate odabrati polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtSvrha, null);
            }
        }

        private void txtIznos_Validating(object sender, CancelEventArgs e)
        {
            if (txtIznos.Text == "")
            {
                errorProvider1.SetError(txtIznos, "Morate odabrati polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIznos, null);
            }
        }
    }
}
