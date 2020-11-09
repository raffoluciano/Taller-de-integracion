using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Api.Entities
{
    public class Cupon : BaseEntity
    {
        public virtual string Descripcion { get; set; }

        public virtual string Codigo { get; set; }

        public virtual float Descuento { get; set; }

        public virtual Pedido Pedido { get; set; }
    }
}
