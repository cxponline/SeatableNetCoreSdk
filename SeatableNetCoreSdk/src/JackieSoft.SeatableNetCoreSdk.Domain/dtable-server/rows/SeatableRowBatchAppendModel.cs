using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableRowBatchAppendModel : SeatableRowModelBase
    {
        [JsonPropertyName("rows")]
        public List<Dictionary<string, object>> Rows { get; set; }
    }
}
