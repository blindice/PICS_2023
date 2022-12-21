using PICS_2023.Features.Auth.DTO;
using PICS_2023.Features.Auth.Interface;
using PICS_2023.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PICS_2023.Features.Auth.Service
{
    public class AuthService : IAuthService
    {
        IAuthRepository _repo;
        IJWTService _jwtSvc;

        public AuthService(IAuthRepository repo, IJWTService jwtSvc)
        {
            _repo = repo;
            _jwtSvc = jwtSvc;
        }
        public async Task<string> LoginAsync(string username, string password)
        {
            (var user, var details) = await _repo.Login(username, password);

            var userDetails = new UserDto()
            {
                Id = details.Id,
                EmployeeNo = user.EmployeeNo,
                ApoAccount = user.APOAccount,
                FullName = $"{user.LastName} {user.FirstName} {user.MiddleName}",
                RoleId = (int)details.Role_Id
            };

            var token = await _jwtSvc.GenerateJwtTokenAsync(userDetails);

            return token;
        }
    }
}
