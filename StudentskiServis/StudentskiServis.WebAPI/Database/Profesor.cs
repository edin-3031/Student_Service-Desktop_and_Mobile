using System;
using System.Collections.Generic;

namespace StudentskiServis.WebAPI.Database
{
    public partial class Profesor
    {
        public Profesor()
        {
            Ispit = new HashSet<Ispit>();
            KorisniciUloge = new HashSet<KorisniciUloge>();
            Obavijest = new HashSet<Obavijest>();
            Predaje = new HashSet<Predaje>();
        }

        public int ProfesorId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Zvanje { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public DateTime? DatumZaposlenja { get; set; }
        public string Adresa { get; set; }
        public string Mail { get; set; }
        public string Spol { get; set; }
        public int? Staz { get; set; }
        public string VrstaUgovora { get; set; }
        public string Kancelarija { get; set; }
        public byte[] Slika { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public ICollection<Ispit> Ispit { get; set; }
        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public ICollection<Obavijest> Obavijest { get; set; }
        public ICollection<Predaje> Predaje { get; set; }
    }
}
