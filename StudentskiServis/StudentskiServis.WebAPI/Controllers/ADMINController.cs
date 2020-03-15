using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.WebAPI.Database;
using StudentskiServis.WebAPI.Services;

namespace StudentskiServis.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ADMINController : ControllerBase
    {
        private readonly IADMINService _service;

        public ADMINController(IADMINService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<ADMIN> Get([FromQuery]object search)
        {
            return _service.Get(search);
        }
    }
}