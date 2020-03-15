using System;
using System.Collections.Generic;

namespace StudentskiServis.WebAPI.Database
{
    public partial class KorisniciUloge
    {
        public int KorisnikUlogaId { get; set; }
        public int? ProfesorId { get; set; }
        public int? StudentId { get; set; }
        public int? AdministracijaId { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public int? UlogaId { get; set; }

        public Administracija Administracija { get; set; }
        public Profesor Profesor { get; set; }
        public Student Student { get; set; }
        public Uloge Uloga { get; set; }
    }
}
