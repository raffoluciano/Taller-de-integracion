using Api.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DAO
{
    public class RolDAO : GenericDAO<Rol, long>
    {
        public RolDAO(ISession session) : base(session)
        {

        }
    }
}
