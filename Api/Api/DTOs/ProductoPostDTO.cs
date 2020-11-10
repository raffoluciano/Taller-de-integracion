using Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTOs
{
    public class ProductoPostDTO
    {
        public virtual string Nombre { get; set; }

        public virtual float Precio { get; set; }

        public virtual int Cantidad { get; set; }

        public virtual bool EnStock { get; set; }

        public virtual DateTime FechaSubida { get; set; }

        public virtual byte imagen { get; set; }

        public virtual Coleccion Coleccion { get; set; }
    }
}
