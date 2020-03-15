using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Database;
using StudentskiServis.WebAPI.Mappers;
using StudentskiServis.WebAPI.Services;

namespace StudentskiServis.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministracijaController : ControllerBase
    {
        private readonly IAdministracijaService _service;

        public AdministracijaController(IAdministracijaService service)
        {
            _service = service;
        }

        [HttpPut("{id},{request}")]
        public Models.AdministracijaAdmin Update(int id, AdministracijaAdmin o)
        {
            return _service.Update(id, o);
        }

        [HttpGet("{username}")]
        public virtual bool Check_Username(string username)
        {
            return _service.Check_Username(username);
        }

        [HttpGet]
        public List<Models.AdministracijaAdmin> Get([FromQuery]AdministracijaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id:int}")]
        public virtual Models.AdministracijaAdmin GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost("{AdminNovi}")]
        public AdministracijaAdmin Insert(AdministracijaAdmin novi)
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