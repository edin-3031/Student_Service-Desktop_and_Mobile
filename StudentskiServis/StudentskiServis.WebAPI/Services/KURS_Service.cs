using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{

    public class KURS_Service : IKURS_Service
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public List<Models.KURS_> Get([FromQuery]object search)
        {
            var lista = db.Kurs.ToList();

            List<Models.KURS_> result = new List<Models.KURS_>();

            foreach (var x in lista)
            {
                result.Add(new Models.KURS_
                {
                    KursId = x.KursId,
                    Naziv = x.Naziv
                });
            }

            return result;
        }
    }
}
