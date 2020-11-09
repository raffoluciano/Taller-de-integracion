using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using NHibernate;

namespace Api.DAO
{
    public class DireccionDAO : GenericDAO<Direccion, long>
    {
        public DireccionDAO(ISession session) : base(session)
        {

        }
    }
}
