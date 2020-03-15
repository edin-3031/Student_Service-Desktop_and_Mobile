using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models
{
    public class uplate
    {
        public int UplataId { get; set; }
        public double? Iznos { get; set; }
        public string Svrha { get; set; }
        public string Ovjereno { get; set; }
        public byte[] Slika { get; set; }
        public DateTime? DatumUplate { get; set; }
        public int? AdministracijaId { get; set; }
        public int? StudentId { get; set; }
        public string Evidentirao { get; set; }
        public string Uplatio { get; set; }
    }
}
