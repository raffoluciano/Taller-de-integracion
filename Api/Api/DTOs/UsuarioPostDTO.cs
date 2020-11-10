using Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DTOs
{
    public class UsuarioPostDTO
    {
        public virtual string Contraseña { get; set; }

        public virtual string EstadoLogin { get; set; }

        public virtual string Nombre { get; set; }

        public virtual string Apellido { get; set; }

        public virtual string DNI { get; set; }

        public virtual string Telefono { get; set; }

        public virtual string Email { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
