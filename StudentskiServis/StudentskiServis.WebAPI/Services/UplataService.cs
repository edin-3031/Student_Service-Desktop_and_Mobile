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
    public class UplataService:IUplataService
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public bool Delete(int id)
        {
            var temp = db.Uplata.Find(id);
            if (temp != null)
            {
                db.Remove(temp);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public List<uplate> Get([FromQuery] UplataSearchRequest request)
        {
            var query = db.Uplata.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Svrha))
            {
                query = query.Where(x => x.Svrha.Contains(request.Svrha));
            }

            var lista = query.ToList();

            List<Models.uplate> result = new List<uplate>();

            foreach (var x in lista)
            {
                result.Add(new Models.uplate
                {
                    AdministracijaId = x.AdministracijaId,
                    StudentId = x.StudentId,
                    UplataId = x.UplataId,
                    Svrha = x.Svrha,
                    DatumUplate = x.DatumUplate,
                    Evidentirao = db.Administracija.Where(a => a.AdministracijaId == x.AdministracijaId).Select(b => b.Ime + " " + b.Prezime).FirstOrDefault(),
                    Iznos = x.Iznos,
                    Ovjereno = x.Ovjereno,
                    Slika = x.Slika,
                    Uplatio = db.Student.Where(a => a.StudentId == x.StudentId).Select(b => b.Ime + " " + b.Prezime + " - " + b.Indeks).FirstOrDefault()
                }) ;
            }

            return result;
        }

        public uplate GetById(int id)
        {
            var temp = db.Uplata.Find(id);

            Models.uplate result = new Models.uplate
            {
                DatumUplate = temp.DatumUplate,
                Iznos = temp.Iznos,
                AdministracijaId = temp.AdministracijaId,
                Ovjereno = temp.Ovjereno,
                Slika = temp.Slika,
                StudentId = temp.StudentId,
                Svrha = temp.Svrha,
                UplataId = temp.UplataId,
                Evidentirao = db.Administracija.Where(a => a.AdministracijaId == temp.AdministracijaId).Select(y => y.Ime + " " + y.Prezime).FirstOrDefault(),
                Uplatio = db.Student.Where(a => a.StudentId == temp.StudentId).Select(y => y.Ime + " " + y.Prezime + " - " + y.Indeks).FirstOrDefault()
            };
            return result;
        }

        public uplate Insert(uplate nova)
        {
            var entity = new Database.Uplata
            {
                AdministracijaId = nova.AdministracijaId,
                DatumUplate = nova.DatumUplate,
                Iznos = nova.Iznos,
                Ovjereno = nova.Ovjereno,
                Slika = nova.Slika,
                StudentId = nova.StudentId,
                Svrha = nova.Svrha
            };

            if (entity.Slika == null)
                entity.Slika = Properties.Resources.test2;

            db.Uplata.Add(entity);
            db.SaveChanges();

            return nova;
        }

        public uplate Update(int id, uplate uplata)
        {
            Database.Uplata temp = db.Uplata.Find(id);

            temp.AdministracijaId = uplata.AdministracijaId;
            temp.DatumUplate = uplata.DatumUplate;
            temp.Iznos = uplata.Iznos;
            temp.Ovjereno = uplata.Ovjereno;
            temp.Slika = uplata.Slika;
            temp.StudentId = uplata.StudentId;
            temp.Svrha = uplata.Svrha;

            db.SaveChanges();

            return uplata;
        }
    }
}
