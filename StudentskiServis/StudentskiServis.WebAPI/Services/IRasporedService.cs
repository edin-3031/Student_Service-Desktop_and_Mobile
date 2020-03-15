using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IRasporedService
    {
        List<Models.Raspored> Get();
        Models.Raspored GetById(int id);
        Models.Raspored Insert(Models.Raspored tmp);
        Models.Raspored Update(int id, Models.Raspored raspored);
        bool Delete(int id);
    }
}
