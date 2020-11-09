using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using NHibernate;

namespace Api.DAO
{
    public class LineaDeItemDAO : GenericDAO<LineaDeItem, long>
    {
        public LineaDeItemDAO(ISession session) : base(session)
        {

        }
    }
}
