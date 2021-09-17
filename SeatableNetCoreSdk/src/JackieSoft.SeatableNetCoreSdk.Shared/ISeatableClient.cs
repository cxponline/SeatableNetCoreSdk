using JackieSoft.SeatableNetCoreSdk.Domain;
using System.Threading.Tasks;

namespace JackieSoft.SeatableNetCoreSdk.Shared
{
    public interface ISeatableClient
    {

        /// <summary>
        /// 执行Get请求。
        /// </summary>
        /// <param name="request">请求对象</param>       
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(ISeatableGetRequest<T> request, string token = null) where T : SeatableResponse;

        /// <summary>
        /// 执行Post请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(ISeatablePostRequest<T> request, string token = null) where T : SeatableResponse;

        /// <summary>
        /// 执行Put请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(ISeatablePutRequest<T> request, string token = null) where T : SeatableResponse;

        /// <summary>
        /// 执行Delete请求。
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <returns>响应对象</returns>
        Task<T> ExecuteAsync<T>(ISeatableDeleteRequest<T> request, string token = null) where T : SeatableResponse;
    }
}
