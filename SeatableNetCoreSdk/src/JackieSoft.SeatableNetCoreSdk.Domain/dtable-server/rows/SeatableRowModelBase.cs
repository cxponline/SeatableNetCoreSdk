using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public abstract class SeatableRowModelBase : SeatableObject
    {        
        [JsonPropertyName("dtable_uuid")]
        public string DTableUuid;        
        [JsonPropertyName("table_name")]
        public string TableName { get; set; }
    }
}
