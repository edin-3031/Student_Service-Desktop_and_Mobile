using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IAdministracijaService
    {
        List<Models.AdministracijaAdmin> Get(AdministracijaSearchRequest request);
        Models.AdministracijaAdmin Insert(Models.AdministracijaAdmin request);
        bool Delete(int id);
        Models.AdministracijaAdmin GetById(int id);
        Models.AdministracijaAdmin Update(int id, Models.AdministracijaAdmin admin);
        bool Check_Username(string username);

    }
}
