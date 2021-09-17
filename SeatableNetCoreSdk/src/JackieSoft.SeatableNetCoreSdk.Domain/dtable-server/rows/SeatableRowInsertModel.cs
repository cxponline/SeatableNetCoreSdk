using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableRowInsertModel : SeatableRowModelBase
    {
        [JsonPropertyName("row")]
        public Dictionary<string, object> Row { get; set; }
        [JsonPropertyName("anchor_row_id")]
        public string AnchorRowId { get; set; }
    }
}
