using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using NHibernate;

namespace Api.DAO
{
    public class ColeccionDAO : GenericDAO<Coleccion, long>
    {
        public ColeccionDAO(ISession session) : base(session)
        {

        }
    }
}
