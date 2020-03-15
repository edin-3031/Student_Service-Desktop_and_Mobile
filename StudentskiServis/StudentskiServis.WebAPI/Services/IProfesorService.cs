using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IProfesorService
    {
        List<Models.ProfesorAdmin> Get([FromQuery]ProfesorSearchRequest request);
        Models.ProfesorAdmin GetById(int id);
        Models.ProfesorAdmin Update(int id, Models.ProfesorAdmin o);
        ProfesorAdmin Insert(ProfesorAdmin novi);
        bool Delete(int id);
        bool Check_Username(string username);
    }
}
