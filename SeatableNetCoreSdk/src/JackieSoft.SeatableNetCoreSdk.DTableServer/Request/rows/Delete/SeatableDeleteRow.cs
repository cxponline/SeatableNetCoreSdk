using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public class SeatableDeleteRow:SeatableDeleteRowBase
    {
        [JsonPropertyName("row_id")]
        public string RowId { get; set; }
    }
}
