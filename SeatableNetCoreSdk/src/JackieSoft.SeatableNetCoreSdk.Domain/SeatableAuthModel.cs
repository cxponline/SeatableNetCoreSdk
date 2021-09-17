using System.Text.Json.Serialization;

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public class SeatableAuthModel:SeatableObject
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [JsonPropertyName("username")]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
