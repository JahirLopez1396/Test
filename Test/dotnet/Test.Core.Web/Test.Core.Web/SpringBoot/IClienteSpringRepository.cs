using Test.Core.Web.Models;

namespace Test.Core.Web.SpringBoot
{
    public interface IClienteSpringRepository
    {
        Task<ObtenerClienteOutput> ObtenerCliente(int id);
        Task AgregarCliente(AgregarClienteInput input);
        Task ActualizarCliente(ActualizarClienteInput input);
        Task EliminarCliente(int id);
    }
}
