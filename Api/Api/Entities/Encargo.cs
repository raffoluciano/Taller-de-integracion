using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class Encargo : BaseEntity
    {
        public virtual string Nombre { get; set; }

        public virtual string Coleccion{ get; set; }

        public virtual string Descripcion { get; set; }

        public virtual int Estado { get; set; }

        public virtual TipoDeEncargo TipoDeEncargo { get; set; }
    }
}
