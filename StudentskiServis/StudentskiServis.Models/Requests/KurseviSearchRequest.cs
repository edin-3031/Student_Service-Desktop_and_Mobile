using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models.Requests
{
    public class KurseviSearchRequest
    {
        public int? KursId { get; set; }
        public string Naziv { get; set; }
    }
}
