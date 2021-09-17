using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableCheckTokenResponseModel
    {
        public bool Success { get; set; }
        [JsonPropertyName("detail")]
        public string Detail { get; set; }
    }
}
