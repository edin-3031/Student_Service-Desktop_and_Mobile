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
    public partial class frmIzmjenaUplata : Form
    {
        int? _id = null;

        APIService stud_service = new APIService("STUD");
        APIService admin_service = new APIService("ADMIN");
        APIService uplata_service = new APIService("Uplata");

        public frmIzmjenaUplata(int id)
        {
            InitializeComponent();

            _id = id;
        }

        private async void frmIzmjenaUplata_Load(object sender, EventArgs e)
        {
            await LoadStud();
            await LoadAdmin();

            Models.uplate postojeci = await uplata_service.GetById<Models.uplate>(_id);

            txtSvrha.Text = postojeci.Svrha;
            txtIznos.Text = postojeci.Iznos.ToString();
            datUplate.Value = postojeci.DatumUplate.Value;
            if (postojeci.Ovjereno == "Da" || postojeci.Ovjereno == "da" || postojeci.Ovjereno == "DA")
                cbOvjereno.Checked = true;
            else if(postojeci.Ovjereno == "Ne" || postojeci.Ovjereno == "ne" || postojeci.Ovjereno == "NE")
                cbOvjereno.Checked = false;
            if (postojeci.Slika == null)
                picUplata.Image = Properties.Resources.No_Picture;
            else if (postojeci.Slika != null)
                picUplata.Image = (Bitmap)(new ImageConverter().ConvertFrom(postojeci.Slika));

        }

        private async Task LoadStud()
        {
            Models.uplate postojeci = await uplata_service.GetById<Models.uplate>(_id);

            var result=await stud_service.Get<List<Models.STUD>>(null);
            result.Insert(0, new Models.STUD
            {
                Ime=postojeci.Uplatio,
                StudentId=postojeci.StudentId.Value
            });


            cbUplatio.DataSource = result;
            cbUplatio.DisplayMember = "Ime";
            cbUplatio.ValueMember= "StudentId";
        }

        private async Task LoadAdmin()
        {
            Models.uplate postojeci = await uplata_service.GetById<Models.uplate>(_id);

            var temp = await admin_service.Get<List<Models.ADMIN>>(null);

            temp.Insert(0, new Models.ADMIN
            {
                AdministracijaId=postojeci.AdministracijaId.Value,
                Ime=postojeci.Evidentirao
            });

            cbEvidentirao.DataSource = temp;
            cbEvidentirao.DisplayMember = "Ime";
            cbEvidentirao.ValueMember = "AdministracijaId";
        }

        private async void btnSlika_Click(object sender, EventArgs e)
        {
            var uplata = await uplata_service.GetById<Models.uplate>(_id);

            var result = ofdUplata.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = ofdUplata.FileName;

                var file = File.ReadAllBytes(fileName);

                //Da se prikaže slika u picture box
                Image image = Image.FromFile(fileName);
                picUplata.Image = image;
            }
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Models.uplate temp = new Models.uplate
            {
                DatumUplate=datUplate.Value,
                Iznos=float.Parse(txtIznos.Text),
                Slika=imageToByteArray(picUplata.Image),
                Svrha=txtSvrha.Text
            };
            if (cbOvjereno.Checked)
                temp.Ovjereno = "Da";
            else if (!cbOvjereno.Checked)
                temp.Ovjereno = "Ne";

            int id_Admin;
            bool v = int.TryParse(cbEvidentirao.SelectedValue.ToString(), out id_Admin);
            temp.AdministracijaId = id_Admin;

            int id_Stud;
            bool v2 = int.TryParse(cbUplatio.SelectedValue.ToString(), out id_Stud);
            temp.StudentId = id_Stud;


            await uplata_service.Update<Models.uplate>(_id,temp);
            MessageBox.Show("Uspješno ste izmijenili odabranu uplatu");
            this.Close();
        }
    }
}
