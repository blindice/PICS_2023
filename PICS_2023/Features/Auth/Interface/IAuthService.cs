using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PICS_2023.Features.Auth.Interface
{
    public interface IAuthService
    {
        Task<string> LoginAsync(string username, string password);
    }
}
