using System;
using System.Collections.Generic;

namespace StudentskiServis.WebAPI.Database
{
    public partial class Pohadja
    {
        public int PohadjaId { get; set; }
        public int? StudentId { get; set; }
        public int? KursId { get; set; }
        public string Obnavlja { get; set; }
        public int? BrojObnavljanja { get; set; }
        public string Aktivan { get; set; }
        public string Polozio { get; set; }
        public int? Ocjena { get; set; }
        public DateTime? DatumPohadjanja{ get; set; }

        public Kurs Kurs { get; set; }
        public Student Student { get; set; }
    }
}
