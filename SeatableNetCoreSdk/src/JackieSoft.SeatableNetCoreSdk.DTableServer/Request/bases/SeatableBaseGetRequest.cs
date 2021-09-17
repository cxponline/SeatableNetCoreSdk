using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.Shared;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public class SeatableBaseGetRequest : ISeatableGetRequest<SeatableResponse>
    {
        protected string Host;
        protected string DTableUuid;
        public SeatableBaseGetRequest(string host, string dtable_uuid)
        {
            this.Host = host;
            this.DTableUuid = dtable_uuid;
        }
        public string GetRequestUrl()
        {
            return $"{this.Host}/dtable-server/dtables/{DTableUuid}";
        }

        public SeatableObject GetParamModel()
        {
            return null;
        }
    }
}
