using System;
using System.Collections.Generic;

namespace StudentskiServis.WebAPI.Database
{
    public partial class Administracija
    {
        public Administracija()
        {
            KorisniciUloge = new HashSet<KorisniciUloge>();
            Uplata = new HashSet<Uplata>();
        }

        public int AdministracijaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public DateTime? DatumZaposlenja { get; set; }
        public string Adresa { get; set; }
        public string Mail { get; set; }
        public string Spol { get; set; }
        public int? Staz { get; set; }
        public string VrstaUgovora { get; set; }
        public string Kancelarija { get; set; }
        public byte[] Slika { get; set; }

        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public ICollection<Uplata> Uplata { get; set; }
    }
}
