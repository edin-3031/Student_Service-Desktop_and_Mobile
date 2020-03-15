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
    public partial class ProfPage : ContentPage
    {

        int role, profId;
        private readonly ProfVM model = null;
        public ProfPage()
        {
            InitializeComponent();

        }
        
        public ProfPage(int _profId, int _role)
        {
            InitializeComponent();

            role = _role;
            profId = _profId;

            BindingContext = model = new ProfVM(_role, _profId);
            model._profId = profId;
            model._role = _role;
        }
    }
}