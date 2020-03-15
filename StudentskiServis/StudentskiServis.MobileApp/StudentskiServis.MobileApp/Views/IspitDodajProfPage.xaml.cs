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
    public partial class IspitDodajProfPage : ContentPage
    {
        IspitDodajProfVM model = null;
        public IspitDodajProfPage()
        {
            InitializeComponent();
        }

        public IspitDodajProfPage(int id, int role)
        {
            InitializeComponent();
            BindingContext = model = new IspitDodajProfVM(id,role);
            
        }
        public string _checked="Ne";
        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value == true)
            {
                _checked = "Da";
                model.Parcijalno = _checked;
            }
            else if (e.Value == false)
            {
                _checked = "Ne";
                model.Parcijalno = _checked;
            }
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            var selectedItem = picker.SelectedItem;
            model.KursID = (int)selectedItem;
        }
    }
}