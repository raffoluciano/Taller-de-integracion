using Api.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DAO
{
    public class CarritoDAO : GenericDAO<Carrito, long>
    {
        public CarritoDAO(ISession session) : base(session)
        {

        }
    }
}
