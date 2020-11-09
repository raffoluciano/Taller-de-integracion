using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using NHibernate;

namespace Api.DAO
{
    public class CuponDAO : GenericDAO<Cupon, long>
    {
        public CuponDAO(ISession session) : base(session)
        {

        }
    }
}
