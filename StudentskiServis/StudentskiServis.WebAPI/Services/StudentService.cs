using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{

    public class StudentService : IStudentService
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public bool Check_Username(string check)
        {
            var lista = db.Student.ToList();

            foreach (var x in lista)
            {
                if (x.KorisnickoIme == check)
                    return true;
            }

            return false;
        }

        public List<StudentAdmin> Get([FromQuery] StudentSearchRequest request)
        {
            var query = db.Student.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Indeks))
            {
                query = query.Where(x => x.Ime.Contains(request.Indeks));
            }

            if (!string.IsNullOrWhiteSpace(request?.Indeks))
            {
                query = query.Where(x => x.Prezime.Contains(request.Indeks));
            }

            if (!string.IsNullOrWhiteSpace(request?.Indeks))
            {
                query = query.Where(x => x.Indeks.Contains(request.Indeks));
            }

            var lista = query.ToList();

            List<Models.StudentAdmin> result = new List<Models.StudentAdmin>();

            foreach (var x in lista)
            {
                result.Add(new Models.StudentAdmin
                {
                    Ime = x.Ime,
                    Indeks = x.Indeks,
                    Prezime = x.Prezime,
                    StudentID = x.StudentId
                });
            }

            return result;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public StudentAdmin Insert(StudentAdmin novi)
        {
            var entity = new Database.Student()
            {
                Adresa = novi.Adresa,
                DatumRodjenja = novi.DatumRodjenja,
                DatumUpisa = novi.DatumUpisa,
                Ime = novi.Ime,
                Indeks = novi.Indeks,
                KorisnickoIme = novi.KorisnickoIme,
                Mail = novi.Mail,
                NacinStudiranja = novi.NacinStudiranja,
                ObnavljaGodinu = novi.ObnavljaGodinu,
                OvjerenSemestar = novi.OvjerenSemestar,
                Prezime = novi.Prezime,
                ProsjecnaOcjena = novi.ProsjecnaOcjena,
                Slika = novi.Slika,
                Spol = novi.Spol,
                Status = novi.Status,
                Telefon = novi.Telefon,
                UpisanSemestar = novi.UpisanSemestar
            };

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, novi.LozinkaHash);

            if (entity.Slika == null)
                entity.Slika = Properties.Resources.test2;

            db.Add(entity);
            db.SaveChanges();

            var list = db.Student.ToList();

            foreach (var x in list)
            {
                if (x.KorisnickoIme == novi.KorisnickoIme && x.Ime == novi.Ime && x.Prezime == novi.Prezime)
                {
                    KorisniciUloge n = new KorisniciUloge
                    {
                        StudentId = x.StudentId,
                        DatumIzmjene = DateTime.Now,
                        UlogaId = 2
                    };

                    db.KorisniciUloge.Add(n);
                    db.SaveChanges();
                }
            }

            return novi;
        }

        public Models.StudentAdmin Update(int id, StudentAdmin o)
        {
            Database.Student temp = db.Student.Find(id);

            temp.Adresa = o.Adresa;
            temp.DatumRodjenja = o.DatumRodjenja;
            temp.DatumUpisa = o.DatumUpisa;
            temp.Ime = o.Ime;
            temp.Indeks = o.Indeks;
            temp.KorisnickoIme = o.KorisnickoIme;
            temp.LozinkaHash = o.LozinkaHash;
            temp.LozinkaSalt = o.LozinkaSalt;
            temp.Mail = o.Mail;
            temp.NacinStudiranja = o.NacinStudiranja;
            temp.ObnavljaGodinu = o.ObnavljaGodinu;
            temp.OvjerenSemestar = o.OvjerenSemestar;
            temp.Prezime = o.Prezime;
            temp.ProsjecnaOcjena = o.ProsjecnaOcjena;
            temp.Slika = o.Slika;
            temp.Spol = o.Spol;
            temp.Status = o.Status;
            temp.Telefon = o.Telefon;
            temp.UpisanSemestar = o.UpisanSemestar;

            db.SaveChanges();

            return o;
        }
        public Models.StudentAdmin GetById(int id)
        {
            Database.Student t = db.Student.Find(id);

            Models.StudentAdmin temp = new StudentAdmin
            {
                Adresa=t.Adresa,
                DatumRodjenja=t.DatumRodjenja,
                DatumUpisa=t.DatumUpisa,
                Ime=t.Ime,
                Indeks=t.Indeks,
                KorisnickoIme=t.KorisnickoIme,
                LozinkaHash=t.LozinkaHash,
                LozinkaSalt=t.LozinkaSalt,
                Mail=t.Mail,
                NacinStudiranja=t.NacinStudiranja,
                ObnavljaGodinu=t.ObnavljaGodinu,
                OvjerenSemestar=t.OvjerenSemestar,
                Prezime=t.Prezime,
                ProsjecnaOcjena=t.ProsjecnaOcjena,
                Slika=t.Slika,
                Spol=t.Spol,
                Status=t.Status,
                StudentID=t.StudentId,
                Telefon=t.Telefon,
                UpisanSemestar=t.UpisanSemestar
            };

            return temp;

        }

        public bool Delete(int id)
        {
            var t = db.Student.Find(id);
            if (t != null)
            {
                var ku = db.KorisniciUloge.Where(a => a.StudentId == t.StudentId).FirstOrDefault();

                db.Remove(ku);
                db.SaveChanges();

                //Raspored
                var lista_rasporeda = db.Raspored.Where(a => a.StudentId==t.StudentId).ToList();

                foreach(var x in lista_rasporeda)
                {
                    db.Raspored.Remove(x);
                    db.SaveChanges();
                }

                //Pohađanja
                var lista_poahadjanja = db.Pohadja.Where(a => a.StudentId == t.StudentId).ToList();

                foreach (var z in lista_poahadjanja)
                {
                    db.Pohadja.Remove(z);
                    db.SaveChanges();
                }

                //Uplate
                var lista_uplate = db.Uplata.Where(a => a.StudentId == t.StudentId).ToList();

                foreach(var y in lista_uplate)
                {
                    y.AdministracijaId = null;
                    db.Uplata.Remove(y);
                    db.SaveChanges();
                }

                db.Remove(t);
                db.SaveChanges();
                return true;
            }
            else 
                return false;
        }
    }
}
