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
    public partial class ObavijestIzmijeniProf : ContentPage
    {

        private readonly ObavijestIzmijeniProfVM model = null;
        public ObavijestIzmijeniProf()
        {
            InitializeComponent();
        }
        
        public ObavijestIzmijeniProf(int userId, int role, int obavijestId, int? objavioId)
        {
            InitializeComponent();
            BindingContext = model = new ObavijestIzmijeniProfVM(userId, role, obavijestId, objavioId);
            model.LoadData(userId, role, obavijestId, objavioId);
        }
    }
}