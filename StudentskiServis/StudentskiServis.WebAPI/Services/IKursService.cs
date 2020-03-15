using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IKursService
    {
        List<Models.kursevi> Get([FromQuery]KurseviSearchRequest search);
        Models.kursevi GetById(int id);
        Models.kursevi Insert(Models.kursevi noviKurs);
        Models.kursevi Update(int id, Models.kursevi kurs);
        bool Delete(int id);
    }
}
