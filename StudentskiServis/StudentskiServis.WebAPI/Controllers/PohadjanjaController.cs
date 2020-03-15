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
    public class PohadjanjaController : ControllerBase
    {
        IPohadjaService _service;
        public PohadjanjaController(IPohadjaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.pohadjanja> Get([FromQuery]PohadjanjaSearchRequest search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public Models.pohadjanja GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost("{novi}")]
        public pohadjanja Insert(pohadjanja _novi)
        {
            return _service.Insert(_novi);
        }

        [HttpPut("{id},{temp}")]
        public pohadjanja Update(int id, pohadjanja tmp)
        {
            return _service.Update(id,tmp);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}