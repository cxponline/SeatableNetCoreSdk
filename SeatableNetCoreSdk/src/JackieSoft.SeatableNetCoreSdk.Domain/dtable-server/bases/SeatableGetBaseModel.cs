using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableGetBaseModel : SeatableObject
    {
        [JsonPropertyName("dtable_uuid")]
        public string DTableUuid;
    }
}
