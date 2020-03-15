using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class ProfesorService : IProfesorService
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

        public bool Check_Username(string check)
        {
            var lista = db.Profesor.ToList();

            foreach (var x in lista)
            {
                if (x.KorisnickoIme == check)
                    return true;
            }

            return false;
        }

        public List<Models.ProfesorAdmin> Get([FromQuery]ProfesorSearchRequest request)
        {

            var query = db.Profesor.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.Contains(request.Ime));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.Contains(request.Prezime));
            }

            var lista = query.ToList();

            List<Models.ProfesorAdmin> result = new List<ProfesorAdmin>();

            foreach (var x in lista)
            {
                result.Add(new Models.ProfesorAdmin
                {
                    ProfesorId = x.ProfesorId,
                    Adresa = x.Adresa,
                    DatumRodjenja = x.DatumRodjenja,
                    DatumZaposlenja = x.DatumZaposlenja,
                    Ime = x.Ime,
                    Kancelarija = x.Kancelarija,
                    Zvanje = x.Zvanje,
                    LozinkaHash = x.LozinkaHash,
                    LozinkaSalt = x.LozinkaSalt,
                    Mail = x.Mail,
                    Prezime = x.Prezime,
                    Slika = x.Slika,
                    Spol = x.Spol,
                    Staz = x.Staz,
                    VrstaUgovora = x.VrstaUgovora
                });
            }

            return result;
        }

        public Models.ProfesorAdmin Update(int id, ProfesorAdmin o)
        {
            Profesor temp = db.Profesor.Find(id);

            temp.Slika = o.Slika;
            temp.Adresa = o.Adresa;
            temp.DatumRodjenja = o.DatumRodjenja;
            temp.DatumZaposlenja = o.DatumZaposlenja;
            temp.Ime = o.Ime;
            temp.Kancelarija = o.Kancelarija;
            temp.LozinkaHash = o.LozinkaHash;
            temp.LozinkaSalt = o.LozinkaSalt;
            temp.Mail = o.Mail;
            temp.Prezime = o.Prezime;
            temp.Spol = o.Spol;
            temp.Staz = o.Staz;
            temp.Zvanje = o.Zvanje;
            temp.VrstaUgovora = o.VrstaUgovora;

            db.SaveChanges();

            return o;
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

        public ProfesorAdmin Insert(ProfesorAdmin novi)
        {
            var entity = new Profesor
            {
                Adresa = novi.Adresa,
                DatumRodjenja = novi.DatumRodjenja,
                DatumZaposlenja = novi.DatumZaposlenja,
                Ime = novi.Ime,
                Kancelarija = novi.Kancelarija,
                KorisniciUloge = null,
                Mail = novi.Mail,
                Prezime = novi.Prezime,
                Slika = novi.Slika,
                Spol = novi.Spol,
                Staz = novi.Staz,
                VrstaUgovora = novi.VrstaUgovora,
                Ispit = null,
                Predaje = null,
                Zvanje = novi.Zvanje,
                KorisnickoIme = novi.KorisnickoIme
            };

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, novi.LozinkaHash);

            if (entity.Slika == null)
                entity.Slika = Properties.Resources.test2;

            db.Profesor.Add(entity);
            db.SaveChanges();

            var list = db.Profesor.ToList();

            foreach (var x in list)
            {
                if (x.KorisnickoIme == novi.KorisnickoIme && x.Ime == novi.Ime && x.Prezime == novi.Prezime)
                {
                    KorisniciUloge n = new KorisniciUloge
                    {
                        ProfesorId = x.ProfesorId,
                        DatumIzmjene = DateTime.Now,
                        UlogaId = 4
                    };

                    db.KorisniciUloge.Add(n);
                    db.SaveChanges();
                }
            }

            return novi;
        }

        public bool Delete(int id)
        {
            var temp = db.Profesor.Find(id);
            if (temp != null)
            {
                var ku = db.KorisniciUloge.Where(a => a.ProfesorId == temp.ProfesorId).FirstOrDefault();
                db.Remove(ku);
                db.SaveChanges();

                db.Remove(temp);
                db.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public ProfesorAdmin GetById(int id)
        {
            Profesor t = db.Profesor.Find(id);

            ProfesorAdmin temp = new ProfesorAdmin
            {
                Adresa = t.Adresa,
                DatumRodjenja = t.DatumRodjenja,
                DatumZaposlenja = t.DatumZaposlenja,
                Ime = t.Ime,
                Kancelarija = t.Kancelarija,
                KorisnickoIme = t.KorisnickoIme,
                LozinkaHash = t.LozinkaHash,
                LozinkaSalt = t.LozinkaSalt,
                Mail = t.Mail,
                Prezime = t.Prezime,
                ProfesorId = t.ProfesorId,
                Slika = t.Slika,
                Spol = t.Spol,
                Staz = t.Staz,
                VrstaUgovora = t.VrstaUgovora,
                Zvanje = t.Zvanje
            };

            return temp;
        }
    }
}