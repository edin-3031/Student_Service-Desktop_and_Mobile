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
using Student = StudentskiServis.WebAPI.Database.Student;

namespace StudentskiServis.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController:ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.StudentAdmin> Get([FromQuery]StudentSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id:int}")]
        public Models.StudentAdmin GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet("{username}")]
        public virtual bool Check_Username(string username)
        {
            return _service.Check_Username(username);
        }

        [HttpPost("{StudentNovi}")]
        public StudentAdmin Insert(StudentAdmin novi)
        {
            return _service.Insert(novi);
        }

        [HttpPut("{id},{request}")]
        public Models.StudentAdmin Update(int id, StudentAdmin o)
        {
            return _service.Update(id, o);
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}