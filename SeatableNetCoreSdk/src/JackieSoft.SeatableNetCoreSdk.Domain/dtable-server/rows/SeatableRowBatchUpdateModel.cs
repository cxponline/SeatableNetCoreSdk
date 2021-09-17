using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableRowBatchUpdateModel : SeatableRowModelBase
    {
        [JsonPropertyName("updates")]
        public List<SeatableRowBatchUpdateItem> Rows { get; set; }
    }
    public class SeatableRowBatchUpdateItem
    {
        [JsonPropertyName("row_id")]
        public string RowId { get; set; }
        [JsonPropertyName("row")]
        public Dictionary<string, object> Row { get; set; }
    }
}
