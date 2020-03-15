using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentskiServis.WebAPI.Services;

namespace StudentskiServis.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RasporedController : ControllerBase
    {
        private readonly IRasporedService _service;

        public RasporedController(IRasporedService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.Raspored> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id:int}")]
        public Models.Raspored GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpDelete("{id:int}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }

        [HttpPost("{tmp}")]
        public Models.Raspored Insert(Models.Raspored novi) {
            return _service.Insert(novi);
        }

        [HttpPut("{id},{raspored}")]
        public Models.Raspored Update(int id, Models.Raspored noviRaspored)
        {
            return _service.Update(id, noviRaspored);
        }
    }
}