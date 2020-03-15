using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IUloga
    {
        List<Models.ULOGA> Get(UlogaSearchRequest request);
        Models.ULOGA GetById(int id);
    }
}
