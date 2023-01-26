using Microsoft.AspNetCore.Localization;
using RestSharp;
using Test.Core.Web.Models;

namespace Test.Core.Web.SpringBoot
{
    public class ProductoSpringRepository : IProductoSpringRepository
    {
        private readonly IConfiguration _config;
        private readonly RestClient _client;

        public ProductoSpringRepository(IConfiguration config)
        {
            _config = config;
            _client = new RestClient(_config["EndPointSpring:BaseUrl"]);
        }



        public async Task ActualizarProducto(ActualizarProductoInput input)
        {
            var mResquest = new RestRequest($"producto/{input.idProducto}", Method.Put);
            mResquest.AddJsonBody(input);

            var mResponse = await _client.ExecuteAsync<ObtenerClienteOutput>(mResquest);

            if (!mResponse.IsSuccessStatusCode)
            {
                const string message = "Error al obtener la respuesta. Revise los detalles para obtener mas informacion.";
                var mException = new Exception(message, mResponse.ErrorException);
                throw mException;
            }
        }

        public async Task AgregarProducto(AgregarProductoInput input)
        {
            var mRequest = new RestRequest($"producto", Method.Post);
            mRequest.AddJsonBody(input);

            var mResponse = await _client.ExecuteAsync<ObtenerClienteOutput>(mRequest);

            if (!mResponse.IsSuccessStatusCode)
            {
                const string message = "Error al obtener la respuesta. Revise los detalles para obtener mas informacion.";
                var mException = new Exception(message, mResponse.ErrorException);
                throw mException;
            }
        }

        public async Task EliminarProducto(int id)
        {
            var mRequest = new RestRequest($"producto/{id}", Method.Delete);

            var mResponse = await _client.ExecuteAsync(mRequest);

            if (!mResponse.IsSuccessStatusCode)
            {
                const string message = "Error al obtener la respuesta. Revise los detalles para obtener mas informacion.";
                var mException = new Exception(message, mResponse.ErrorException);
                throw mException;
            }
        }

        public async Task<ObtenerProductoOutput> ObtenerProducto(int id)
        {
            var mRequest = new RestRequest($"producto/{id}", Method.Get);

            var mResponse = await _client.ExecuteAsync<ObtenerProductoOutput>(mRequest);

            if (mResponse.ErrorException != null)
            {
                const string message = "Error al obtener la respuesta. Revise los detalles para obtener mas informacion.";
                var mException = new Exception(message, mResponse.ErrorException);
                throw mException;
            }

            return mResponse.Data;
        }
    }
}
