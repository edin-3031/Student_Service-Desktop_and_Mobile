using System;
using System.Collections.Generic;

namespace StudentskiServis.WebAPI.Database
{
    public partial class Predaje
    {
        public int PredajeId { get; set; }
        public int? ProfesorId { get; set; }
        public int? KursId { get; set; }
        public DateTime? DatumPredavanja { get; set; }
        public string Odrzano { get; set; }
        public string Vrsta { get; set; }
        public string Opis { get; set; }

        public Kurs Kurs { get; set; }
        public Profesor Profesor { get; set; }
    }
}
