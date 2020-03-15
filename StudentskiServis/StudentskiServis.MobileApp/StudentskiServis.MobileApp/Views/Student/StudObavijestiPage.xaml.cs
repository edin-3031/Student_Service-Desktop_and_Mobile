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
    public partial class StudObavijestiPage : ContentPage
    {
        private StudObavijestiVM model = null;

        public StudObavijestiPage()
        {
            InitializeComponent();
        }

        public StudObavijestiPage(int userId, int role, List<obavijesti>listaObavijesti)
        {
            BindingContext = model = new StudObavijestiVM(userId,role,listaObavijesti);
            model.Role = role;
            model.UserID = userId;
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            obavijesti temp = (obavijesti)e.SelectedItem;
            Application.Current.MainPage = new StudObavijestiDetaljiPage(model.UserID, model.Role, temp);
        }
    }
}