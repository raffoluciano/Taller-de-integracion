using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using NHibernate;

namespace Api.DAO
{
    public class ComentarioDAO : GenericDAO<Comentario, long>
    {
        public ComentarioDAO(ISession session) : base(session)
        {

        }
    }
}
