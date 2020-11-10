using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Controllers;
using Api.DAO;
using Api.DTOs;
using AutoMapper;

namespace Api.Services
{
    public class UsuarioService
    {
        private readonly UsuarioDAO usuarioDAO;
        private readonly DireccionDAO direccionDAO;
        private readonly RolDAO rolDAO;
        private readonly IMapper mapper;

        public UsuarioService(UsuarioDAO usuarioDAO, DireccionDAO direccionDAO, RolDAO rolDAO, IMapper mapper)
        {
            this.usuarioDAO = usuarioDAO;
            this.direccionDAO = direccionDAO;
            this.rolDAO = rolDAO;
            this.mapper = mapper;
        }

        ///////////////////////////////////Usuarios//////////////////////////////////////////////////////////////////
        internal IList<UsuarioGetPutDTO> GetUsuarios()
        {
            List<UsuarioGetPutDTO> result = new List<UsuarioGetPutDTO>();
            foreach (var usuario in usuarioDAO.FindAll())
            {
                result.Add(mapper.Map<UsuarioGetPutDTO>(usuario)); //poner uno o dos es lo mismo <UsuarioDTO, Entities.Usuario>
            }
            return result;
        }

        internal UsuarioPostDTO AddUsuario(UsuarioPostDTO usuario)
        {
            Entities.Usuario usuarioEntity = mapper.Map<UsuarioPostDTO, Entities.Usuario>(usuario);
            this.usuarioDAO.Save(usuarioEntity);
            return usuario;
        }

        internal void UpdateUsuarioById(UsuarioGetPutDTO usuario)
        {
            Entities.Usuario usuarioEntity = mapper.Map<UsuarioGetPutDTO, Entities.Usuario>(usuario);
            this.usuarioDAO.Update(usuarioEntity);
        }

        //////////////////////////////////////////Direccion////////////////////////////////////////////////////

        internal IList<DireccionGetPutDTO> GetDirecciones()
        {
            List<DireccionGetPutDTO> result = new List<DireccionGetPutDTO>();
            foreach (var direccion in direccionDAO.FindAll())
            {
                result.Add(mapper.Map<DireccionGetPutDTO>(direccion)); //poner uno o dos es lo mismo <DireccionDTO, Entities.Direccion>
            }
            return result;
        }

        internal DireccionPostDTO AddDireccion(DireccionPostDTO direccion)
        {
            Entities.Direccion direccionEntity = mapper.Map<DireccionPostDTO, Entities.Direccion>(direccion);
            this.direccionDAO.Save(direccionEntity);
            return direccion;
        }

        internal void UpdateDireccionById(DireccionGetPutDTO direccion)
        {
            Entities.Direccion direccionEntity = mapper.Map<DireccionGetPutDTO, Entities.Direccion>(direccion);
            this.direccionDAO.Update(direccionEntity);
        }

        //////////////////////////////////////////////////Rol////////////////////////////////////////////////////////

        internal IList<RolGetPutDTO> GetRoles()
        {
            List<RolGetPutDTO> result = new List<RolGetPutDTO>();
            foreach (var rol in rolDAO.FindAll())
            {
                result.Add(mapper.Map<RolGetPutDTO>(rol)); //poner uno o dos es lo mismo <RolDTO, Entities.Rol>
            }
            return result;
        }

        internal RolPostDTO AddRol(RolPostDTO rol)
        {
            Entities.Rol rolEntity = mapper.Map<RolPostDTO, Entities.Rol>(rol);
            this.rolDAO.Save(rolEntity);
            return rol;
        }

        internal void UpdateRolById(RolGetPutDTO rol)
        {
            Entities.Rol rolEntity = mapper.Map<RolGetPutDTO, Entities.Rol>(rol);
            this.rolDAO.Update(rolEntity);
        }



    }
}
