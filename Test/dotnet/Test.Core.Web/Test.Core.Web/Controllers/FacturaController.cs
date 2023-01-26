using Microsoft.AspNetCore.Mvc;
using Test.Core.Web.Models;
using Test.Core.Web.SpringBoot;

namespace Test.Core.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerServiceBase
    {
        private readonly IFacturaSpringRepository _facturaSpringRepository;

        public FacturaController(IFacturaSpringRepository facturaSpringRepository) 
        {
            _facturaSpringRepository = facturaSpringRepository;
        }

        [HttpGet]
        [Route("ObtenerFactura/{id}")]
        public async Task<ActionResult> ObtenerFactura([FromRoute] int id)
        {
            ObtenerFacturaOutput mFactura = new ObtenerFacturaOutput();
            try
            {
                mFactura = await _facturaSpringRepository.ObtenerFactura(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok(mFactura);
        }

        [HttpPost]
        [Route("AgregarFactura")]
        public async Task<ActionResult> AgregarFactura([FromBody] AgregarFacturaInput input)
        {
            input.idClienteRegistro = this.InformacionUsuario.IdUsuario;
            input.FechaRegistro = DateTime.Now;

            try
            {
                await _facturaSpringRepository.AgregarFactura(input);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut]
        [Route("ActualizarFatura/{id}")]
        public async Task<ActionResult> ActualizarFactura([FromRoute] int id, [FromBody] ActualizarFacturaInput input)
        {

            input.idFactura = id;
            input.idClienteRegistro = this.InformacionUsuario.IdUsuario;
            input.FechaRegistro = DateTime.Now;

            try
            {
                await _facturaSpringRepository.ActualizarFactura(input);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok();
        }

        [HttpDelete]
        [Route("EliminarFactura/{id}")]
        public async Task<ActionResult> EliminarFactura([FromRoute] int id)
        {
            try
            {
                await _facturaSpringRepository.EliminarFactura(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok();
        }
    }
}
