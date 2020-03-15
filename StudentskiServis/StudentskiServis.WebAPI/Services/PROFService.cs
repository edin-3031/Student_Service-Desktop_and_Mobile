using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public class PROFService : IPROFService
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public List<PROF> Get([FromQuery] ProfesorSearchRequest search)
        {
            var lista = db.Profesor.ToList();

            List<Models.PROF> result = new List<Models.PROF>();

            foreach (var x in lista)
            {
                result.Add(new Models.PROF
                {
                    ProfesorId = x.ProfesorId,
                    Ime = x.Zvanje + " " + x.Ime + " " + x.Prezime
                });
            }

            return result;
        }
    }
}
