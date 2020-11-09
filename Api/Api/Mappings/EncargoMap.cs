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
    public class EncargoMap : ClassMapping<Encargo>
    {
        public EncargoMap()
        {
            Table("Encargo");

            Id(x => x.Id, m =>
            {
                m.Generator(Generators.Increment);
                m.UnsavedValue(0);
            });

            Property(x => x.Nombre);
            Property(x => x.Coleccion);
            Property(x => x.Descripcion);
            Property(x => x.Estado);

            ManyToOne(x => x.TipoDeEncargo);


        }
    }
}
