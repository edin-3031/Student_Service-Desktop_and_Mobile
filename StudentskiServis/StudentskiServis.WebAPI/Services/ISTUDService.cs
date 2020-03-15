using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface ISTUDService
    {
        List<Models.STUD> Get([FromQuery] PohadjanjaSearchRequest search);
    }
}
