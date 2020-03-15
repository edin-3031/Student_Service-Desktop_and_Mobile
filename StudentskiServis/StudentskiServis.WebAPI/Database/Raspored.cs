using System;
using System.Collections.Generic;

namespace StudentskiServis.WebAPI.Database
{
    public partial class Raspored
    {
        public int RasporedId { get; set; }
        public int? StudentId { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public DateTime? Datum { get; set; }
        public string Vazno { get; set; }

        public Student Student { get; set; }
    }
}
