using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models
{
    public class Obavijest
    {
        public int ObavijestId { get; set; }
        public int? ProfesorId { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime? DatumObjave { get; set; }
        public string Naslov { get; set; }
    }
}
