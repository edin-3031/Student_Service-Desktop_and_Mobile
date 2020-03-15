using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentskiServis.Models.Requests
{
    public class AdministracijaInsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PasswordConfirmation { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public DateTime? DatumZaposlenja { get; set; }
        public string Adresa { get; set; }
        public string Mail { get; set; }
        [MaxLength(1)]
        public string Spol { get; set; }
        public int? Staz { get; set; }
        public string VrstaUgovora { get; set; }
        public string Kancelarija { get; set; }
        [Required]
        public byte[] Slika { get; set; }
    }
}
