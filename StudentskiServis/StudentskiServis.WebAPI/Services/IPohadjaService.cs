using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IPohadjaService
    {
        List<Models.pohadjanja> Get([FromQuery]PohadjanjaSearchRequest search);
        Models.pohadjanja GetById(int id);
        pohadjanja Insert(pohadjanja _novi);
        pohadjanja Update(int id, pohadjanja _novi);
        bool Delete(int id);
    }
}
