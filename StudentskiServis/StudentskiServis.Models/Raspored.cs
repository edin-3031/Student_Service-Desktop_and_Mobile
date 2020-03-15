using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models
{
    public class Raspored
    {
        public int RasporedId { get; set; }
        public int? StudentId { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public DateTime? Datum { get; set; }
        public string Vazno { get; set; }
    }
}
