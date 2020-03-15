using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public DateTime? DatumUpisa { get; set; }
        public string Mail { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Spol { get; set; }
        public string Indeks { get; set; }

    }
}
