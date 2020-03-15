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
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesorService _service;

        public ProfesorController(IProfesorService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.ProfesorAdmin> Get([FromQuery]ProfesorSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id:int}")]
        public Models.ProfesorAdmin GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("{username}")]
        public virtual bool Check_Username(string username)
        {
            return _service.Check_Username(username);
        }

        [HttpPut("{id},{request}")]
        public Models.ProfesorAdmin Update(int id, ProfesorAdmin o)
        {
            return _service.Update(id, o);
        }

        [HttpPost("{ProfNovi}")]
        public ProfesorAdmin Insert(ProfesorAdmin novi)
        {
            return _service.Insert(novi);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}