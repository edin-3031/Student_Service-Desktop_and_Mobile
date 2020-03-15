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
    public partial class StudMojiIspitiPrikazPage : ContentPage
    {
        private readonly StudMojiIspitiPrikazVM model = null;
        public StudMojiIspitiPrikazPage()
        {
            //InitializeComponent();
        }
        
        public StudMojiIspitiPrikazPage(int userId, int role, List<ispiti>listaIspita)
        {
            InitializeComponent();
            BindingContext = model = new StudMojiIspitiPrikazVM(userId, role, listaIspita);
            
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ispiti temp = (ispiti)e.SelectedItem;

            Application.Current.MainPage = new StudMojiispitiDetaljiPage(temp,model.UserID, model.Role);
        }
    }
}