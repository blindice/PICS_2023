using Microsoft.EntityFrameworkCore;
using PICS_2023.Features.Auth.Interface;
using PICS_2023.Model;
using PICS_2023.Model.Context;
using PICS_2023.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PICS_2023.Features.Auth.Repository
{
    public class AuthRepository : IAuthRepository
    {
        PICSContext _context;
        public AuthRepository(PICSContext context) => _context = context;

        public async Task<(TBL_M_USERMASTER, tbl_m_user)> Login(string username, string password)
        {
            var user = await _context.TBL_M_USERMASTERs
                .Where(user => (user.APOAccount == username || user.EmployeeNo == username)
                && user.Password == password).AsNoTracking().FirstOrDefaultAsync();

            if (user is null) throw new CustomException("User Not Found");

            var userDetails = await _context.tbl_m_users
                .Where(detail => detail.UserName == user.APOAccount || detail.UserName == user.EmployeeNo)
                .AsNoTracking().FirstOrDefaultAsync();

            if (user is null) throw new CustomException("User Not Found");

            return (user, userDetails);
        }
    }
}
