using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Database;
using StudentskiServis.WebAPI.Services;

namespace StudentskiServis.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IspitController : ControllerBase
    {
        private readonly IIspitService _service;

        public IspitController(IIspitService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.ispiti> Get([FromQuery]IspitSearchRequest request) {

            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Models.ispiti GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPut("{id},{object}")]
        public Models.ispiti Update(int id, Models.ispiti ispit)
        {
            return _service.Update(id, ispit);
        }

        [HttpPost("{novi}")]
        public Models.ispiti Insert(Models.ispiti tmp)
        {
            return _service.Insert(tmp);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}