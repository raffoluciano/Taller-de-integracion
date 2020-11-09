using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using NHibernate;

namespace Api.DAO
{
    public class TipoDeEncargoDAO : GenericDAO<TipoDeEncargo, long>
    {
        public TipoDeEncargoDAO(ISession session) : base(session)
        { 

        }
    }
}
