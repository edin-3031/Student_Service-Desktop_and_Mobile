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
    public partial class KoPohadjaPage : ContentPage
    {
        private readonly KoPohadjaVM model = null;

        public KoPohadjaPage()
        {
            InitializeComponent();
        }

        public KoPohadjaPage(int userId, int role)
        {
            BindingContext = model = new KoPohadjaVM(userId, role);
            model.LoadKurseve();
            InitializeComponent();

        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;

            model.IzabraniKurs =(KURS_)picker.SelectedItem;
        }
    }
}