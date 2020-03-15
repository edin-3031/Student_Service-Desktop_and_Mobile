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
    public partial class ObavijestiPage : ContentPage
    {
        private readonly APIService _service = new APIService("Obavijest");
        ObavijestiPrikazVM model = null;
        int user_id, _role;
        public ObavijestiPage(List<obavijesti> lista, int profId, int role)
        {
            InitializeComponent();
            BindingContext = model = new ObavijestiPrikazVM(lista, profId, role);
            model.Nazad(profId, role);
            user_id = profId;
            _role = role;
        }

        public obavijesti temp { get; set; } = new obavijesti();
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var t = (obavijesti)e.SelectedItem;
            temp=await _service.GetById<obavijesti>(t.ObavijestId);
            

            model.Objavio = temp.Objavio;
            model.Datum = temp.DatumObjave;
            model.Naslov = temp.Naslov;
            model.Sadrzaj = temp.Sadrzaj;
            model.ObavijestId = temp.ObavijestId;
            model.ProfesorID = temp.ProfesorID;

            model.LoadNotification(user_id, _role, temp);

        }
    }
}