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
    public partial class AdminPage : ContentPage
    {
        private readonly APIService _service = new APIService("Administracija");

        private readonly AdminVM model = null;

        int role, adminId;
        public AdminPage()
        {
            InitializeComponent();
            
        }
        public AdminPage(int _role, int _adminId)
        {
            InitializeComponent();
            role = _role;
            adminId = _adminId;

            BindingContext = model = new AdminVM(_adminId, role);
        }
    }
}