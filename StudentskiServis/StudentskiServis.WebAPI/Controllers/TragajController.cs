using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Services;

namespace StudentskiServis.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TragajController : ControllerBase
    {
        private readonly ITragajService _service;

        public TragajController(ITragajService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<KoPohadja>Get([FromQuery] TragajRequest request)
        {
            return _service.Get(request);
        }
    }
}