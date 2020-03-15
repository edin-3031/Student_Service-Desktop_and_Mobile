using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Database;
using StudentskiServis.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public class AdministracijaService : IAdministracijaService
    {
        private readonly StudentskiservisContext db;
        private readonly IMapper _mapper;

        public AdministracijaService(StudentskiservisContext _db, IMapper mapper)
        {
            db = _db;
            _mapper = mapper;
        }

        public bool Check_Username(string check)
        {
            var lista = db.Administracija.ToList();

            foreach (var x in lista)
            {
                if (x.KorisnickoIme == check)
                    return true;
            }

            return false;
        }

        public List<Models.AdministracijaAdmin> Get([FromQuery]AdministracijaSearchRequest request)
        {

            var query = db.Administracija.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.Contains(request.Ime));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.Contains(request.Prezime));
            }

            var lista = query.ToList();

            List<Models.AdministracijaAdmin> result = new List<AdministracijaAdmin>();

            foreach (var x in lista)
            {
                result.Add(new Models.AdministracijaAdmin
                {
                    AdministracijaId = x.AdministracijaId,
                    Adresa = x.Adresa,
                    DatumRodjenja = x.DatumRodjenja,
                    DatumZaposlenja = x.DatumZaposlenja,
                    Ime = x.Ime,
                    Kancelarija = x.Kancelarija,
                    KorisnickoIme = x.KorisnickoIme,
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

        public AdministracijaAdmin Insert(AdministracijaAdmin novi)
        {
            var entity = new Administracija
            {
                Adresa = novi.Adresa,
                DatumRodjenja = novi.DatumRodjenja,
                DatumZaposlenja = novi.DatumZaposlenja,
                Ime = novi.Ime,
                Kancelarija = novi.Kancelarija,
                KorisniciUloge = null,
                KorisnickoIme = novi.KorisnickoIme,
                Mail = novi.Mail,
                Prezime = novi.Prezime,
                Slika = novi.Slika,
                Spol = novi.Spol,
                Staz = novi.Staz,
                Uplata = null,
                VrstaUgovora = novi.VrstaUgovora
            };

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, novi.LozinkaHash);

            if (entity.Slika == null)
            {
                entity.Slika =  Properties.Resources.test2;
            }
            db.Administracija.Add(entity);
            db.SaveChanges();

            var list = db.Administracija.ToList();
            
            foreach(var x in list)
            {
                if (x.KorisnickoIme == novi.KorisnickoIme && x.Ime==novi.Ime && x.Prezime==novi.Prezime) {
                    KorisniciUloge n = new KorisniciUloge
                    {
                        AdministracijaId = x.AdministracijaId,
                        DatumIzmjene = DateTime.Now,
                        UlogaId = 1
                    };

                    db.KorisniciUloge.Add(n);
                    db.SaveChanges();
                }
            }

            return novi;
        }

        public Models.AdministracijaAdmin Update(int id, AdministracijaAdmin o)
        {
            Administracija temp = db.Administracija.Find(id);

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
            db.SaveChanges();

            return o;
        }

        public virtual bool Delete(int id)
        {
            var item = db.Administracija.Find(id);

            if (item != null)
            {
                var ku = db.KorisniciUloge.Where(a => a.AdministracijaId == item.AdministracijaId).FirstOrDefault();
                db.Remove(ku);
                db.SaveChanges();

                db.Administracija.Remove(item);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public AdministracijaAdmin GetById(int _id)
        {
            var entity = db.Administracija.Find(_id);

            Models.AdministracijaAdmin temp = new Models.AdministracijaAdmin
            {
                AdministracijaId = entity.AdministracijaId,
                Adresa = entity.Adresa,
                DatumRodjenja = entity.DatumRodjenja,
                DatumZaposlenja = entity.DatumZaposlenja,
                Ime = entity.Ime,
                Kancelarija = entity.Kancelarija,
                KorisnickoIme = entity.KorisnickoIme,
                LozinkaHash = entity.LozinkaHash,
                LozinkaSalt = entity.LozinkaSalt,
                Mail = entity.Mail,
                Prezime = entity.Prezime,
                Slika = entity.Slika,
                Spol = entity.Spol,
                Staz = entity.Staz,
                VrstaUgovora = entity.VrstaUgovora
            };

            return temp;
        }
    }
}
