using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models
{
    public class ProfesorAll
    {
        public int ProfesorId { get; set; }
        public int? KorisnickiNalogId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Zvanje { get; set; }
        public string Mail { get; set; }
        public string Kancelarija { get; set; }
        public byte[] Slika { get; set; }
    }
}
