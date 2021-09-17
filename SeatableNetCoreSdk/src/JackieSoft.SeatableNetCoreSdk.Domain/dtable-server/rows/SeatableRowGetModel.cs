
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableRowGetModel : SeatableRowModelBase
    {
        [JsonIgnore]
        [JsonPropertyName("row_id")]
        public string RowId { get; set; }
        [JsonPropertyName("table_id")]
        public string TableId { get; set; }
    }
}
