

using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableRowDeleteModel : SeatableRowModelBase
    {
        [JsonPropertyName("row_id")]
        public string RowId { get; set; }
    }
}
