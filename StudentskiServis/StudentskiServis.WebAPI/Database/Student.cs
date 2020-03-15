using System;
using System.Collections.Generic;

namespace StudentskiServis.WebAPI.Database
{
    public partial class Student
    {
        public Student()
        {
            KorisniciUloge = new HashSet<KorisniciUloge>();
            Pohadja = new HashSet<Pohadja>();
            Raspored = new HashSet<Raspored>();
            Uplata = new HashSet<Uplata>();
        }

        public int StudentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public DateTime? DatumUpisa { get; set; }
        public string Mail { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Spol { get; set; }
        public string Indeks { get; set; }
        public string Status { get; set; }
        public string NacinStudiranja { get; set; }
        public int? UpisanSemestar { get; set; }
        public int? OvjerenSemestar { get; set; }
        public string ObnavljaGodinu { get; set; }
        public double? ProsjecnaOcjena { get; set; }
        public byte[] Slika { get; set; }

        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public ICollection<Pohadja> Pohadja { get; set; }
        public ICollection<Raspored> Raspored { get; set; }
        public ICollection<Uplata> Uplata { get; set; }
    }
}
