using JackieSoft.SeatableNetCoreSdk.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public interface IBaseService
    {
        Task<Dictionary<string, object>> GetBaseAsync(SeatableGetBaseModel model);
    }
}
