using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models.Requests
{
    public class StudentSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Indeks { get; set; }
    }
}
