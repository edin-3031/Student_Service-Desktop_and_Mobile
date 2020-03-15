using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models
{
    public class Ispit
    {
        public int IspitId { get; set; }
        public int? ProfesorId { get; set; }
        public int? KursId { get; set; }
        public DateTime? Datum { get; set; }
        public int? Trajanje { get; set; }
        public int? BrojPitanja { get; set; }
        public int? MaxBodova { get; set; }
        public string ParcijalnoBodovanje { get; set; }
        public string Ucionica { get; set; }
    }
}
