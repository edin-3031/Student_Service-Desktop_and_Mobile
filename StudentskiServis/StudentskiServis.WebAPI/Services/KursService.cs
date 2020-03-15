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
    public class KursService : IKursService
    {
        private readonly StudentskiservisContext db;
        private IMapper _mapper;

        public KursService(StudentskiservisContext _db, IMapper mapper)
        {
            db = _db;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            Database.Kurs temp = db.Kurs.Find(id);

            if (temp != null)
            {
                db.Remove(temp);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public List<kursevi> Get([FromQuery] KurseviSearchRequest request)
        {
            var query = db.Kurs.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naziv))
            {
                query = query.Where(x => x.Naziv.Contains(request.Naziv));
            }

            var lista = query.ToList();

            List<Models.kursevi> result = new List<Models.kursevi>();

            return _mapper.Map<List<Models.kursevi>>(lista);
        }

        public kursevi GetById(int id)
        {
            var entity = db.Kurs.Find(id);

            return _mapper.Map<Models.kursevi>(entity);
        }

        public kursevi Insert(kursevi noviKurs)
        {
            Database.Kurs tmp = new Database.Kurs
            {
                Ects = noviKurs.Ects,
                Naziv = noviKurs.Naziv,
                PosjedujePraksu = noviKurs.PosjedujePraksu,
                PosjedujeSeminarski = noviKurs.PosjedujeSeminarski
            };

            db.Kurs.Add(tmp);
            db.SaveChanges();

            return noviKurs;
        }

        public Models.kursevi Update(int id, Models.kursevi request)
        {
            Database.Kurs temp = db.Kurs.Find(id);

            temp.Naziv = request.Naziv;
            temp.PosjedujePraksu = request.PosjedujePraksu;
            temp.PosjedujeSeminarski = request.PosjedujeSeminarski;
            temp.Ects = request.Ects;

            db.SaveChanges();
            return request;
        }
    }
}
