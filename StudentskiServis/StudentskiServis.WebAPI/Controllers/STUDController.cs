using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.WebAPI.Services;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Database;

namespace StudentskiServis.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class STUDController : ControllerBase
    {
        private readonly ISTUDService _service;
        public STUDController(ISTUDService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.STUD> Get([FromQuery] PohadjanjaSearchRequest search)
        {
            return _service.Get(search);
        }
    }
}