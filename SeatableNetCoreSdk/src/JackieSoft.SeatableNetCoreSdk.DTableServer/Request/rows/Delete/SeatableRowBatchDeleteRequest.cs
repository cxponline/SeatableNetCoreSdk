using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.Shared;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public class SeatableRowBatchDeleteRequest : SeatableRowRequestBase, ISeatableDeleteRequest<SeatableResponse>
    {
        public SeatableRowBatchDeleteRequest(string host, string dtable_uuid) : base(host, dtable_uuid)
        {
        }
        public string GetRequestUrl()
        {
            return $"{this.Host}/dtable-server/api/v1/dtables/{DTableUuid}/batch-delete-rows/";
        }
    }
}
