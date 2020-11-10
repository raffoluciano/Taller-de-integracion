using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Api.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Entities.Descuento, DTOs.DescuentoGetPutDTO>()
            .ReverseMap();

            CreateMap<Entities.Descuento, DTOs.DescuentoPostDTO>()
            .ReverseMap();

            CreateMap<Entities.Direccion, DTOs.DireccionGetPutDTO>()
            .ReverseMap();

            CreateMap<Entities.Direccion, DTOs.DireccionPostDTO>()
            .ReverseMap();

            CreateMap<Entities.Producto, DTOs.ProductoGetPutDTO>()
           .ReverseMap();

            CreateMap<Entities.Producto, DTOs.ProductoPostDTO>()
            .ReverseMap();

            CreateMap<Entities.Rol, DTOs.RolGetPutDTO>()
           .ReverseMap();

            CreateMap<Entities.Rol, DTOs.RolPostDTO>()
            .ReverseMap();

            CreateMap<Entities.Usuario, DTOs.UsuarioGetPutDTO>()
          .ReverseMap();

            CreateMap<Entities.Usuario, DTOs.UsuarioPostDTO>()
            .ReverseMap();


        }
    }
}
