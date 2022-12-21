using PICS_2023.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PICS_2023.Features.Auth.Interface
{
    public interface IAuthRepository
    {
        Task<(TBL_M_USERMASTER, tbl_m_user)> Login(string username, string password);
    }
}
