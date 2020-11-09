using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class Direccion : BaseEntity
    {
        public virtual string Provincia { get; set; }

        public virtual string Localidad { get; set; }

        public virtual int CP { get; set; }

        public virtual string Calle { get; set; }

        public virtual int Numero { get; set; }

        public virtual int PisoDepto { get; set; }

        public virtual string NotaDescripcion { get; set; }

        public virtual float Costo { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
