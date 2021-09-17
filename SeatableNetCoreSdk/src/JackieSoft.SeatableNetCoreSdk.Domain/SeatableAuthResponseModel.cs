using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableAuthResponseModel
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
