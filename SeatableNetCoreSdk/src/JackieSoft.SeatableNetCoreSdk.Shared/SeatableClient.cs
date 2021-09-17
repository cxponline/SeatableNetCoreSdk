using RestSharp;
using JackieSoft.SeatableNetCoreSdk.Domain;
using System.Net.Http;
using System.Threading.Tasks;

namespace JackieSoft.SeatableNetCoreSdk.Shared
{
    public class SeatableClient : ISeatableClient
    {
        private RestClient client;

        #region SeatableClient Constructors

        public SeatableClient()
        {
            client = new RestClient();
        }

        #endregion       

        #region ISeatableClient Members

        public async Task<T> ExecuteAsync<T>(ISeatableGetRequest<T> request, string token = null) where T : SeatableResponse
        {                        
            var (body, statusCode) = await client.GetAsync(request, token);
            var parser = new SeatableResponseJsonParser<T>();
            var response = parser.Parse(body, statusCode);
            return response;
        }


        public async Task<T> ExecuteAsync<T>(ISeatablePostRequest<T> request, string token = null) where T : SeatableResponse
        {           
            var (body, statusCode) = await client.PostAsync(request, token);
            var parser = new SeatableResponseJsonParser<T>();
            var response = parser.Parse(body, statusCode);
            return response;
        }

        public async Task<T> ExecuteAsync<T>(ISeatablePutRequest<T> request, string token = null) where T : SeatableResponse
        {           
            var (body, statusCode) = await client.PutAsync(request, token);
            var parser = new SeatableResponseJsonParser<T>();
            var response = parser.Parse(body, statusCode);
            return response;
        }

        public async Task<T> ExecuteAsync<T>(ISeatableDeleteRequest<T> request, string token = null) where T : SeatableResponse
        {           
            var (body, statusCode) = await client.DeleteAsync(request, token);
            var parser = new SeatableResponseJsonParser<T>();
            var response = parser.Parse(body, statusCode);
            return response;
        }
        #endregion       
    }
}
