using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableBaseAccessTokenResponseModel
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
        [JsonPropertyName("dtable_uuid")]
        public string DTableUuid { get; set; }
        [JsonPropertyName("dtable_server")]
        public string DtableServer { get; set; }
        [JsonPropertyName("dtable-db")]
        public string DTableDb { get; set; }
        [JsonPropertyName("dtable_socket")]
        public string DTableSocket { get; set; }
    }
}
