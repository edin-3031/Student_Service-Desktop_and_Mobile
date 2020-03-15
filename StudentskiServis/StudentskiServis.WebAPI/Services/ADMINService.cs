using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public class ADMINService : IADMINService
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public List<ADMIN> Get([FromQuery] object search)
        {
            var lista = db.Administracija.ToList();

            List<Models.ADMIN> result = new List<Models.ADMIN>();

            foreach (var x in lista)
            {
                result.Add(new Models.ADMIN
                {
                    AdministracijaId = x.AdministracijaId,
                    Ime = x.Ime + " " + x.Prezime
                });
            }

            return result;
        }
    }
}
