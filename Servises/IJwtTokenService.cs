using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public interface IJwtTokenService
    {
        string BuildToken(string email);
    }
}
