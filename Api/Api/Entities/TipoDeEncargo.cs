using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class TipoDeEncargo : BaseEntity
    {
        public virtual string Tipo { get; set; }
    }
}
