using JackieSoft.SeatableNetCoreSdk.Domain;
using System;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace JackieSoft.SeatableNetCoreSdk.Shared
{
    public class SeatableResponseJsonParser<T> where T : SeatableResponse
    {
        private static readonly JsonSerializerOptions jsonSerializerOptions = new() { IgnoreNullValues = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };

        public T Parse(string body, int statusCode)
        {
            T result = null;

            try
            {
                if (body.StartsWith("{") && body.EndsWith("}"))
                {
                    result = JsonSerializer.Deserialize<T>(body, jsonSerializerOptions);
                }
            }
            catch { }

            if (result == null)
            {
                result = Activator.CreateInstance<T>();
            }

            result.Body = body;
            result.StatusCode = statusCode;
            return result;
        }
    }
}