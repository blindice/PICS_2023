using PICS_2023.Features.Auth.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PICS_2023.Features.Auth.Interface
{
    public interface IJWTService
    {
        Task<string> GenerateJwtTokenAsync(UserDto user);
    }
}
