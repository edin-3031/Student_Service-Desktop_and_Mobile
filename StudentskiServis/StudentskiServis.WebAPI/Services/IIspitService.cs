using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IIspitService
    {
        List<Models.ispiti> Get([FromQuery]IspitSearchRequest request);
        Models.ispiti GetById(int id);
        Models.ispiti Update(int id, Models.ispiti ispit);
        Models.ispiti Insert(Models.ispiti tmp);
        bool Delete(int id);
    }
}
