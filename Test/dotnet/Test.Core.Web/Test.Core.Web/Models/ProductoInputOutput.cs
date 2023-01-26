
using System.ComponentModel.DataAnnotations;

namespace Test.Core.Web.Models
{
    public class ObtenerProductoOutput
    {
        public string nombre { get; set; }
        public double precio { get; set; }
    }

    public class AgregarProductoInput
    {
        [Required]
        [StringLength(50, ErrorMessage = "El nombre no debe de exceder a 50 caracteres")]
        public string nombre { get; set; }

        public double precio { get; set; }

        public int stock { get; set; }
    }

    public class ActualizarProductoInput
    {
        public int idProducto { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El nombre no debe de exceder a 50 caracteres")]
        public string nombre { get; set; }

        public double precio { get; set; }

        public int stock { get; set; }
    }
}
