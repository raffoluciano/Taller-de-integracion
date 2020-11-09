using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class Pedido : BaseEntity
    {
        public virtual DateTime Fecha { get; set; }

        public virtual float Subtotal { get; set; }

        public virtual float Total { get; set; }

        public virtual bool Pagado { get; set; }

        public virtual int NroTracking { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual Direccion Direccion { get; set; }

    }
}
