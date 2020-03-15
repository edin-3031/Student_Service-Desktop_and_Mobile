using StudentskiServis.MobileApp.ViewModels;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentskiServis.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrikazKoPolazePage : ContentPage
    {
        private readonly PrikazKoPolazeVM model = null;

        public PrikazKoPolazePage(int userId, int role, List<KoPohadja> lista)
        {
            InitializeComponent();
            BindingContext = model = new PrikazKoPolazeVM(userId, role, lista);

        }

        public PrikazKoPolazePage()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Picker_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;

            model.IzabraniKurs = (KURS_)picker.SelectedItem;
        }
    }
}