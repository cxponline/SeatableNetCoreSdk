using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableMultiRowBase : SeatableObject
    {
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }
        [JsonPropertyName("rows")]
        public List<Dictionary<string, object>> Rows { get; set; }
    }
}
