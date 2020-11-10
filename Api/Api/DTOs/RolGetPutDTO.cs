using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTOs
{
    public class RolGetPutDTO
    {
        public virtual int Id{ get; set; }

        public virtual string Nombre { get; set; }
    }
}
