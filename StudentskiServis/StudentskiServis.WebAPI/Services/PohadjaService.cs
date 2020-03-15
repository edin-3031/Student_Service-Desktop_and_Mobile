using AutoMapper;
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
    public class PohadjaService : IPohadjaService
    {

        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public List<Models.pohadjanja> Get([FromQuery]PohadjanjaSearchRequest search)    
        {
            var query = db.Set<Pohadja>().AsQueryable();

            if (search?.StudentId.HasValue == true)
            {
                query = query.Where(x => x.StudentId == search.StudentId);
            }

            query = query.OrderBy(x => x.Kurs.Naziv);

            var list = query.ToList();

            List<Models.pohadjanja> final = new List<Models.pohadjanja>();

            foreach(var x in list)
            {
                final.Add(new Models.pohadjanja
                {
                    Aktivan=x.Aktivan,
                    BrojObnavljanja=x.BrojObnavljanja,
                    KursId=x.KursId,
                    Naziv=db.Kurs.Where(y=>y.KursId==x.KursId).Select(t=>t.Naziv).FirstOrDefault(),
                    Obnavlja=x.Obnavlja,
                    PohadjaId=x.PohadjaId,
                    StudentId=x.StudentId,
                    Ocjena=x.Ocjena,
                    Polozio=x.Polozio,
                    DatumPolaganja=x.DatumPohadjanja
                });
            }
            return final;
        }

        public pohadjanja Insert(pohadjanja _novi)
        {
            var n = new Pohadja()
            {
                Aktivan = _novi.Aktivan,
                BrojObnavljanja = _novi.BrojObnavljanja,
                KursId = _novi.KursId,
                Obnavlja = _novi.Obnavlja,
                StudentId = _novi.StudentId,
                Polozio=_novi.Polozio,
                Ocjena=_novi.Ocjena,
            };

            db.Pohadja.Add(n);
            db.SaveChanges();

            return _novi;
        }

        public pohadjanja Update(int id, pohadjanja _novi)
        {
            var temp = db.Pohadja.Find(id);

            temp.KursId = _novi.KursId;
            temp.Obnavlja = _novi.Obnavlja;
            temp.Aktivan = _novi.Aktivan;
            temp.BrojObnavljanja = _novi.BrojObnavljanja;
            temp.Ocjena = _novi.Ocjena;
            temp.PohadjaId = _novi.PohadjaId;
            temp.Polozio = _novi.Polozio;
            temp.StudentId = _novi.StudentId;

            db.SaveChanges();

            return _novi;
        }

        public bool Delete(int id)
        {
            Pohadja temp = db.Pohadja.Find(id);
            if (temp != null)
            {
                db.Remove(temp);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public pohadjanja GetById(int id)
        {
            var temp = db.Pohadja.Find(id);

            Models.pohadjanja result = new pohadjanja
            {
                Aktivan = temp.Aktivan,
                BrojObnavljanja = temp.BrojObnavljanja,
                KursId = temp.KursId,
                Naziv = db.Kurs.Where(y => y.KursId == temp.KursId).Select(t => t.Naziv).FirstOrDefault(),
                Obnavlja = temp.Obnavlja,
                Ocjena = temp.Ocjena,
                PohadjaId = temp.PohadjaId,
                Polozio = temp.Polozio,
                StudentId = temp.StudentId,
                DatumPolaganja=temp.DatumPohadjanja
            };

            return result;
        }
    }
}
