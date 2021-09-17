
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableRowUpdateModel: SeatableRowModelBase
    {
        [JsonPropertyName("row")]
        public SeatableUpdateRow Row { get; set; }
    }
}
