﻿using StudentskiServis.MobileApp.Views.Student;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StudentskiServis.MobileApp.ViewModels.Student
{
    public class StudProfDetaljiVM:BaseViewModel
    {
        private readonly APIService _service = new APIService("Profesor");
        public StudProfDetaljiVM()
        {

        }

        public StudProfDetaljiVM(int userId, int role, ProfesorAll t)
        {
            Slika= ImageSource.FromStream(() => new MemoryStream(t.Slika));
            UserID = userId;
            Role = role;
            Ime = t.Ime;
            Prezime = t.Prezime;
            Zvanje = t.Zvanje;
            Kancelarija = t.Kancelarija;
            Mail = t.Mail;

            NazadCommand = new Command(async() =>
            {
                List<ProfesorAll> temp = await _service.Get<List<ProfesorAll>>(null);
                Application.Current.MainPage = new StudProfPrikazPage(userId, role, temp);
            });
        }

        public ICommand NazadCommand { get; set; }

        int _userId;
        public int UserID { get { return _userId; } set { SetProperty(ref _userId, value); } }
        int _role;
        public int Role { get { return _role; } set { SetProperty(ref _role, value); } }
        string _ime;
        public string Ime { get { return _ime; } set { SetProperty(ref _ime, value); } }
        string _prezime;
        public string Prezime { get { return _prezime; } set { SetProperty(ref _prezime, value); } }
        string _zvanje;
        public string Zvanje { get { return _zvanje; } set { SetProperty(ref _zvanje, value); } }
        string _kancelarija;
        public string Kancelarija { get { return _kancelarija; } set { SetProperty(ref _kancelarija, value); } }
        string _mail;
        public string Mail { get { return _mail; } set { SetProperty(ref _mail, value); } }
        ImageSource _slika;
        public ImageSource Slika { get { return _slika; } set { SetProperty(ref _slika, value); } }
    }
}
