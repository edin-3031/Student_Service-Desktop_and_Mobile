using StudentskiServis.MobileApp.ViewModels;
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
    public partial class ObavijestDodajProf : ContentPage
    {
        private readonly ObavijestDodajProfVM model = null;
        public ObavijestDodajProf()
        {
            InitializeComponent();
        }   
        
        public ObavijestDodajProf(int userId, int role)
        {
            InitializeComponent();
            BindingContext = model = new ObavijestDodajProfVM(userId, role);
        }
    }
}