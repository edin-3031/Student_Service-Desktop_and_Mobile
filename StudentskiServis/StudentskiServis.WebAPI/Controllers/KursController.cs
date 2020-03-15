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
    public class KursController : ControllerBase
    {
        private readonly IKursService _service;

        public KursController(IKursService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.kursevi> Get([FromQuery] KurseviSearchRequest search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id:int}")]
        public Models.kursevi GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPut("{id},{kurs}")]
        public Models.kursevi Update(int id, Models.kursevi request)
        {
            return _service.Update(id, request);
        }

        [HttpPost("{noviKurs}")]
        public Models.kursevi Insert(Models.kursevi temp)
        {
            return _service.Insert(temp);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}