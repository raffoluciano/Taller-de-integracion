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
    public class DireccionMap : ClassMapping<Direccion>
    {
        public DireccionMap()
        {
            Table("direccion");

            Id(x => x.Id, m =>
            {
                m.Generator(Generators.Increment);
                m.UnsavedValue(0);
            });

            Property(x => x.Provincia);
            Property(x => x.Localidad);
            Property(x => x.CP);
            Property(x => x.Calle);
            Property(x => x.Numero);
            Property(x => x.PisoDepto);
            Property(x => x.NotaDescripcion);
            Property(x => x.Costo);

            ManyToOne(x => x.Usuario);


        }
    }
}
