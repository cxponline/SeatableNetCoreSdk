using Microsoft.Extensions.Options;
using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.Shared;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace JackieSoft.SeatableNetCoreSdk.DTableServer
{
    /// <summary>
    /// dtable-server rows
    /// </summary>
    /// <remarks>
    /// <para><a href="https://docs.seatable.cn/published/seatable-api/dtable-server/rows.md"></para>
    /// </remarks>
    public class RowService : SeatableServiceBase, IRowService
    {
        public RowService(ISeatableClient client,
               IOptions<SeatableOptions> optionsAccessor) : base(client, optionsAccessor)
        {
        }
        /// <summary>
        /// Update a row
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Dictionary<string, object>> UpdateAsync(SeatableRowUpdateModel model)
        {
            var request = new SeatableRowUpdateRequest(this.SeatableHost, model.DTableUuid);
            request.SetParamModel(model.Row);
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<Dictionary<string, object>>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }
        /// <summary>
        /// List rows
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<SeatableRowListResponseModel> ListAsync(SeatableRowListModel model)
        {
            var request = new SeatableRowListRequest(this.SeatableHost, model.DTableUuid, model.TableName);
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<SeatableRowListResponseModel>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }
        /// <summary>
        /// Batch update rows
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Dictionary<string, object>> BatchUpdateAsync(SeatableRowBatchUpdateModel model)
        {
            var request = new SeatableRowBatchUpdateRequet(this.SeatableHost, model.DTableUuid);
            request.SetParamModel(model);
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<Dictionary<string, object>>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }

        public async Task<Dictionary<string, object>> AppendAsync(SeatableRowAppendModel model)
        {
            var request = new SeatableRowAppendRequest(this.SeatableHost, model.DTableUuid);
            request.SetParamModel(model);
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<Dictionary<string, object>>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }

        public async Task<Dictionary<string, object>> BatchAppendAsync(SeatableRowBatchAppendModel model)
        {
            var request = new SeatableRowBatchAppendRequest(this.SeatableHost, model.DTableUuid);
            request.SetParamModel(model);
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<Dictionary<string, object>>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }

        public async Task<Dictionary<string, object>> InsertAsync(SeatableRowInsertModel model)
        {
            var request = new SeatableRowInsertRequest(this.SeatableHost, model.DTableUuid);
            request.SetParamModel(model);
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<Dictionary<string, object>>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }

        public async Task<Dictionary<string, object>> DeleteAsync(SeatableRowDeleteModel model)
        {
            var request = new SeatableRowDeleteRequest(this.SeatableHost, model.DTableUuid);
            request.SetParamModel(model);
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<Dictionary<string, object>>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }

        public async Task<Dictionary<string, object>> BatchDeleteAsync(SeatableRowBatchModel model)
        {
            var request = new SeatableRowBatchDeleteRequest(this.SeatableHost, model.DTableUuid);
            request.SetParamModel(model);
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<Dictionary<string, object>>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }

        public async Task<Dictionary<string, object>> GetAsync(SeatableRowGetModel model)
        {
            var request = new SeatableRowGetRequest(this.SeatableHost, model.DTableUuid, model.RowId);
            request.SetParamModel(model);
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<Dictionary<string, object>>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }

        public async Task<Dictionary<string, object>> LockAsync(SeatableRowBatchModel model)
        {
            var request = new SeatableRowLockRequest(this.SeatableHost, model.DTableUuid);
            request.SetParamModel(model);
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<Dictionary<string, object>>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }

        public async Task<Dictionary<string, object>> UnLockAsync(SeatableRowBatchModel model)
        {
            var request = new SeatableRowUnLockRequest(this.SeatableHost, model.DTableUuid);
            request.SetParamModel(model);
            var response = await _client.ExecuteAsync(request, model.Token);
            if (response.StatusCode == 200)
            {
                var result = JsonSerializer.Deserialize<Dictionary<string, object>>(response.Body);
                return result;
            }
            throw new SeatableException(response.Body);
        }
    }
}
