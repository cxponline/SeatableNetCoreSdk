


using Microsoft.Extensions.Options;
using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.Shared;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public class BaseService : SeatableServiceBase, IBaseService
    {
        public BaseService(ISeatableClient client,
              IOptions<SeatableOptions> optionsAccessor) : base(client, optionsAccessor)
        {
        }

        public async Task<Dictionary<string, object>> GetBaseAsync(SeatableGetBaseModel model)
        {
            var request = new SeatableBaseGetRequest(this.SeatableHost, model.DTableUuid);            
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<Dictionary<string, object>>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }
    }
}
