﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;


namespace Api.Mappings
{
    public class CarritoMap : ClassMapping<Carrito>
    {
        public CarritoMap()
        {
            Table("carrito");

            Id(x => x.Id, m =>
            {
                m.Generator(Generators.Increment);
                m.UnsavedValue(0);
            });

            Property(x => x.Fecha);

            ManyToOne(x => x.Usuario);


        }
    }
}
