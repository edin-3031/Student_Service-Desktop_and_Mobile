using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Services;

namespace StudentskiServis.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UlogaController : ControllerBase
    {
        private readonly IUloga _service;

        public UlogaController(IUloga service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.ULOGA> Get([FromQuery]UlogaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Models.ULOGA Get(int id)
        {
            return _service.GetById(id);
        }
    }
}