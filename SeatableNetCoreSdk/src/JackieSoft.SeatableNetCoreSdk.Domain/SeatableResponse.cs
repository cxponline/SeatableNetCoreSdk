using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    /// <summary>
    /// 响应对象
    /// </summary>
    public class SeatableResponse : SeatableObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [JsonIgnore]
        public string Body { get; set; }
        /// <summary>
        /// HTTP状态码
        /// </summary>
        [JsonIgnore]
        public int StatusCode { get; set; }
    }
}
