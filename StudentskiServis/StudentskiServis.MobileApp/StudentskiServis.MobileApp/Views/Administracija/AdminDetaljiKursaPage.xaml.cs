using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentskiServis.MobileApp.Views.Administracija
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminDetaljiKursaPage : ContentPage
    {
        private readonly AdminDetaljiKursaVM model = null;

        public AdminDetaljiKursaPage()
        {
            InitializeComponent();
        }

        public AdminDetaljiKursaPage(int userId, int role, kursevi t)
        {
            BindingContext = model = new AdminDetaljiKursaVM(userId, role, t);

            InitializeComponent();
        }
    }
}