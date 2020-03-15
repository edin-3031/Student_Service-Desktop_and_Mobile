using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.WebAPI.Database;
using StudentskiServis.WebAPI.Services;

namespace StudentskiServis.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KURS_Controller : ControllerBase
    {
        private readonly IKURS_Service _service;

        public KURS_Controller(IKURS_Service service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.KURS_> Get([FromQuery] object search)
        {
            return _service.Get(search);
        }
    }
}