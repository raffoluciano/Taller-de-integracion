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
    public class CuponMap : ClassMapping<Cupon>
    {
        public CuponMap()
        {
            Table("cupon");

            Id(x => x.Id, m =>
            {
                m.Generator(Generators.Increment);
                m.UnsavedValue(0);
            });

            Property(x => x.Descripcion);
            Property(x => x.Codigo);
            Property(x => x.Descuento);

            ManyToOne(x => x.Pedido);

        }
    }
}
