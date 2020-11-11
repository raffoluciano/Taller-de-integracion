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
            .ForMember(x => x.UsuarioId, opt => opt.MapFrom(src => src.Usuario.Id))  
            .ReverseMap();

            CreateMap<Entities.Direccion, DTOs.DireccionPostDTO>()
            .ForMember(x => x.UsuarioId, opt => opt.MapFrom(src => src.Usuario.Id))  
            .ReverseMap();

            CreateMap<Entities.Producto, DTOs.ProductoGetPutDTO>()
            .ForMember(x => x.DescuentoId, opt => opt.MapFrom(src => src.Descuento.Id))  
            .ReverseMap();

            CreateMap<Entities.Producto, DTOs.ProductoPostDTO>()
            .ForMember(x => x.DescuentoId, opt => opt.MapFrom(src => src.Descuento.Id))  
            .ReverseMap();

            CreateMap<Entities.Rol, DTOs.RolGetPutDTO>()
           .ReverseMap();

            CreateMap<Entities.Rol, DTOs.RolPostDTO>()
            .ReverseMap();

            CreateMap<Entities.Usuario, DTOs.UsuarioGetPutDTO>()
            .ForMember(x => x.RolId, opt => opt.MapFrom(src => src.Rol.Id))
            .ReverseMap();

            CreateMap<Entities.Usuario, DTOs.UsuarioPostDTO>()
            .ForMember(x => x.RolId, opt => opt.MapFrom(src => src.Rol.Id))
            .ReverseMap();


        }
    }
}
