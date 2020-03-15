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
    public class PredavanjaController : ControllerBase
    {
        private readonly IPredavanjaService _service;

        public PredavanjaController(IPredavanjaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.predavanja>Get([FromQuery]PredavanjaSearchRequest search)
        {
            return _service.Get(search);
        }

        [HttpPut("{id},{object}")]
        public Models.predavanja Update(int id, Models.predavanja o)
        {
            return _service.Update(id, o);
        }

        [HttpGet("{id}")]
        public predavanja GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost("{novi}")]
        public predavanja Insert(predavanja _novi)
        {
            return _service.Insert(_novi);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}