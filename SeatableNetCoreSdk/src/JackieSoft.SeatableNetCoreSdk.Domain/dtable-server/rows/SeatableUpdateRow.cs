
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableUpdateRow : SeatableSingleRowBase
    {
        [JsonPropertyName("row_id")]
        public string RowId { get; set; }        
    }
}
