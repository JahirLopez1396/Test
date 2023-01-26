using Test.Core.Web.Models;

namespace Test.Core.Web.SpringBoot
{
    public interface IProductoSpringRepository
    {
        Task<ObtenerProductoOutput> ObtenerProducto(int id);
        Task AgregarProducto(AgregarProductoInput input);
        Task ActualizarProducto(ActualizarProductoInput input);
        Task EliminarProducto(int id);
    }
}
