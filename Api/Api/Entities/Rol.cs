using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class Rol : BaseEntity
    {
        public virtual string Nombre { get; set; }
    }
}
