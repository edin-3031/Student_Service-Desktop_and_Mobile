using StudentskiServis.MobileApp.Views.Student;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    public class StudMojeUplateDetaljiVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Uplata");

        public StudMojeUplateDetaljiVM()
        {

        }
        public StudMojeUplateDetaljiVM(int _userid, int _role, uplate v)
        {
            NazadCmd = new Command( async() =>
            {
                List<uplate> source = await _service.Get<List<uplate>>(null);
                List<uplate> lista = new List<uplate>();

                foreach(var x in source)
                {
                    if (x.StudentId == _userid)
                    {
                        lista.Add(new uplate
                        {
                            AdministracijaId=x.AdministracijaId,
                            DatumUplate=x.DatumUplate,
                            StudentId=x.StudentId,
                            Evidentirao=x.Evidentirao,
                            Iznos=x.Iznos,
                            Ovjereno=x.Ovjereno,
                            Slika=x.Slika,
                            Svrha=x.Svrha,
                            UplataId=x.UplataId,
                            Uplatio=x.Uplatio
                        });
                    }
                }

                Application.Current.MainPage = new StudMojeUplatePrikazPage(_userid, _role, lista);
            });

            Iznos = v.Iznos.ToString();
            Svrha = v.Svrha;
            if (v.Ovjereno == "Da")
                Ovjereno = true;
            Datum = v.DatumUplate.Value;
            Evidentirao = v.Evidentirao;
        }

        public ICommand NazadCmd { get; set; }

        string _iznos;
        public string Iznos { get { return _iznos; } set { SetProperty(ref _iznos, value); } }

        string _svrha;
        public string Svrha { get { return _svrha; } set { SetProperty(ref _svrha, value); } }

        bool _ovjereno=false;
        public bool Ovjereno { get { return _ovjereno; } set { SetProperty(ref _ovjereno, value); } }

        DateTime _datum;
        public DateTime Datum { get { return _datum; } set { SetProperty(ref _datum, value); } }

        string _evidentirao;
        public string Evidentirao { get { return _evidentirao; } set { SetProperty(ref _evidentirao, value); } }


    }
}
