using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Core.Web.Models;
using Test.Core.Web.SpringBoot;

namespace Test.Core.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerServiceBase
    {
        private readonly IProductoSpringRepository _productoRepository;

        public ProductoController(IProductoSpringRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [HttpGet]
        [Route("ObtenerProducto/{id}")]
        public async Task<ActionResult> ObtenerProducto([FromRoute] int id)
        {
            ObtenerProductoOutput mProducto = new ObtenerProductoOutput();

            try
            {
                mProducto = await _productoRepository.ObtenerProducto(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok(mProducto);
        }

        [HttpPost]
        [Route("AgregarProducto")]
        public async Task<ActionResult> AgregarProducto([FromBody] AgregarProductoInput input)
        {
            try
            {
                await _productoRepository.AgregarProducto(input);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok();
        }

        [HttpPut]
        [Route("ActualizarProducto/{id}")]
        public async Task<ActionResult> ActualizarProducto([FromRoute] int id, [FromRoute] ActualizarProductoInput input)
        {
            input.idProducto = id;

            try
            {
                await _productoRepository.ActualizarProducto(input);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete]
        [Route("EliminarProducto/{id}")]
        public async Task<ActionResult> EliminarProducto([FromRoute] int id)
        {
            try
            {
                await _productoRepository.EliminarProducto(id);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
