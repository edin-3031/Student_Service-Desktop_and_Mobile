using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models
{
    public class obavijesti
    {
        public int ObavijestId { get; set; }
        public int? ProfesorID { get; set; }
        public string Naslov { get; set; }
        public DateTime DatumObjave { get; set; }
        public string Sadrzaj { get; set; }
        public string Objavio { get; set; }
    }
}
