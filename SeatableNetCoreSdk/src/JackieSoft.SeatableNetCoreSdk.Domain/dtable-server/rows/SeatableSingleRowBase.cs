using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableSingleRowBase : SeatableObject
    {
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }
        [JsonPropertyName("row")]
        public Dictionary<string, object> Row { get; set; }
    }
}
