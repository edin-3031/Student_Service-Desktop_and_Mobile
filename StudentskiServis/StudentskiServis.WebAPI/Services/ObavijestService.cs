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
    public class ObavijestService:IObavijestService
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public bool Delete(int id)
        {
            var t = db.Obavijest.Find(id);
            if (t != null)
            {
                db.Remove(t);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public List<obavijesti> Get([FromQuery] ObavijestSearchRequest request)
        {
            var query = db.Obavijest.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naslov))
            {
                query = query.Where(x => x.Naslov.Contains(request.Naslov));
            }

            var lista = query.ToList();

            List<Models.obavijesti> result = new List<obavijesti>();

            foreach (var x in lista)
            {
                result.Add(new Models.obavijesti
                {
                    DatumObjave = x.DatumObjave.Value,
                    Naslov = x.Naslov,
                    ObavijestId = x.ObavijestId,
                    Objavio = db.Profesor.Where(a => a.ProfesorId == x.ProfesorId).Select(y => y.Zvanje + " " + y.Ime + " " + y.Prezime).FirstOrDefault(),
                    ProfesorID = x.ProfesorId,
                    Sadrzaj = x.Sadrzaj
                });
            }
            return result;

            //var query = db.Profesor.AsQueryable();

            //if (!string.IsNullOrWhiteSpace(request?.Ime))
            //{
            //    query = query.Where(x => x.Ime.Contains(request.Ime));
            //}

            //if (!string.IsNullOrWhiteSpace(request?.Prezime))
            //{
            //    query = query.Where(x => x.Prezime.Contains(request.Prezime));
            //}

            //var lista = query.ToList();

            //List<Models.ProfesorAdmin> y = new List<ProfesorAdmin>();

            //foreach (var x in lista)
            //{
            //    y.Add(new Models.ProfesorAdmin
            //    {
            //        ProfesorId = x.ProfesorId,
            //        Adresa = x.Adresa,
            //        DatumRodjenja = x.DatumRodjenja,
            //        DatumZaposlenja = x.DatumZaposlenja,
            //        Ime = x.Ime,
            //        Kancelarija = x.Kancelarija,
            //        Zvanje = x.Zvanje,
            //        LozinkaHash = x.LozinkaHash,
            //        LozinkaSalt = x.LozinkaSalt,
            //        Mail = x.Mail,
            //        Prezime = x.Prezime,
            //        Slika = x.Slika,
            //        Spol = x.Spol,
            //        Staz = x.Staz,
            //        VrstaUgovora = x.VrstaUgovora
            //    });
            //}

            //return y;
        }

        public obavijesti GetById(int id)
        {
            var entity = db.Obavijest.Find(id);

            Models.obavijesti novi = new Models.obavijesti
            {
                DatumObjave = entity.DatumObjave.Value,
                Naslov = entity.Naslov,
                ObavijestId = entity.ObavijestId,
                Objavio = db.Profesor.Where(a => a.ProfesorId == entity.ProfesorId).Select(c => c.Zvanje + " " + c.Ime + " " + c.Prezime).FirstOrDefault(),
                ProfesorID = entity.ProfesorId,
                Sadrzaj = entity.Sadrzaj
            };

            return novi;
        }

        public obavijesti Insert(obavijesti novi)
        {
            Database.Obavijest temp = new Database.Obavijest
            {
                DatumObjave = novi.DatumObjave,
                Naslov = novi.Naslov,
                ProfesorId = novi.ProfesorID,
                Sadrzaj = novi.Sadrzaj
            };
            db.Add(temp);
            db.SaveChanges();

            return novi;
        }

        public obavijesti Update(int id, obavijesti o)
        {
            var temp = db.Obavijest.Find(id);

            temp.DatumObjave = o.DatumObjave;
            temp.Naslov = o.Naslov;
            temp.ProfesorId = o.ProfesorID;
            temp.Sadrzaj = o.Sadrzaj;

            db.SaveChanges();

            return o;
        }
    }
}
