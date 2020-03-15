using System;
using System.Collections.Generic;

namespace StudentskiServis.WebAPI.Database
{
    public partial class Uplata
    {
        public int UplataId { get; set; }
        public int? AdministracijaId { get; set; }
        public int? StudentId { get; set; }
        public double? Iznos { get; set; }
        public string Svrha { get; set; }
        public DateTime? DatumUplate { get; set; }
        public string Ovjereno { get; set; }
        public byte[] Slika { get; set; }

        public Administracija Administracija { get; set; }
        public Student Student { get; set; }
    }
}
