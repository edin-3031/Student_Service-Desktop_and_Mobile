using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentskiServis.Models
{
    public class AdministracijaAll
    {
        public int AdministracijaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Mail { get; set; }
        public string Kancelarija { get; set; }
        public byte[] Slika { get; set; }
    }
}
