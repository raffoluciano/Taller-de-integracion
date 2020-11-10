using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api.Services;
using Api.DTOs;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService usuarioService;

        public UsuarioController(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        /// <summary>
        /// Trae todos los usuarios
        /// </summary>
        /// <returns>Lista de usuarios</returns>
        /// <remarks> Trae las usuarioes en formato json en una lista </remarks>
        /// <response code="200">Todo Correcto</response>
        /// <response code="400">Bad Getway</response>
        
        [HttpGet]
        [Route("/usuario/Get")]
        [Produces("application/json", Type = typeof(UsuarioGetPutDTO))]

        public IActionResult GetUsuarios()
        {
            return Ok(usuarioService.GetUsuarios());
        }

        /// <summary>
        /// Post de un usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [Route("usuario/Post")]
        [HttpPost]
        public IActionResult Post([FromBody] UsuarioPostDTO usuario)
        {
            UsuarioPostDTO usuarioResult = this.usuarioService.AddUsuario(usuario);
            return Ok(usuarioResult);
        }

        /// <summary>
        /// Actualiza un Usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <remarks> Actualiza una usuario mediante el id de esta </remarks>
        /// <returns></returns>
        [HttpPut]
        [Route("/usuario/Put")]

        public IActionResult Update([FromBody] UsuarioGetPutDTO usuario)
        {
            this.usuarioService.UpdateUsuarioById(usuario);
            return Ok();
        }

        ////////////////////////////////////////////////Direccion//////////////////////////////////////////////////////

        /// <summary>
        /// Trae todas las direcciones
        /// </summary>
        /// <returns>Lista de direcciones</returns>
        /// <remarks> Trae las direcciones en formato json en una lista </remarks>
        /// <response code="200">Todo Correcto</response>
        /// <response code="400">Bad Getway</response>
        [HttpGet]
        [Route("direccion/Get")]
        [Produces("application/json", Type = typeof(DireccionGetPutDTO))]

        public IActionResult GetDirecciones()
        {
            return Ok(usuarioService.GetDirecciones());
        }

        /// <summary>
        /// Post de una direccion
        /// </summary>
        /// <param name="direccion"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("direccion/Post")]

        public IActionResult Post([FromBody] DireccionPostDTO direccion)
        {
            DireccionPostDTO direccionResult = this.usuarioService.AddDireccion(direccion);
            return Ok(direccionResult);
        }

        /// <summary>
        /// Actualiza una direccion
        /// </summary>
        /// <param name="direccion"></param>
        /// <remarks> Actualiza una direccion mediante el id de esta </remarks>
        /// <returns></returns>
        [HttpPut]
        [Route("direccion/Put")]

        public IActionResult Update([FromBody] DireccionGetPutDTO direccion)
        {
            this.usuarioService.UpdateDireccionById(direccion);
            return Ok();
        }

        //////////////////////////////////////////////////Roles////////////////////////////////////////////////

        /// <summary>
        /// Trae todas las roles
        /// </summary>
        /// <returns>Lista de roles</returns>
        /// <remarks> Trae las roles en formato json en una lista </remarks>
        /// <response code="200">Todo Correcto</response>
        /// <response code="400">Bad Getway</response>
        [HttpGet]
        [Route("rol/Get")]
        [Produces("application/json", Type = typeof(RolGetPutDTO))]

        public IActionResult Get()
        {
            return Ok(usuarioService.GetRoles());
        }

        /// <summary>
        /// Post de una rol
        /// </summary>
        /// <param name="rol"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("rol/Post")]

        public IActionResult Post([FromBody] RolPostDTO rol)
        {
            RolPostDTO rolResult = this.usuarioService.AddRol(rol);
            return Ok(rolResult);
        }

        /// <summary>
        /// Actualiza una rol
        /// </summary>
        /// <param name="rol"></param>
        /// <remarks> Actualiza una rol mediante el id de esta </remarks>
        /// <returns></returns>
        [HttpPut]
        [Route("rol/Put")]

        public IActionResult Update([FromBody] RolGetPutDTO rol)
        {
            this.usuarioService.UpdateRolById(rol);
            return Ok();
        }

    }
}
