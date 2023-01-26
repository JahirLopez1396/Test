using Test.Core.Web.Models;

namespace Test.Core.Web.SpringBoot
{
    public interface IFacturaSpringRepository
    {
        Task<ObtenerFacturaOutput> ObtenerFactura(int id);
        Task AgregarFactura(AgregarFacturaInput input);
        Task ActualizarFactura(ActualizarFacturaInput input);
        Task EliminarFactura(int id);
    }
}
