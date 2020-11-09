using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class LineaDeItem : BaseEntity
    {
        public virtual int Cantidad { get; set; }

        public virtual float Precio { get; set; }

        public virtual Carrito Carrito { get; set; }

        public virtual Encargo Encargo { get; set; }

        public virtual Producto Producto{ get; set; }

        public virtual Pedido Pedido { get; set; }
    }
}
