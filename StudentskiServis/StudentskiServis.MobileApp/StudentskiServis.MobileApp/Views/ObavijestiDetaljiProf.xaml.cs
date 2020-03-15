using StudentskiServis.MobileApp.ViewModels;
using StudentskiServis.Models;
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
    public partial class ObavijestiDetaljiProf : ContentPage
    {
    private readonly ObavijestiDetaljiProfVM model = null;
        public ObavijestiDetaljiProf()
        {
            InitializeComponent();
        }

        public ObavijestiDetaljiProf(int userId, int role, obavijesti temp)
        {
            InitializeComponent();
            BindingContext = model = new ObavijestiDetaljiProfVM(userId, role, temp);
        }
    }
}