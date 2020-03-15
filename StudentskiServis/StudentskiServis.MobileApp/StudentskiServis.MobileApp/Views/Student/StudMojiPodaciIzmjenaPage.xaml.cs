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
    public partial class StudMojiPodaciIzmjenaPage : ContentPage
    {
        private readonly StudMojiPodaciIzmjenaVM model = null;
        public StudMojiPodaciIzmjenaPage()
        {
            InitializeComponent();
        }
        
        public StudMojiPodaciIzmjenaPage(int userId, int role, StudentAdmin t)
        {
            BindingContext = model = new StudMojiPodaciIzmjenaVM(userId,role,t);

            InitializeComponent();
        }
    }
}