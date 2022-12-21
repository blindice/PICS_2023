using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PICS_2023.Utils
{
    public class CustomException: Exception
    {
        public CustomException(string msg) : base(msg)
        {

        }
    }
}
