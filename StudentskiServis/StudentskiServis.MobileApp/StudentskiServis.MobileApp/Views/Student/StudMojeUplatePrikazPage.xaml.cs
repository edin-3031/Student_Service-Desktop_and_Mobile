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
    public partial class StudMojeUplatePrikazPage : ContentPage
    {
        private readonly StudMojeUplatePrikazVM model = null;
        public StudMojeUplatePrikazPage()
        {
            InitializeComponent();
        }
        int _userid, _role;
        public StudMojeUplatePrikazPage(int userId, int role, List<uplate> lista)
        {
            BindingContext = model = new StudMojeUplatePrikazVM(userId, role, lista);
            InitializeComponent();
            model.Load(userId, role,lista);
            _userid = userId;
            _role = role;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            uplate v = (uplate)e.SelectedItem;

            Application.Current.MainPage = new StudMojeUplateDetaljiPage(_userid, _role, v); 
        }
    }
}