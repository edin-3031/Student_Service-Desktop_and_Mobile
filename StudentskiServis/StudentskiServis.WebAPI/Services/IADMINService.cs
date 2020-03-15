using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IADMINService
    {
        List<ADMIN> Get([FromQuery]object search);
    }
}
