using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public abstract class SeatableObject
    {
        [JsonIgnore]
        public string Token { get; set; }
    }
}
