using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IKURS_Service
    {
        List<Models.KURS_> Get([FromQuery]object search);
    }
}
