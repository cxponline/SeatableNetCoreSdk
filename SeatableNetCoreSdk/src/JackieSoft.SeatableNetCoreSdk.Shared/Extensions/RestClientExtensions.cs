using RestSharp;
using JackieSoft.SeatableNetCoreSdk.Domain;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace JackieSoft.SeatableNetCoreSdk.Shared
{
    public static class RestClientExtensions
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new() { IgnoreNullValues = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

        public static async Task<(string body, int statusCode)> GetAsync<T>(this RestClient client, ISeatableGetRequest<T> request, string token = null) where T : SeatableResponse
        {
            client.Timeout = -1;
            var url = request.GetRequestUrl();

            if (request.GetNeedQueryModel())
            {
                var queryModel = request.GetParamModel();
                if (queryModel != null)
                {
                    if (url.Contains("?"))
                    {
                        var txtParams = ConvertToDictionary(queryModel);
                        url += "&" + SeatableUtility.BuildQuery(txtParams);
                    }
                    else
                    {
                        var txtParams = ConvertToDictionary(queryModel);
                        url += "?" + SeatableUtility.BuildQuery(txtParams);
                    }
                }
            }
            client.BaseUrl = new System.Uri(url);
            var req = new RestRequest(Method.GET);
            req.AddHeader("Authorization", $"Token {token}");

            IRestResponse resp = await client.ExecuteAsync(req);
            var body = resp.Content;
            var statusCode = (int)resp.StatusCode;
            return (body, statusCode);
        }

        public static async Task<(string body, int statusCode)> PostAsync<T>(this RestClient client, ISeatablePostRequest<T> request, string token = null) where T : SeatableResponse
        {
            client.Timeout = -1;
            var url = request.GetRequestUrl();
            var bodyModel = request.GetParamModel();
            if (bodyModel == null)
            {
                throw new SeatableException("request.BodyModel is null!");
            }
            client.BaseUrl = new System.Uri(url);
            var req = new RestRequest(Method.POST);
            req.AddHeader("Authorization", $"Token {token}");
            req.AddHeader("Content-Type", "application/json");

            var content = JsonSerializer.Serialize(bodyModel, bodyModel.GetType(), jsonSerializerOptions);
            req.AddParameter("application/json", content, ParameterType.RequestBody);
            IRestResponse resp = await client.ExecuteAsync(req);
            var body = resp.Content;
            var statusCode = (int)resp.StatusCode;
            return (body, statusCode);
        }
        public static async Task<(string body, int statusCode)> PutAsync<T>(this RestClient client, ISeatablePutRequest<T> request, string token = null) where T : SeatableResponse
        {
            client.Timeout = -1;
            var url = request.GetRequestUrl();
            var bodyModel = request.GetParamModel();
            if (bodyModel == null)
            {
                throw new SeatableException("request.BodyModel is null!");
            }
            client.BaseUrl = new System.Uri(url);
            var req = new RestRequest(Method.PUT);
            req.AddHeader("Authorization", $"Token {token}");
            req.AddHeader("Content-Type", "application/json");

            var content = JsonSerializer.Serialize(bodyModel, bodyModel.GetType(), jsonSerializerOptions);
            req.AddParameter("application/json", content, ParameterType.RequestBody);
            IRestResponse resp = await client.ExecuteAsync(req);
            var body = resp.Content;
            var statusCode = (int)resp.StatusCode;
            return (body, statusCode);
        }
        public static async Task<(string body, int statusCode)> DeleteAsync<T>(this RestClient client, ISeatableDeleteRequest<T> request, string token = null) where T : SeatableResponse
        {
            client.Timeout = -1;
            var url = request.GetRequestUrl();
            var bodyModel = request.GetParamModel();
            if (bodyModel == null)
            {
                throw new SeatableException("request.BodyModel is null!");
            }
            client.BaseUrl = new System.Uri(url);
            var req = new RestRequest(Method.DELETE);
            req.AddHeader("Authorization", $"Token {token}");
            req.AddHeader("Content-Type", "application/json");

            var content = JsonSerializer.Serialize(bodyModel, bodyModel.GetType(), jsonSerializerOptions);
            req.AddParameter("application/json", content, ParameterType.RequestBody);
            IRestResponse resp = await client.ExecuteAsync(req);
            var body = resp.Content;
            var statusCode = (int)resp.StatusCode;
            return (body, statusCode);
        }
        private static IDictionary<string, string> ConvertToDictionary(SeatableObject obj)
        {
            var str = JsonSerializer.Serialize(obj, obj.GetType(), jsonSerializerOptions);
            return JsonSerializer.Deserialize<IDictionary<string, string>>(str, jsonSerializerOptions);
        }
    }
}