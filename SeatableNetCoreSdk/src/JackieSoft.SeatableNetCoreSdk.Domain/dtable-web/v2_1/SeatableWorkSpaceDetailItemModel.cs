
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableWorkSpaceDetailItemModel: SeatableWorkSpaceItemModel
    {
        [JsonPropertyName("table_list")]
        public List<SeatableTableModel> TableList { get; set; }
    }
}
