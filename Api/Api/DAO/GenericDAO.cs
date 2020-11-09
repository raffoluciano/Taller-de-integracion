using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NHibernate;

namespace Api.DAO
{
    public abstract class GenericDAO<T, ID>
    {
        protected ISession session;
        public GenericDAO(ISession session)
        {
            this.session = session;
        }

        internal T Save(T entity)
        {
            this.session.Save(entity);
            this.session.Flush();
            return entity;
        }

        internal void Delete(T entity)
        {
            this.session.Delete(entity);
            this.session.Flush();
        }

        internal void Update(T entity)
        {
            this.session.Update(entity);
            this.session.Flush();
        }

        internal T FindByID(ID id)
        {
            return this.session.Get<T>(id);
        }

        internal IList<T> FindAll()
        {
            return this.session.CreateCriteria(typeof(T)).List<T>();
        }

    }
}
