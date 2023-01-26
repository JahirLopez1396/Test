namespace Test.Core.Web.Models
{
    public class ObtenerFacturaOutput
    {
        public DateTime fechaRegistro { get; set; }

        public int idClienteRegistro { get; set; }

        public int idFactura { get; set; }

        public int idProducto { get; set; }
    }

    public class AgregarFacturaInput
    {
        public int? idProducto { get; set; }
        public int idClienteRegistro { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }

    public class ActualizarFacturaInput
    {
        public int idFactura { get; set; }
        public int idProducto { get; set; }
        public int idClienteRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
