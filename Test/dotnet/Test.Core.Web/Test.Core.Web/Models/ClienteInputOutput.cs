using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Core.Web.Models
{
    public class ObtenerClienteOutput
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
    }

    public class AgregarClienteInput
    {        
        [Required]
        [StringLength(45, ErrorMessage = "El nombre no puede ser mayor a 45 caracteres")]
        public string nombre { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "El apellido no puede ser mayor a 45 caracteres")]
        public string apellido { get; set; }

        [StringLength(45, ErrorMessage = "La dirección no puede ser mayor a 45 caracteres")]
        public string direccion { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "El número telefónico no debe exceder los 10 caracteres")]
        public string telefono { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El email no debe exceder los 50 caracteres")]
        public string email { get; set; }

        public bool? esFrecuente { get; set; }
    }

    public class ActualizarClienteInput
    {
        public int idCliente { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "El nombre no puede ser mayor a 45 caracteres")]
        public string nombre { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "El apellido no puede ser mayor a 45 caracteres")]
        public string apellido { get; set; }

        [StringLength(45, ErrorMessage = "La dirección no puede ser mayor a 45 caracteres")]
        public string direccion { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "El número telefónico no debe exceder los 10 caracteres")]
        public string telefono { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El email no debe exceder los 50 caracteres")]
        public string email { get; set; }

        public bool? esFrecuente { get; set; }
    }

    
    
}
