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


    public class AuthController : ControllerBase
    {
        private readonly IAuth _service;

        public AuthController(IAuth service)
        {
            _service = service;
        }

        [HttpGet("{username},{pass},{ulogaId}")]
        public int?[] Auth(string username, string pass, int? ulogaId)
        {
            return _service.Auth(username, pass, ulogaId);
        }

    }
}