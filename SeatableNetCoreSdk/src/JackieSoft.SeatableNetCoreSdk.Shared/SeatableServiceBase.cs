using Microsoft.Extensions.Options;

namespace JackieSoft.SeatableNetCoreSdk.Shared
{
    public abstract class SeatableServiceBase
    {
        public ISeatableClient _client;
        public IOptions<SeatableOptions> _optionsAccessor;
        protected string SeatableHost;
        public SeatableServiceBase(ISeatableClient client, IOptions<SeatableOptions> optionsAccessor)
        {
            this._client = client;
            this._optionsAccessor = optionsAccessor;
            this.SeatableHost = this._optionsAccessor.Value.Host;
        }
    }
}
