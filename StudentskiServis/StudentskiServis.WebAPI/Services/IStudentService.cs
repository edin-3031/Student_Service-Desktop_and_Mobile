using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IStudentService
    {
        List<Models.StudentAdmin> Get([FromQuery]StudentSearchRequest request);
        Models.StudentAdmin GetById(int id);
        StudentAdmin Insert(StudentAdmin novi);
        Models.StudentAdmin Update(int id, StudentAdmin o);
        bool Delete(int id);
        bool Check_Username(string username);
    }
}
