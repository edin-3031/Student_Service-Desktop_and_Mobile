using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models
{
    public class pohadja
    {
        public int PohadjaId { get; set; }
        public int? StudentId { get; set; }
        public int? KursId { get; set; }
        public string Obnavlja { get; set; }
        public int? BrojObnavljanja { get; set; }
        public string Aktivan { get; set; }
        public string Polozio { get; set; }
        public int? Ocjena { get; set; }
        public DateTime? DatumPolaganja{ get; set; }
    }
}
