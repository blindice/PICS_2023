using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PICS_2023.Model
{
    public class ResponseDto<T>
    {
        public string Status { get; set; }

        public T Result { get; set; }

        public string Message { get; set; }

    }
}
