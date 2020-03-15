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
    public partial class MojiPodaciProfPage : ContentPage
    {
        int _profId;
        int _role;
        private readonly MojiPodaciProfVM model = null;
        public MojiPodaciProfPage(int ProfId, int role)
        {
            InitializeComponent();
            _profId = ProfId;
            _role = role;
            BindingContext = model = new MojiPodaciProfVM(ProfId,role);
            model.LoadData(ProfId, role);

        }
        public MojiPodaciProfPage()
        {
            InitializeComponent();
        }
    }
}