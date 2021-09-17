

namespace JackieSoft.SeatableNetCoreSdk.Domain
{
    public abstract class SeatableRowRequestBase
    {
        protected string Host;
        protected string DTableUuid;
        protected SeatableObject paramModel;
        public SeatableRowRequestBase(string host, string dtable_uuid)
        {
            this.Host = host;
            this.DTableUuid = dtable_uuid;
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
