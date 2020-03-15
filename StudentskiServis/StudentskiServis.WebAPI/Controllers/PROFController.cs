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
    public class PROFController : ControllerBase
    {
        private readonly IPROFService _serice;

        public PROFController(IPROFService service)
        {
            _serice = service;
        }

        [HttpGet]
        public List<Models.PROF> Get([FromQuery] ProfesorSearchRequest search)
        {
            return _serice.Get(search);
        }
    }
}