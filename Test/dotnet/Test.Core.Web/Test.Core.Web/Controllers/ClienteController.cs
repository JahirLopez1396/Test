using Microsoft.AspNetCore.Mvc;
using Test.Core.Web.Models;
using Test.Core.Web.SpringBoot;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test.Core.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerServiceBase
    {
        private readonly IClienteSpringRepository _springBootRepository;

        public ClienteController(IClienteSpringRepository springBootRepository)
        {
            _springBootRepository = springBootRepository;
        }


        // GET: api/<ClienteController>
        [HttpGet]
        [Route("ObtenerCliente/{id}")]
        public async Task<ActionResult> ObtenerCliente([FromRoute] int id)
        {
            ObtenerClienteOutput mCliente = new ObtenerClienteOutput();
            try
            {
                mCliente = await _springBootRepository.ObtenerCliente(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            

            return Ok(mCliente);
        }

        [HttpPost]
        [Route("AgregarCliente")]
        public async Task<ActionResult> CrearCliente([FromBody] AgregarClienteInput input)
        {
            try
            {
                await _springBootRepository.AgregarCliente(input);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }           

            return Ok();
            
        }

        [HttpPut]
        [Route("EditarCliente/{id}")]
        public async Task<ActionResult> EditarCliente([FromRoute] int id, [FromBody] ActualizarClienteInput input)
        {
            input.idCliente = id;

            try
            {
                await _springBootRepository.ActualizarCliente(input);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }            

            return Ok();
        }

        [HttpDelete]
        [Route("EliminarCliente/{id}")]
        public async Task<ActionResult> EliminarCliente([FromRoute] int id)
        {
            try
            {
                await _springBootRepository.EliminarCliente(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok();
            
        }
    }
}
