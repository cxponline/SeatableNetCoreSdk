using JackieSoft.SeatableNetCoreSdk.Domain;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public class SeatableRowLock : SeatableObject
    {
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }
        [JsonPropertyName("row_ids")]
        public List<string> RowIds { get; set; }
    }
}
