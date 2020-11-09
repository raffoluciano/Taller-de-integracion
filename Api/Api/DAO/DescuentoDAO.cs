using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using NHibernate;

namespace Api.DAO
{
    public class DescuentoDAO : GenericDAO<Descuento, long>
    {
        public DescuentoDAO(ISession session) : base(session)
        {

        }
    }

}