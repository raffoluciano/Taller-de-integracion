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
    public class UsuarioMap : ClassMapping<Usuario>
    {
        public UsuarioMap()
        {
            Table("usuario");

            Id(x => x.Id, m =>
            {
                m.Generator(Generators.Increment);
                m.UnsavedValue(0);
            });

            Property(x => x.Nombre);
            Property(x => x.Apellido);
            Property(x => x.Contraseña);
            Property(x => x.DNI);
            Property(x => x.Email);
            Property(x => x.EstadoLogin);
            Property(x => x.Telefono);

            ManyToOne(x => x.Rol);


        }
    }
}
