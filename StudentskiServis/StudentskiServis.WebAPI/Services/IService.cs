using Microsoft.AspNetCore.Mvc;
using StudentskiServis.Models;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IService<T, TSearch>
    {
        List<T> Get(TSearch search);
        T GetById(int id);
        T Update(int id, object o);
        bool Delete(int? id);
        T Insert(object novi);
    }
}
