using JackieSoft.SeatableNetCoreSdk.Domain;
using System.Threading.Tasks;

namespace JackieSoft.SeatableNetCoreSdk.Auth
{
    public interface IAuthTokenService
    {
        Task<SeatableAuthResponseModel> AuthTokenAsync(SeatableAuthModel model);
        Task<SeatableBaseAccessTokenResponseModel> BaseAccessTokenAsync(SeatableBaseAccessTokenModel model);
    }
}
