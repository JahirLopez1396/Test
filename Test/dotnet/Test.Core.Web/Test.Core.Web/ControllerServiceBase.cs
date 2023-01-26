using Microsoft.AspNetCore.Mvc;
using Test.Core.Web;

namespace Test.Core.Web
{
    public class ControllerServiceBase : ControllerBase
    {
        public readonly InformacionUsuario InformacionUsuario;

        public ControllerServiceBase()
        {
            InformacionUsuario = new InformacionUsuario
            {
                IdUsuario = 1,
                Nombre = "Jahir",
                Email = "jahir.ilv13@gmail.com"
            };
        }

    }
}
