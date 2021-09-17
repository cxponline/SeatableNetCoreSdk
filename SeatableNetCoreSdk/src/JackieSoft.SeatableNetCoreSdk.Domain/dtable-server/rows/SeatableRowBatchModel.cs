using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableRowBatchModel : SeatableRowModelBase
    {
        [JsonPropertyName("row_ids")]
        public List<string> RowIds { get; set; }
    }
}
