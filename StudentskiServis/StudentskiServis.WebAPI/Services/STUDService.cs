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

    public class STUDService : ISTUDService
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public List<STUD> Get([FromQuery] PohadjanjaSearchRequest search)
        {
            var lista = db.Student.ToList();

            List<Models.STUD> result = new List<Models.STUD>();

            foreach (var x in lista)
            {
                result.Add(new Models.STUD
                {
                    StudentId = x.StudentId,
                    Ime = x.Ime + " " + x.Prezime + " - " + x.Indeks
                });
            }

            return result;
        }
    }
}
