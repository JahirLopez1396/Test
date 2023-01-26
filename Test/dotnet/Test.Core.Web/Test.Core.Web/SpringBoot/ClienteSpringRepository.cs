using RestSharp;
using RestSharp.Authenticators;
using Test.Core.Web.Models;

namespace Test.Core.Web.SpringBoot
{
    public class ClienteSpringRepository : IClienteSpringRepository
    {
        private readonly IConfiguration _config;
        private readonly RestClient _client;

        public ClienteSpringRepository(IConfiguration config)
        {
            _config = config;
            _client = new RestClient(_config["EndPointSpring:BaseUrl"]);
        }

        public async Task<ObtenerClienteOutput> ObtenerCliente(int id)
        {
            var mRequest = new RestRequest($"cliente/{id}",Method.Get);

            var mResponse = await _client.ExecuteAsync<ObtenerClienteOutput>(mRequest);

            if (mResponse.ErrorException != null)
            {
                const string message = "Error al obtener la respuesta. Revise los detalles para obtener mas informacion.";
                var mException = new Exception(message, mResponse.ErrorException);
                throw mException;
            }

            return mResponse.Data;
        }

        public async Task AgregarCliente(AgregarClienteInput input)
        {
            var mRequest = new RestRequest($"cliente", Method.Post);
            mRequest.AddJsonBody(input);

            var mResponse = await _client.ExecuteAsync<ObtenerClienteOutput>(mRequest);

            if (mResponse.ErrorException != null)
            {
                const string message = "Error al obtener la respuesta. Revise los detalles para obtener mas informacion.";
                var mException = new Exception(message, mResponse.ErrorException);
                throw mException;
            }
        }

        public async Task ActualizarCliente(ActualizarClienteInput input)
        {
            var mRequest = new RestRequest($"cliente/{input.idCliente}", Method.Put);
            mRequest.AddJsonBody(input);

            var mResponse = await _client.ExecuteAsync<ObtenerClienteOutput>(mRequest);

            if (mResponse.ErrorException != null)
            {
                const string message = "Error al obtener la respuesta. Revise los detalles para obtener mas informacion.";
                var mException = new Exception(message, mResponse.ErrorException);
                throw mException;
            }
        }

        public async Task EliminarCliente(int id)
        {
            var mRequest = new RestRequest($"cliente/{id}", Method.Delete);

            var mResponse = await _client.ExecuteAsync(mRequest);

            if (mResponse.ErrorException != null)
            {
                const string message = "Error al obtener la respuesta. Revise los detalles para obtener mas informacion.";
                var mException = new Exception(message, mResponse.ErrorException);
                throw mException;
            }
        }
    }
}
