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
    public class LineaDeItemMap : ClassMapping<LineaDeItem>
    {
        public LineaDeItemMap()
        {
            Table("lineaDeItem");

            Id(x => x.Id, m =>
            {
                m.Generator(Generators.Increment);
                m.UnsavedValue(0);
            });

            Property(x => x.Cantidad);
            Property(x => x.Precio);

            ManyToOne(x => x.Carrito);
            ManyToOne(x => x.Encargo);
            ManyToOne(x => x.Producto);
            ManyToOne(x => x.Pedido);


        }
    }
}
