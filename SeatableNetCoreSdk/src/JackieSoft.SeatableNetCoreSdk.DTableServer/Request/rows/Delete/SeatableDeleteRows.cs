using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public class SeatableDeleteRows : SeatableDeleteRowBase
    {
        [JsonPropertyName("row_ids")]
        public List<string> RowIds { get; set; }
    }
}
