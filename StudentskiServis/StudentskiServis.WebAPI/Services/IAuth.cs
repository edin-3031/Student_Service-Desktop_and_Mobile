using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskiServis.WebAPI.Services
{
    public interface IAuth
    {
        int?[] Auth(string username, string password, int? roleId);
    }
}
