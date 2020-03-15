using System;
using System.Collections.Generic;

namespace StudentskiServis.WebAPI.Database
{
    public partial class Obavijest
    {
        public int ObavijestId { get; set; }
        public int? ProfesorId { get; set; }
        public string Sadrzaj { get; set; }
        public DateTime? DatumObjave { get; set; }
        public string Naslov { get; set; }

        public Profesor Profesor { get; set; }
    }
}
