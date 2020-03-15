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
    public partial class StudMojeUplateDetaljiPage : ContentPage
    {
        private readonly StudMojeUplateDetaljiVM model = null;
        public StudMojeUplateDetaljiPage()
        {
            InitializeComponent();
        }
        
        public StudMojeUplateDetaljiPage(int _userid, int _role, uplate v)
        {
            BindingContext = model = new StudMojeUplateDetaljiVM(_userid, _role, v);
            InitializeComponent();
        }
    }
}