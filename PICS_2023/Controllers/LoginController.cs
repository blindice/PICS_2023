using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PICS_2023.Features.Auth.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PICS_2023.Features.Auth.DTO;
using PICS_2023.Model;

namespace PICS_2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        IAuthService _svc;
        public LoginController(IAuthService svc)
        {
            _svc = svc;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] AccountDto account)
        {
            var token = await _svc.LoginAsync(account.Username, account.Password);

            var result = new ResponseDto<string>
            {
                Status = "success",
                Result = token,
                Message = "SuccessFully Login"
            };

            return Ok(result);
        }
    }
}
