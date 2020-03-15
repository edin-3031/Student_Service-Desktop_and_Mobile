using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models
{
    public class StudentAdmin
    {
        public int StudentID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Indeks { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public DateTime? DatumUpisa { get; set; }
        public string Mail { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Spol { get; set; }
        public string Status { get; set; }
        public string NacinStudiranja { get; set; }
        public int? UpisanSemestar { get; set; }
        public int? OvjerenSemestar { get; set; }
        public string ObnavljaGodinu { get; set; }
        public double? ProsjecnaOcjena { get; set; }
        public byte[] Slika { get; set; }
    }
}
