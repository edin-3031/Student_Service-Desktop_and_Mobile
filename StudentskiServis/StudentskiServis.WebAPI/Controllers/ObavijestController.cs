using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Database;
using StudentskiServis.WebAPI.Services;

namespace StudentskiServis.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObavijestController : ControllerBase
    {

        private readonly IObavijestService _service;

        public ObavijestController(IObavijestService service)
        {
            _service = service;
        }

        [HttpPost("{object}")]
        public Models.obavijesti Insert(Models.obavijesti novi)
        {
            return _service.Insert(novi);
        }

        [HttpGet("{id}")]
        public Models.obavijesti GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPut("{id},{object}")]
        public Models.obavijesti Update(int id, Models.obavijesti o)
        {
            return _service.Update(id, o);
        }

        [HttpGet]
        public List<Models.obavijesti> Get([FromQuery]ObavijestSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}