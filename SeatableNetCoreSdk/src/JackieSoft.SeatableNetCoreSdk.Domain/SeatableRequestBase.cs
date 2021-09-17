

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public abstract class SeatableRequestBase
    {
        protected string Host;
        protected SeatableObject paramModel;
        public SeatableRequestBase(string host)
        {
            this.Host = host;
        }
        /// <summary>
        /// 获取JSON参数模型
        /// </summary>
        /// <returns>JSON参数模型</returns>
        public virtual SeatableObject GetParamModel()
        {
            return paramModel;
        }
        /// <summary>
        /// 设置JSON参数模型
        /// </summary>
        /// <param name="paramModel">JSON参数模型</param>
        public virtual void SetParamModel(SeatableObject paramModel)
        {
            this.paramModel = paramModel;
        }
    }
}
