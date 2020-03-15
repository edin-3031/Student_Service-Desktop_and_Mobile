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
    public partial class StudPage : ContentPage
    {
        private readonly StudVM model = null;

        public StudPage()
        {
            InitializeComponent();

        }

        public StudPage(int _role, int _studId)
        {
            InitializeComponent();

            BindingContext = model = new StudVM(_studId,_role);
            model.UserID = _studId;
            model.Role = _role;
        }
    }
}