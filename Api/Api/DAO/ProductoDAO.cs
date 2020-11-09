using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using NHibernate;

namespace Api.DAO
{
    public class ProductoDAO : GenericDAO<Producto, long>
    {
        public ProductoDAO(ISession session) : base(session)
        {

        }
    }
}
