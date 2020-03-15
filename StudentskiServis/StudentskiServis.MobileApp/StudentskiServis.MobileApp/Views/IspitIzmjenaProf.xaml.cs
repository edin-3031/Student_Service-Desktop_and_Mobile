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
    public partial class IspitIzmjenaProf : ContentPage
    {
        private IspitIzmjenaProfVM model = null;

        public IspitIzmjenaProf(int userId, int role, ispiti podaci, int ispitId)
        {
            InitializeComponent();
            BindingContext = model = new IspitIzmjenaProfVM(userId, role, ispitId, podaci);
            model.LoadPodatke(userId, role, ispitId, podaci);
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            model.Parcijalno = e.Value;
        }
    }
}