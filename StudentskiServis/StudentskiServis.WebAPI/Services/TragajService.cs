using Microsoft.AspNetCore.Mvc;
using StudentskiServis.MobileApp;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public class TragajService : ITragajService
    {
        private readonly APIService _service = new APIService("Tragaj");
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public List<KoPohadja> Get([FromQuery] TragajRequest request)
        {

            var query = db.Pohadja.AsQueryable();

            if (request.DO!=null)
            {
                query = query.Where(x => x.DatumPohadjanja.Value.Year >= request.OD.Year && x.DatumPohadjanja.Value.Month >= request.OD.Month && x.DatumPohadjanja.Value.Day >= request.OD.Day);
            }
            
            if (request.OD!=null)
            {
                query = query.Where(x => x.DatumPohadjanja.Value.Year <= request.DO.Year && x.DatumPohadjanja.Value.Month <= request.DO.Month && x.DatumPohadjanja.Value.Day <= request.DO.Day);
            }
            
            if (request.KursId>0)
            {
                query = query.Where(x => x.KursId==request.KursId);
            }

            var lista = query.ToList();
            
            List<KoPohadja> result = new List<KoPohadja>();

            foreach (var x in lista)
            {
                if (x.Polozio == "Da" && x.Ocjena > 5)
                {
                    result.Add(new Models.KoPohadja
                    {
                        Ime = db.Student.Where(a => a.StudentId == x.StudentId).Select(o => o.Ime).FirstOrDefault(),
                        Prezime = db.Student.Where(a => a.StudentId == x.StudentId).Select(o => o.Prezime).FirstOrDefault(),
                        Ocjena = x.Ocjena
                    });
                }
            }

            return result;
        }
    }
}
