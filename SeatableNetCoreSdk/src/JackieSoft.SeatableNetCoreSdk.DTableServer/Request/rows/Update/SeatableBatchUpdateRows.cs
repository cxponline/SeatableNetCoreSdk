using JackieSoft.SeatableNetCoreSdk.Domain;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public class SeatableBatchUpdateRows : SeatableObject
    {
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }
        [JsonPropertyName("updates")]
        public List<SeatableBatchUpdateRow> Rows { get; set; }
    }
    public class SeatableBatchUpdateRow
    {
        [JsonPropertyName("row_id")]
        public string RowId { get; set; }
        [JsonPropertyName("row")]
        public Dictionary<string, object> Row { get; set; }
    }
}
