using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableRowListResponseModel
    {
        [JsonPropertyName("rows")]
        public List<Dictionary<string, object>> Rows { get; set; }
    }
}
