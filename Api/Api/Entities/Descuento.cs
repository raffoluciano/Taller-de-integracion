using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;

namespace Api.Entities
{
    public class Descuento : BaseEntity
    {
        public virtual string Descripcion { get; set; }

        public virtual float Valor { get; set; }
    }
}
