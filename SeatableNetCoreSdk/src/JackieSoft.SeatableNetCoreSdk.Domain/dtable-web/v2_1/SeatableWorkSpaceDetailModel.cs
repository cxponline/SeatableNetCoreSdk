
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableWorkSpaceDetailModel 
    {
        [JsonPropertyName("workspace_list")]
        public List<SeatableWorkSpaceDetailItemModel> WorkSpaceList { get; set; }
    }
}
