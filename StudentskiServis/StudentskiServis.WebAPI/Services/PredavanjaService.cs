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
    public class PredavanjaService : IPredavanjaService
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public predavanja Insert(predavanja _novi)
        {
            var n = new Predaje()
            {
                DatumPredavanja = _novi.DatumPredavanja,
                Odrzano = _novi.Odrzano,
                Opis = _novi.Opis,
                KursId = _novi.KursId,
                ProfesorId = _novi.ProfesorId,
                Vrsta = _novi.Vrsta
            };

            db.Predaje.Add(n);
            db.SaveChanges();

            return _novi;
        }

        public List<Models.predavanja> Get([FromQuery]PredavanjaSearchRequest search)
        {
            var query = db.Set<Predaje>().AsQueryable();

            if (search?.ProfesorId.HasValue == true)
            {
                query = query.Where(x => x.ProfesorId == search.ProfesorId);
            }

            query = query.OrderBy(x => x.Kurs.Naziv);

            var list = query.ToList();

            List<Models.predavanja> final = new List<Models.predavanja>();

            foreach (var x in list)
            {
                final.Add(new Models.predavanja
                {

                    KursId = x.KursId,
                    Naziv = db.Kurs.Where(y => y.KursId == x.KursId).Select(t => t.Naziv).FirstOrDefault(),
                    DatumPredavanja = x.DatumPredavanja,
                    ProfesorId = x.ProfesorId,
                    Odrzano = x.Odrzano,
                    Opis = x.Opis,
                    PredajeId = x.PredajeId,
                    Vrsta = x.Vrsta
                });
            }
            return final;

        }

        public predavanja GetById(int id)
        {
            Predaje t = db.Predaje.Find(id);

            predavanja temp = new predavanja
            {
                DatumPredavanja = t.DatumPredavanja,
                KursId = t.KursId,
                Naziv = db.Kurs.Where(w => w.KursId == t.KursId).Select(c => c.Naziv).FirstOrDefault(),
                Odrzano = t.Odrzano,
                Opis = t.Opis,
                PredajeId = t.PredajeId,
                ProfesorId = t.ProfesorId,
                Vrsta = t.Vrsta
            };

            return temp;
        }

        public predavanja Update(int id, predavanja o)
        {
            Predaje temp = db.Predaje.Find(id);

            temp.DatumPredavanja = o.DatumPredavanja;
            temp.KursId = o.KursId;
            temp.Odrzano = o.Odrzano;
            temp.Opis = o.Opis;
            temp.ProfesorId = o.ProfesorId;
            temp.Vrsta = o.Vrsta;

            db.SaveChanges();
            return o;
        }

        public bool Delete(int id)
        {
            Predaje temp = db.Predaje.Find(id);

            if (temp != null)
            {
                db.Remove(temp);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }
    }
}
