using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using NHibernate;

namespace Api.DAO
{
    public class EncargoDAO : GenericDAO<Encargo, long>
    {
        public EncargoDAO(ISession session) : base(session)
        {

        }
    }
}
