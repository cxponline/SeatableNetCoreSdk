using JackieSoft.SeatableNetCoreSdk.Auth;
using JackieSoft.SeatableNetCoreSdk.DTableServer;
using JackieSoft.SeatableNetCoreSdk.DTableWeb;
using JackieSoft.SeatableNetCoreSdk.Shared;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddSeatable(this IServiceCollection services)
        {            
            services.AddSingleton<ISeatableClient, SeatableClient>();
            services.AddSingleton<IAuthTokenService, AuthTokenService>();
            services.AddSingleton<IWorkSpaceService, WorkSpaceService>();
            services.AddSingleton<IRowService, RowService>();
            services.AddSingleton<IBaseService, BaseService>();
        }
    }
}
