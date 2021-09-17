using JackieSoft.SeatableNetCoreSdk.Domain;
namespace JackieSoft.SeatableNetCoreSdk.Shared
{
    public interface ISeatableGetRequest<T> where T : SeatableResponse
    {
        /// <summary>
        /// 获取请求接口地址
        /// </summary>
        /// <returns></returns>
        string GetRequestUrl();
        /// <summary>
        /// 获取JSON参数模型
        /// </summary>
        /// <returns>JSON参数模型</returns>
        SeatableObject GetParamModel();
        /// <summary>
        /// 获取是否需要URL参数
        /// </summary>
        /// <returns>是否需要URL参数</returns>
        bool GetNeedQueryModel()
        {
            return true;
        }
    }
}
