using System;
using System.Collections.Generic;

namespace StudentskiServis.WebAPI.Database
{
    public partial class Kurs
    {
        public Kurs()
        {
            Ispit = new HashSet<Ispit>();
            Pohadja = new HashSet<Pohadja>();
            Predaje = new HashSet<Predaje>();
        }

        public int KursId { get; set; }
        public string Naziv { get; set; }
        public int? Ects { get; set; }
        public string PosjedujeSeminarski { get; set; }
        public string PosjedujePraksu { get; set; }

        public ICollection<Ispit> Ispit { get; set; }
        public ICollection<Pohadja> Pohadja { get; set; }
        public ICollection<Predaje> Predaje { get; set; }
    }
}
