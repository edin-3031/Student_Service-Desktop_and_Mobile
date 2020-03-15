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
using Uplata = StudentskiServis.WebAPI.Database.Uplata;

namespace StudentskiServis.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UplataController : ControllerBase
    {
        IUplataService _service;
        public UplataController(IUplataService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.uplate> Get([FromQuery]UplataSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Models.uplate GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPut("{id},{request}")]
        public Models.uplate Update(int id, Models.uplate uplata)
        {
            return _service.Update(id, uplata);
        }

        [HttpPost("{NovaUplata}")]
        public Models.uplate Insert(Models.uplate nova)
        {
            return _service.Insert(nova);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}