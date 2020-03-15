using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public class ULOGA : IUloga
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public List<Models.ULOGA> Get([FromQuery]UlogaSearchRequest request)
        {
            var query = db.Uloge.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Uloga))
            {
                query = query.Where(x => x.Naziv.Contains(request.Uloga));
            }

            var lista = query.ToList();

            List<Models.ULOGA> result = new List<Models.ULOGA>();

            foreach (var x in lista)
            {
                result.Add(new Models.ULOGA
                {
                    Naziv=x.Naziv,
                    UlogaId=x.UlogaId
                });
            }

            return result;
        }

        public Models.ULOGA GetById(int id)
        {
            Uloge uloga = db.Uloge.Where(q => q.UlogaId == id).FirstOrDefault();

            Models.ULOGA t=new Models.ULOGA{ 
                UlogaId=uloga.UlogaId,
                Naziv=uloga.Naziv
            };

            return t;
        }
    }
}
