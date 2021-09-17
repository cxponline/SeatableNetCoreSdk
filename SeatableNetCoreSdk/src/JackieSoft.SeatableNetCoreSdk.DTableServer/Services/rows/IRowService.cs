using JackieSoft.SeatableNetCoreSdk.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    public interface IRowService
    {
        Task<Dictionary<string, object>> UpdateAsync(SeatableRowUpdateModel model);
        Task<Dictionary<string, object>> BatchUpdateAsync(SeatableRowBatchUpdateModel model);
        Task<SeatableRowListResponseModel> ListAsync(SeatableRowListModel model);
        Task<Dictionary<string, object>> AppendAsync(SeatableRowAppendModel model);
        Task<Dictionary<string, object>> BatchAppendAsync(SeatableRowBatchAppendModel model);
        Task<Dictionary<string, object>> InsertAsync(SeatableRowInsertModel model);
        Task<Dictionary<string, object>> DeleteAsync(SeatableRowDeleteModel model);
        Task<Dictionary<string, object>> BatchDeleteAsync(SeatableRowBatchModel model);
        Task<Dictionary<string, object>> GetAsync(SeatableRowGetModel model);
        Task<Dictionary<string, object>> LockAsync(SeatableRowBatchModel model);
        Task<Dictionary<string, object>> UnLockAsync(SeatableRowBatchModel model);
    }
}
