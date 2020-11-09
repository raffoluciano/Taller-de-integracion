using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class Comentario : BaseEntity
    {
        public virtual DateTime Fecha { get; set; }

        public virtual string Descripcion { get; set; }

        public virtual string Respuesta { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
