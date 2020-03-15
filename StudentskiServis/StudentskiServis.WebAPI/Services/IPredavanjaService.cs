using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IPredavanjaService
    {
        List<Models.predavanja> Get([FromQuery]PredavanjaSearchRequest search);
        predavanja GetById(int id);
        predavanja Insert(predavanja _novi);
        Models.predavanja Update(int id, Models.predavanja o);
        bool Delete(int id);
    }
}
