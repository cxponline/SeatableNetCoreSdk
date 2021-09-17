
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableWorkSpaceModel
    {
        [JsonPropertyName("workspace_list")]
        public List<SeatableWorkSpaceItemModel> WorkSpaceList { get; set; }
    }
}
