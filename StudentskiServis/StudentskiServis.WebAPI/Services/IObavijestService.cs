using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IObavijestService
    {
        Models.obavijesti Insert(Models.obavijesti novi);
        Models.obavijesti GetById(int id);
        Models.obavijesti Update(int id, Models.obavijesti o);
        List<Models.obavijesti> Get([FromQuery]ObavijestSearchRequest request);
        bool Delete(int id);
    }
}
