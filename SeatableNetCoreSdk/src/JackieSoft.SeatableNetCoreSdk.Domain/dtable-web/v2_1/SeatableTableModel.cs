using System;
using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableTableModel
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        [JsonPropertyName("workspace_id")]
        public long WorkSpaceId { get; set; }
        [JsonPropertyName("uuid")]
        public string UUID { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("creator")]
        public string Creator { get; set; }
        [JsonPropertyName("modifier")]
        public string Modifier { get; set; }
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedTime { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedTime { get; set; }
        [JsonPropertyName("color")]
        public string Color { get; set; }
        [JsonPropertyName("text_color")]
        public string TextColor { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
        [JsonPropertyName("starred")]
        public Boolean Starred { get; set; }
    }
}
