using StudentskiServis.Models;
using StudentskiServis.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public class RasporedService : IRasporedService
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public bool Delete(int id)
        {
            var temp = db.Raspored.Find(id);

            if(temp!=null)
            {
                db.Remove(temp);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Models.Raspored> Get()
        {
            List<Models.Raspored> temp = new List<Models.Raspored>();
            var lista = db.Raspored.ToList();

            foreach(var x in lista)
            {
                temp.Add(new Models.Raspored
                {
                    Datum=x.Datum,
                    Naslov=x.Naslov,
                    Opis=x.Opis,
                    RasporedId=x.RasporedId,
                    StudentId=x.StudentId,
                    Vazno=x.Vazno
                });
            }
            return temp;
        }

        public Models.Raspored GetById(int id)
        {
            var result = db.Raspored.Find(id);

            var temp = new Models.Raspored
            {
                Datum = result.Datum,
                Vazno = result.Vazno,
                Naslov = result.Naslov,
                Opis = result.Opis,
                RasporedId = result.RasporedId,
                StudentId = result.StudentId
            };

            return temp;
        }

        public Models.Raspored Insert(Models.Raspored tmp)
        {
            Database.Raspored temp = new Database.Raspored
            {
                Datum = tmp.Datum,
                StudentId = tmp.StudentId,
                Naslov = tmp.Naslov,
                Opis = tmp.Opis,
                Vazno = tmp.Vazno
            };

            db.Add(temp);
            db.SaveChanges();

            return tmp;
        }

        public Models.Raspored Update(int id, Models.Raspored raspored)
        {
            var temp = db.Raspored.Find(id);

            temp.Vazno = raspored.Vazno;
            temp.StudentId = raspored.StudentId;
            temp.RasporedId = raspored.RasporedId;
            temp.Opis = raspored.Opis;
            temp.Naslov = raspored.Naslov;
            temp.Datum = raspored.Datum;

            db.SaveChanges();

            return raspored;
        }
    }
}
