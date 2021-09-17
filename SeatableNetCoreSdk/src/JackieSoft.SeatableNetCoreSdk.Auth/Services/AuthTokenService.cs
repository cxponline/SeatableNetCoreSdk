using Microsoft.Extensions.Options;
using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.Shared;
using System.Text.Json;
using System.Threading.Tasks;

namespace JackieSoft.SeatableNetCoreSdk.Auth
{
    /// <summary>
    /// 全局 API-获取 API token-返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://docs.seatable.cn/published/seatable-api/home.md"></para>
    /// </remarks>
    public class AuthTokenService : SeatableServiceBase, IAuthTokenService
    {
        public AuthTokenService(ISeatableClient client,
            IOptions<SeatableOptions> optionsAccessor) : base(client, optionsAccessor)
        {
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="model">参数</param>
        /// <returns></returns>
        public async Task<SeatableAuthResponseModel> AuthTokenAsync(SeatableAuthModel model)
        {
            var request = new SeatableAuthRequest(this.SeatableHost);
            if (string.IsNullOrEmpty(model.UserName) && string.IsNullOrEmpty(model.Password))
            {
                model = new SeatableAuthModel
                {
                    UserName = this._optionsAccessor.Value.UserName,
                    Password = this._optionsAccessor.Value.Password
                };
            }
            request.SetParamModel(model);
            var response = await _client.ExecuteAsync(request);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<SeatableAuthResponseModel>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }
        /// <summary>
        /// 获取Base Access Token
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<SeatableBaseAccessTokenResponseModel> BaseAccessTokenAsync(SeatableBaseAccessTokenModel model)
        {
            var request = new SeatableBaseAccessTokenRequest(this.SeatableHost, model.WorkSpaceId, model.TableName);
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<SeatableBaseAccessTokenResponseModel>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }
    }
}
