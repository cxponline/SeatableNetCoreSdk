
using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.Shared;

namespace JackieSoft.SeatableNetCoreSdk.Auth
{
    /// <summary>
    /// 全局 API-获取 API check token
    /// </summary>
    /// <remarks>
    /// <para><a href="https://docs.seatable.cn/published/seatable-api/home.md"></para>
    /// </remarks>
    public class SeatableCheckTokenRequest : SeatableRequestBase, ISeatableGetRequest<SeatableResponse>
    {
        public SeatableCheckTokenRequest(string host) : base(host)
        {
        }
        public string GetRequestUrl()
        {
            return $"{this.Host}/api2/auth/ping/";
        }
    }
}
