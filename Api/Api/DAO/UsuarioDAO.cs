using Api.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Api.DAO
{
    public class UsuarioDAO : GenericDAO<Usuario,long>
    {
        public UsuarioDAO(ISession session) : base(session)
        {

        }
    }
}
