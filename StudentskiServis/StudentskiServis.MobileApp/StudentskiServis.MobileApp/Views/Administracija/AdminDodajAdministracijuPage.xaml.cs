using Plugin.Media;
using Plugin.Media.Abstractions;
using StudentskiServis.MobileApp.ViewModels.Administracija;
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
    public partial class AdminDodajAdministracijuPage : ContentPage
    {
        private readonly AdminDodajAdministracijuVM model = null;

        private MediaFile _mediaFile;

        public AdminDodajAdministracijuPage()
        {
            InitializeComponent();
        }

        public AdminDodajAdministracijuPage(int role, int userId)
        {
            BindingContext = model = new AdminDodajAdministracijuVM(role, userId);

            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = sender as Picker;
            var selectedItem = picker.SelectedItem;

            if (selectedItem == "Muško")
                model.Spol = "M";
            else if (selectedItem == "Žensko")
                model.Spol = "Ž";

        }

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    await CrossMedia.Current.Initialize();

        //    if (!CrossMedia.Current.IsPickPhotoSupported)
        //    {
        //        await DisplayAlert("Greška", "Greška", "OK");
        //        return;
        //    }
        //    _mediaFile = await CrossMedia.Current.PickPhotoAsync();

        //    if (_mediaFile == null)
        //    {
        //        return;
        //    }

        //    //LocalPathLabel.Text = _mediaFile.Path;

        //    FileImage.Source = ImageSource.FromStream(() =>
        //    {
                
        //        return _mediaFile.GetStream();
        //    });
        //}
    }
}