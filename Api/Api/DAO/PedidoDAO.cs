using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Entities;
using NHibernate;

namespace Api.DAO
{
    public class PedidoDAO : GenericDAO<Pedido, long>
    {
        public PedidoDAO(ISession session) : base(session)
        {

        }
    }
}
