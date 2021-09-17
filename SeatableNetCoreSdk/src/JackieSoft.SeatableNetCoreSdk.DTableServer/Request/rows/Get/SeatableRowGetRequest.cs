using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.Shared;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public class SeatableRowGetRequest : SeatableRowRequestBase, ISeatableGetRequest<SeatableResponse>
    {
        private string RowId;        
        public SeatableRowGetRequest(string host, string dtable_uuid, string rowId) : base(host, dtable_uuid)
        {
            this.RowId = rowId;            
        }
        public string GetRequestUrl()
        {
            return $"{this.Host}/dtable-server/api/v1/dtables/{DTableUuid}/rows/{this.RowId}/";
        }
    }
}
