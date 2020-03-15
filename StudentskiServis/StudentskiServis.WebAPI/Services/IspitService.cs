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
    public class IspitService : IIspitService
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public bool Delete(int id)
        {
            var t = db.Ispit.Find(id);
            if (t != null)
            {
                db.Remove(t);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public List<ispiti> Get([FromQuery] IspitSearchRequest request)
        {
            var query = db.Ispit.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Kurs))
            {
                query = query.Where(x => x.Kurs.Naziv.Contains(request.Kurs));
            }

            var lista = query.ToList();

            var result = new List<Models.ispiti>();

            foreach (var x in lista)
            {
                result.Add(new Models.ispiti
                {
                    BrojPitanja = x.BrojPitanja,
                    Datum = x.Datum,
                    IspitId = x.IspitId,
                    Kurs = db.Kurs.Where(a => a.KursId == x.KursId).Select(y => y.Naziv).FirstOrDefault(),
                    Profesor = db.Profesor.Where(a => a.ProfesorId == x.ProfesorId).Select(d => d.Zvanje + " " + d.Ime + " " + d.Prezime).SingleOrDefault(),
                    KursId = x.KursId,
                    MaxBodova = x.MaxBodova,
                    ParcijalnoBodovanje = x.ParcijalnoBodovanje,
                    ProfesorId = x.ProfesorId,
                    Trajanje = x.Trajanje,
                    Ucionica = x.Ucionica
                });
            }

            return result;
        }

        public ispiti GetById(int id)
        {
            var temp = db.Ispit.Where(a => a.IspitId == id).FirstOrDefault();

            Models.ispiti result = new Models.ispiti
            {
                BrojPitanja = temp.BrojPitanja,
                Datum = temp.Datum,
                IspitId = temp.IspitId,
                KursId = temp.KursId,
                MaxBodova = temp.MaxBodova,
                ParcijalnoBodovanje = temp.ParcijalnoBodovanje,
                ProfesorId = temp.ProfesorId,
                Trajanje = temp.Trajanje,
                Ucionica = temp.Ucionica,
                Kurs = db.Kurs.Where(a => a.KursId == temp.KursId).Select(y => y.Naziv).FirstOrDefault(),
                Profesor = db.Profesor.Where(a => a.ProfesorId == temp.ProfesorId).Select(d => d.Zvanje + " " + d.Ime + " " + d.Prezime).SingleOrDefault()
            };

            return result;
        }

        public ispiti Insert(ispiti tmp)
        {
            Database.Ispit temp = new Database.Ispit
            {
                BrojPitanja = tmp.BrojPitanja,
                Datum = tmp.Datum,
                KursId = tmp.KursId,
                MaxBodova = tmp.MaxBodova,
                ParcijalnoBodovanje = tmp.ParcijalnoBodovanje,
                ProfesorId = tmp.ProfesorId,
                Trajanje = tmp.Trajanje,
                Ucionica = tmp.Ucionica
            };

            db.Add(temp);
            db.SaveChanges();

            return tmp;
        }

        public ispiti Update(int id, ispiti ispit)
        {
            var temp = db.Ispit.Find(id);

            temp.BrojPitanja = ispit.BrojPitanja;
            temp.Datum = ispit.Datum;
            temp.KursId = ispit.KursId;
            temp.MaxBodova = ispit.MaxBodova;
            temp.ParcijalnoBodovanje = ispit.ParcijalnoBodovanje;
            temp.ProfesorId = ispit.ProfesorId;
            temp.Trajanje = ispit.Trajanje;
            temp.Ucionica = ispit.Ucionica;

            db.SaveChanges();

            return ispit;
        }
    }
}
