using StudentskiServis.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public class Auth : IAuth
    {
        private readonly StudentskiservisContext db = new StudentskiservisContext();

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

        int?[] IAuth.Auth(string username, string password, int? roleId)
        {

            int studRole = db.Uloge.Where(a => a.Naziv == "Student").Select(v => v.UlogaId).FirstOrDefault();
            int profRole = db.Uloge.Where(a => a.Naziv == "Profesor").Select(v => v.UlogaId).FirstOrDefault();
            int adminRole = db.Uloge.Where(a => a.Naziv == "Administrator").Select(v => v.UlogaId).FirstOrDefault();

            int? _Student = null;
            int? _Profesor = null;
            int? _Administracija = null;

            var lista_student = db.Student.ToList();

                foreach (var x in lista_student)
                {
                    if (username == x.KorisnickoIme && roleId == studRole)
                    {
                        _Student = x.StudentId;
                        break;
                    }
                }

                if (_Student == null)
                {
                    var lista_admin = db.Administracija.ToList();
                    foreach (var x in lista_admin)
                    {
                        if (username == x.KorisnickoIme && roleId == adminRole)
                        {
                            _Administracija = x.AdministracijaId;
                            break;
                        }
                    }
                }

                if (_Administracija == null)
                {
                    var lista_prof = db.Profesor.ToList();

                    foreach (var x in lista_prof)
                    {
                        if (username == x.KorisnickoIme && roleId == profRole)
                        {
                            _Profesor = x.ProfesorId;
                            break;
                        }
                    }
                }

            if (_Student == null && _Administracija == null && _Profesor == null)
            {
                return null;
            }


            if (_Student != null)
            {
                var stud = db.Student.Where(a => a.StudentId == _Student).FirstOrDefault();

                string sifra = GenerateHash(stud.LozinkaSalt, password);
                if (stud.LozinkaHash == sifra)
                {
                    int?[] array = new int?[2];
                    array[0] = stud.StudentId;
                    array[1] = studRole;
                    return array;
                }
            }

            else if (_Profesor != null)
            {
                var prof = db.Profesor.Where(a => a.ProfesorId == _Profesor).FirstOrDefault();

                string sifra = GenerateHash(prof.LozinkaSalt, password);
                if (prof.LozinkaHash == sifra)
                {

                    int?[] array = new int?[2];
                    array[0] = prof.ProfesorId;
                    array[1] = profRole;
                    return array;
                }
            }

            else if (_Administracija != null)
            {
                var admin = db.Administracija.Where(a => a.AdministracijaId == _Administracija).FirstOrDefault();

                string sifra = GenerateHash(admin.LozinkaSalt, password);
                if (admin.LozinkaHash == sifra)
                {
                    int?[] array = new int?[2];
                    array[0] = admin.AdministracijaId;
                    array[1] = adminRole;
                    return array;
                }
            }
            int?[] array2 = null;
            return array2;
        }
    }
}
