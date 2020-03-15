using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models
{
    public class predavanja
    {
        public int PredajeId { get; set; }
        public int? ProfesorId { get; set; }
        public int? KursId { get; set; }
        public DateTime? DatumPredavanja { get; set; }
        public string Odrzano { get; set; }
        public string Vrsta { get; set; }
        public string Opis { get; set; }
        public string Naziv { get; set; }
    }
}
