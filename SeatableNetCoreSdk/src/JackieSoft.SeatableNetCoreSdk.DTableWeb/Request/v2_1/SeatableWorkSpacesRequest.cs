

using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.Shared;

namespace JackieSoft.SeatableNetCoreSdk.DTableWeb
{
    public class SeatableWorkSpacesRequest : SeatableRequestBase, ISeatableGetRequest<SeatableResponse>
    {
        private bool ShowDetail;
        public SeatableWorkSpacesRequest(string host, bool detail) : base(host)
        {            
            this.ShowDetail = detail;
        }
        public string GetRequestUrl()
        {
            return $"{this.Host}/api/v2.1/workspaces/?detail={ShowDetail.ToString().ToLower()}";
        }
    }
}
