using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.Shared;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public class SeatableRowListRequest : SeatableRowRequestBase, ISeatableGetRequest<SeatableResponse>
    {
        public string TableName;        
        public SeatableRowListRequest(string host, string dtable_uuid, string tableName) : base(host,dtable_uuid)
        {            
            this.TableName = tableName;            
        }
        public string GetRequestUrl()
        {
            return $"{this.Host}/dtable-server/api/v1/dtables/{this.DTableUuid}/rows/?table_name={this.TableName}";
        }
    }
}
