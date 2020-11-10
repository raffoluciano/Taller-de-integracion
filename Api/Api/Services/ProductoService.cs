using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.DAO;
using Api.DTOs;
using AutoMapper;

namespace Api.Services
{
    public class ProductoService
    {
        private readonly ProductoDAO productoDAO;
        private readonly DescuentoDAO descuentoDAO;
        private readonly IMapper mapper;

        public ProductoService(ProductoDAO productoDAO, DescuentoDAO descuentoDAO, IMapper mapper)
        {
            this.productoDAO = productoDAO;
            this.descuentoDAO = descuentoDAO;
            this.mapper = mapper;
        }

        //////////////////////////////////Producto/////////////////////////////////
        
         internal IList<ProductoGetPutDTO> GetProductoes()
        {
            List<ProductoGetPutDTO> result = new List<ProductoGetPutDTO>();
            foreach (var producto in productoDAO.FindAll())
            {
                result.Add(mapper.Map<ProductoGetPutDTO>(producto)); //poner uno o dos es lo mismo <ProductoDTO, Entities.Producto>
            }
            return result;
        }

        internal ProductoPostDTO AddProducto(ProductoPostDTO producto)
        {
            Entities.Producto productoEntity = mapper.Map<ProductoPostDTO, Entities.Producto>(producto);
            this.productoDAO.Save(productoEntity);
            return producto;
        }

        internal void UpdateProductoById(ProductoGetPutDTO producto)
        {
            Entities.Producto productoEntity = mapper.Map<ProductoGetPutDTO, Entities.Producto>(producto);
            this.productoDAO.Update(productoEntity);
        }

        ///////////////////////////////Descuento/////////////////////////////////////////

        internal IList<DescuentoGetPutDTO> GetDescuento()
        {
            List<DescuentoGetPutDTO> result = new List<DescuentoGetPutDTO>();
            foreach (var descuento in descuentoDAO.FindAll())
            {
                result.Add(mapper.Map<DescuentoGetPutDTO>(descuento)); //poner uno o dos es lo mismo <DescuentoDTO, Entities.Descuento>
            }
            return result;
        }

        internal DescuentoPostDTO AddDescuento(DescuentoPostDTO descuento)
        {
            Entities.Descuento descuentoEntity = mapper.Map<DescuentoPostDTO, Entities.Descuento>(descuento);
            this.descuentoDAO.Save(descuentoEntity);
            return descuento;
        }

        internal void UpdateDescuentoById(DescuentoGetPutDTO descuento)
        {
            Entities.Descuento descuentoEntity = mapper.Map<DescuentoGetPutDTO, Entities.Descuento>(descuento);
            this.descuentoDAO.Update(descuentoEntity);
        }

    }
}
