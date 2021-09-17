using Microsoft.Extensions.Options;
using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.Shared;
using System.Text.Json;
using System.Threading.Tasks;

namespace JackieSoft.SeatableNetCoreSdk.DTableWeb
{
    /// <summary>
    /// Workspaces
    /// </summary>
    /// <remarks>
    /// <para><a href="https://docs.seatable.cn/published/seatable-api/dtable-web-v2.1/workspaces.md"></para>
    /// </remarks>
    public class WorkSpaceService : SeatableServiceBase, IWorkSpaceService
    {
        public WorkSpaceService(ISeatableClient client,
            IOptions<SeatableOptions> optionsAccessor) : base(client, optionsAccessor)
        {
        }
        /// <summary>
        /// 查询WorkSpaces 不带明细
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<SeatableWorkSpaceModel> GetWorkSpacesAsync(string token)
        {
            var request = new SeatableWorkSpacesRequest(this.SeatableHost, false);
            var response = await _client.ExecuteAsync(request, token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<SeatableWorkSpaceModel>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }
        /// <summary>
        /// 查询WorkSpace 带明细
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<SeatableWorkSpaceDetailModel> GetWorkSpacesDetailAsync(string token)
        {
            var request = new SeatableWorkSpacesRequest(this.SeatableHost, true);
            var response = await _client.ExecuteAsync(request, token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<SeatableWorkSpaceDetailModel>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }
    }
}
