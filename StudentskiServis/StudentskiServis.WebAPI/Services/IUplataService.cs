using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IUplataService
    {
        List<Models.uplate> Get([FromQuery]UplataSearchRequest request);
        Models.uplate GetById(int id);
        Models.uplate Update(int id, Models.uplate uplata);
        Models.uplate Insert(Models.uplate nova);
        bool Delete(int id);
    }
}
