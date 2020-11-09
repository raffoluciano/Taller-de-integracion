using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace Api.Mappings
{
    public class PedidoMap : ClassMapping<Pedido>
    {
        public PedidoMap()
        {
            Table("pedido");

            Id(x => x.Id, m =>
            {
                m.Generator(Generators.Increment);
                m.UnsavedValue(0);
            });

            Property(x => x.Fecha);
            Property(x => x.Subtotal);
            Property(x => x.Total);
            Property(x => x.Pagado);
            Property(x => x.NroTracking);

            ManyToOne(x => x.Usuario);
            ManyToOne(x => x.Direccion);


        }
    }
}
