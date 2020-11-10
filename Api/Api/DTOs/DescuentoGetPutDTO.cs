using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTOs
{
    public class DescuentoGetPutDTO
    {
        public virtual int Id { get; set; }

        public virtual string Descripcion { get; set; }

        public virtual float Valor { get; set; }
    }
}
