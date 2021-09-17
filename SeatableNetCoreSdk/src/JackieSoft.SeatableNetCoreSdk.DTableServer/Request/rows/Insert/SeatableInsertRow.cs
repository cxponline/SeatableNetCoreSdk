using JackieSoft.SeatableNetCoreSdk.Domain;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public class SeatableInsertRow : SeatableSingleRowBase
    {
        [JsonPropertyName("anchor_row_id")]
        public string AnchorRowId { get; set; }
    }
}
