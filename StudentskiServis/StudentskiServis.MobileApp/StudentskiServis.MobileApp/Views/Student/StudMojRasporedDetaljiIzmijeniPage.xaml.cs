using StudentskiServis.MobileApp.ViewModels.Student;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StudentskiServis.MobileApp.Views.Student
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudMojRasporedDetaljiIzmijeniPage : ContentPage
    {
        private readonly StudMojRasporedDetaljiIzmijeniVM model = null;

        public StudMojRasporedDetaljiIzmijeniPage()
        {
            InitializeComponent();
        }
        
        public StudMojRasporedDetaljiIzmijeniPage(int userId, int role, Raspored raspored)
        {
            BindingContext = model = new StudMojRasporedDetaljiIzmijeniVM(userId,role,raspored);

            InitializeComponent();
        }
    }
}