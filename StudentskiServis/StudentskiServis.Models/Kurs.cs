using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models
{
    public class Kurs
    {
        public int KursId { get; set; }
        public string Naziv { get; set; }
        public int? Ects { get; set; }
        public string PosjedujeSeminarski { get; set; }
        public string PosjedujePraksu { get; set; }
    }
}
