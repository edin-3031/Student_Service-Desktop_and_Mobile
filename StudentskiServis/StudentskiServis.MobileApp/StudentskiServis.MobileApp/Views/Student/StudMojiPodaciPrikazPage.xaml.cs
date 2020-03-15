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
    public partial class StudMojiPodaciPrikazPage : ContentPage
    {
        private readonly StudMojiPodaciPrikazVM model = null;
        public StudMojiPodaciPrikazPage()
        {
            InitializeComponent();
        }
        public StudMojiPodaciPrikazPage(StudentAdmin podatak, int userId, int role)
        {
            BindingContext = model = new StudMojiPodaciPrikazVM(userId, role, podatak);
            InitializeComponent();
            //model.LoadData(userId, role, podatak);
        }
    }
}