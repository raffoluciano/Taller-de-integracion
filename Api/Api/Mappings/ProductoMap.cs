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
    public class ProductoMap : ClassMapping<Producto>
    {
        public ProductoMap()
        {
            Table("producto");

            Id(x => x.Id, m =>
            {
                m.Generator(Generators.Increment);
                m.UnsavedValue(0);
            });

            Property(x => x.Nombre);
            Property(x => x.Precio);
            Property(x => x.Cantidad);
            Property(x => x.EnStock);
            Property(x => x.FechaSubida);
            Property(x => x.imagen);


            ManyToOne(x => x.Coleccion);
            ManyToOne(x => x.Descuento);


        }
    }
}
