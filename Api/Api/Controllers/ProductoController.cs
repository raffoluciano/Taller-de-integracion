using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api.Services;
using Api.DTOs;
using Microsoft.AspNetCore.Authentication;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/productos")]

    public class ProductoController : ControllerBase
    {
        private readonly ProductoService productoService;

        public ProductoController(ProductoService productoService)
        {
            this.productoService = productoService;
        }

        ////////////////////////////////////////Producto////////////////////////////
        ///
        /// <summary>
        /// Trae todas las productos
        /// </summary>
        /// <returns>Lista de productoes</returns>
        /// <remarks> Trae las productoes en formato json en una lista </remarks>
        /// <response code="200">Todo Correcto</response>
        /// <response code="400">Bad Getway</response>
        [HttpGet]
        [Route("producto/get")]
        [Produces("application/json", Type = typeof(ProductoGetPutDTO))]

        public IActionResult Get()
        {
            return Ok(productoService.GetProductoes());
        }

        /// <summary>
        /// Post de una producto
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("producto/post")]

        public IActionResult Post([FromBody] ProductoPostDTO producto)
        {
            ProductoPostDTO productoResult = this.productoService.AddProducto(producto);
            return Ok(productoResult);
        }

        /// <summary>
        /// Actualiza una producto
        /// </summary>
        /// <param name="producto"></param>
        /// <remarks> Actualiza una producto mediante el id de esta </remarks>
        /// <returns></returns>
        [HttpPut]
        [Route("producto/Put")]

        public IActionResult Update([FromBody] ProductoGetPutDTO producto)
        {
            this.productoService.UpdateProductoById(producto);
            return Ok();
        }

        ///////////////////////////////////////Descuentos/////////////////////////////////////////

        /// <summary>
        /// Trae todas las descuentoes
        /// </summary>
        /// <returns>Lista de descuentoes</returns>
        /// <remarks> Trae las descuentoes en formato json en una lista </remarks>
        /// <response code="200">Todo Correcto</response>
        /// <response code="400">Bad Getway</response>
        [HttpGet]
        [Route("descuento/get")]
        [Produces("application/json", Type = typeof(DescuentoGetPutDTO))]

        public IActionResult GetDescuento()
        {
            return Ok(productoService.GetDescuento());
        }

        /// <summary>
        /// Post de una descuento
        /// </summary>
        /// <param name="descuento"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("descuento/post")]

        public IActionResult Post([FromBody] DescuentoPostDTO descuento)
        {
            DescuentoPostDTO descuentoResult = this.productoService.AddDescuento(descuento);
            return Ok(descuentoResult);
        }

        /// <summary>
        /// Actualiza una descuento
        /// </summary>
        /// <param name="descuento"></param>
        /// <remarks> Actualiza una descuento mediante el id de esta </remarks>
        /// <returns></returns>
        [HttpPut]
        [Route("descuento/Put")]

        public IActionResult Update([FromBody] DescuentoGetPutDTO descuento)
        {
            this.productoService.UpdateDescuentoById(descuento);
            return Ok();
        }
    }
}
