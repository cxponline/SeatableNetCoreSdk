using JackieSoft.SeatableNetCoreSdk.Domain;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public class SeatableDeleteRowBase:SeatableObject
    {
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }
    }
}
