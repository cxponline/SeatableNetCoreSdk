

using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.Shared;

namespace JackieSoft.SeatableNetCoreSdk.Auth
{
    /// <summary>
    /// 读写单个 Base 的 API-获取 API base access token
    /// </summary>
    /// <remarks>
    /// <para><a href="https://docs.seatable.cn/published/seatable-api/home.md"></para>
    /// </remarks>
    public class SeatableBaseAccessTokenRequest : SeatableRequestBase, ISeatableGetRequest<SeatableResponse>
    {
        private long WorkSpaceId;
        private string TableName;        
        public SeatableBaseAccessTokenRequest(string host, long workspaceId, string tableName) : base(host)
        {            
            this.TableName = tableName;
            this.WorkSpaceId = workspaceId;
        }
        public string GetRequestUrl()
        {
            return $"{this.Host}/api/v2.1/workspace/{WorkSpaceId}/dtable/{TableName}/access-token/";
        }        
    }
}

