using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableRowAppendModel : SeatableRowModelBase
    {
        [JsonPropertyName("row")]
        public Dictionary<string, object> Row { get; set; }
    }
}
