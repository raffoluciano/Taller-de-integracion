using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class Carrito : BaseEntity
    {
        public virtual DateTime Fecha { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
