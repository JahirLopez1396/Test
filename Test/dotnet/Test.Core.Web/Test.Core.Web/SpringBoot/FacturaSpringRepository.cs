using Microsoft.AspNetCore.Localization;
using RestSharp;
using Test.Core.Web.Models;

namespace Test.Core.Web.SpringBoot
{
    public class FacturaSpringRepository : IFacturaSpringRepository
    {
        private readonly IConfiguration _config;
        private RestClient _client;
        public FacturaSpringRepository(IConfiguration config)
        {
            _config = config;
            _client = new RestClient(_config["EndPointSpring:BaseUrl"]);
        }


        public async Task ActualizarFactura(ActualizarFacturaInput input)
        {
            var mResquest = new RestRequest($"factura/{input.idFactura}", Method.Put);
            mResquest.AddJsonBody(input);

            var mResponse = await _client.ExecuteAsync<ObtenerFacturaOutput>(mResquest);

            if (!mResponse.IsSuccessStatusCode)
            {
                const string message = "Error al obtener la respuesta. Revise los detalles para obtener mas informacion.";
                var mException = new Exception(message, mResponse.ErrorException);
                throw mException;
            }
        }

        public async Task AgregarFactura(AgregarFacturaInput input)
        {
            var mRequest = new RestRequest($"/factura",Method.Put);
            mRequest.AddJsonBody(input);

            var mResponse = await _client.ExecuteAsync<ObtenerFacturaOutput>(mRequest);

            if (!mResponse.IsSuccessStatusCode)
            {
                const string message = "Error al obtener la respuesta. Revise los detalles para obtener mas informacion.";
                var mException = new Exception(message, mResponse.ErrorException);
                throw mException;
            }
        }

        public async Task EliminarFactura(int id)
        {
            var mRequest = new RestRequest($"factura/{id}", Method.Delete);

            var mResponse = await _client.ExecuteAsync(mRequest);

            if (!mResponse.IsSuccessStatusCode)
            {
                const string message = "Error al obtener la respuesta. Revise los detalles para obtener mas informacion.";
                var mException = new Exception(message, mResponse.ErrorException);
                throw mException;
            }
        }

        public async Task<ObtenerFacturaOutput> ObtenerFactura(int id)
        {
            var mRequest = new RestRequest($"factura/{id}", Method.Get);

            var mResponse = await _client.ExecuteAsync<ObtenerFacturaOutput>(mRequest);

            if (!mResponse.IsSuccessStatusCode)
            {
                const string message = "Error al obtener la respuesta. Revise los detalles para obtener mas informacion.";
                var mException = new Exception(message, mResponse.ErrorException);
                throw mException;
            }

            return mResponse.Data;
        }
    }
}
