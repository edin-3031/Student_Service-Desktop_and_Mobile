using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiServis.Models.Requests
{
    public class TragajRequest
    {
        public DateTime OD { get; set; }
        public DateTime DO { get; set; }
        public int KursId { get; set; }
    }
}
