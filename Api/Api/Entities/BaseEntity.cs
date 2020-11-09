using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public abstract class BaseEntity
    {
        public virtual long Id { get; protected set; }
    }
}
