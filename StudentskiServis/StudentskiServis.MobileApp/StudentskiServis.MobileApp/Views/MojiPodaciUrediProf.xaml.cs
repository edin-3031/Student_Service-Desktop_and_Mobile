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
    public partial class MojiPodaciUrediProf : ContentPage
    {
        private readonly MojiPodaciUrediProfVM model = null;
        public MojiPodaciUrediProf()
        {
            InitializeComponent();
        }
        
        public MojiPodaciUrediProf(int id, int role, ProfesorAdmin podaci)
        {
            InitializeComponent();
            BindingContext = model = new MojiPodaciUrediProfVM(id,role,podaci);
            model.Uredi(id, role, podaci);
        }
    }
}