using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PICS_2023.Features.Auth.DTO
{
    public class UserDto
    {
        public int Id { get; set; }

        public string EmployeeNo { get; set; }

        public string ApoAccount { get; set; }

        public string FullName { get; set; }

        public int RoleId { get; set; }
    }
}
