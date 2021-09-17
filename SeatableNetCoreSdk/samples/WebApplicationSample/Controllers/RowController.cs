using Microsoft.AspNetCore.Mvc;
using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.DTableServer;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class RowController : Controller
    {
        private readonly IRowService _rowService;
        public RowController(IRowService rowService)
        {
            this._rowService = rowService;
        }
        public async Task<IActionResult> Index()
        {
            await GetListAsync();
            return View();
        }
        private async Task<SeatableRowListResponseModel> GetListAsync()
        {
            var titleList = new List<string> {
             "_id",
             "工厂",
             "产品",
             "损失率"
            };

            var result = await this._rowService.ListAsync(new JackieSoft.SeatableNetCoreSdk.Domain.SeatableRowListModel
            {
                DTableUuid = "a13abaf8-b79b-427d-802d-303cc1b60f6e",
                TableName = "n8n-table",
                Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzIwMzI5MTIsImR0YWJsZV91dWlkIjoiYTEzYWJhZjgtYjc5Yi00MjdkLTgwMmQtMzAzY2MxYjYwZjZlIiwidXNlcm5hbWUiOiI5OTA4ZDAyMTEwZWQ0MDNjOWM0N2JhMTg2OWVjOTE3YUBhdXRoLmxvY2FsIiwiaWRfaW5fb3JnIjoiIiwicGVybWlzc2lvbiI6InJ3In0.VpgzKB7q1hpbE5G4XMPXj56cUj4ceOVM4wMR736qikE"
            });
            ViewData["data"] = result;
            ViewData["title"] = titleList;
            return result;
        }
        public async Task<IActionResult> Update(RowUpdateViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Value))
            {
                var result = await this._rowService.UpdateAsync(new JackieSoft.SeatableNetCoreSdk.Domain.SeatableRowUpdateModel
                {
                    DTableUuid = "a13abaf8-b79b-427d-802d-303cc1b60f6e",
                    Row = new SeatableUpdateRow
                    {
                        RowId = model.RowId,
                        TableName = model.TableName,
                        Row = new Dictionary<string, object> {
                        {model.Field,model.Value}
                       }
                    },
                    Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzIwMzI5MTIsImR0YWJsZV91dWlkIjoiYTEzYWJhZjgtYjc5Yi00MjdkLTgwMmQtMzAzY2MxYjYwZjZlIiwidXNlcm5hbWUiOiI5OTA4ZDAyMTEwZWQ0MDNjOWM0N2JhMTg2OWVjOTE3YUBhdXRoLmxvY2FsIiwiaWRfaW5fb3JnIjoiIiwicGVybWlzc2lvbiI6InJ3In0.VpgzKB7q1hpbE5G4XMPXj56cUj4ceOVM4wMR736qikE"
                });
                ViewData["success"] = result["success"];
            }
            return View();
        }
        public async Task<IActionResult> Append(RowAppendViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Factory))
            {
                var result = await this._rowService.AppendAsync(new JackieSoft.SeatableNetCoreSdk.Domain.SeatableRowAppendModel
                {
                    DTableUuid = "a13abaf8-b79b-427d-802d-303cc1b60f6e",
                    TableName = model.TableName,
                    Row = new Dictionary<string, object> {
                        {"工厂",model.Factory},
                        {"产品",model.Product},
                        {"损失率",model.Rate}
                       },
                    Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzIwMzI5MTIsImR0YWJsZV91dWlkIjoiYTEzYWJhZjgtYjc5Yi00MjdkLTgwMmQtMzAzY2MxYjYwZjZlIiwidXNlcm5hbWUiOiI5OTA4ZDAyMTEwZWQ0MDNjOWM0N2JhMTg2OWVjOTE3YUBhdXRoLmxvY2FsIiwiaWRfaW5fb3JnIjoiIiwicGVybWlzc2lvbiI6InJ3In0.VpgzKB7q1hpbE5G4XMPXj56cUj4ceOVM4wMR736qikE"
                });
                ViewData["data"] = result;
            }
            else
            {
                ViewData["data"] = new Dictionary<string, object> {
                    {"_id",""}

                };
            }
            return View();
        }
        public async Task<IActionResult> Insert(RowInsertViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Factory))
            {
                var result = await this._rowService.InsertAsync(new JackieSoft.SeatableNetCoreSdk.Domain.SeatableRowInsertModel
                {
                    DTableUuid = "a13abaf8-b79b-427d-802d-303cc1b60f6e",
                    TableName = model.TableName,
                    AnchorRowId = model.AnchorRowId,
                    Row = new Dictionary<string, object> {
                        {"工厂",model.Factory},
                        {"产品",model.Product},
                        {"损失率",model.Rate}
                       },
                    Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzIwMzI5MTIsImR0YWJsZV91dWlkIjoiYTEzYWJhZjgtYjc5Yi00MjdkLTgwMmQtMzAzY2MxYjYwZjZlIiwidXNlcm5hbWUiOiI5OTA4ZDAyMTEwZWQ0MDNjOWM0N2JhMTg2OWVjOTE3YUBhdXRoLmxvY2FsIiwiaWRfaW5fb3JnIjoiIiwicGVybWlzc2lvbiI6InJ3In0.VpgzKB7q1hpbE5G4XMPXj56cUj4ceOVM4wMR736qikE"
                });
                ViewData["data"] = result;
            }
            else
            {
                ViewData["data"] = new Dictionary<string, object> {
                    {"_id",""}

                };
            }
            return View();
        }
        public async Task<IActionResult> BatchAppend(RowBatchAppendViewModel model)
        {
            if (!string.IsNullOrEmpty(model.Factory))
            {
                var rows = new List<Dictionary<string, object>>();
                for (int i = 0; i < model.Count; i++)
                {
                    rows.Add(new Dictionary<string, object> {
                        {"工厂",model.Factory+"-"+i},
                        {"产品",model.Product},
                        {"损失率",model.Rate}
                       });
                }
                var result = await this._rowService.BatchAppendAsync(new JackieSoft.SeatableNetCoreSdk.Domain.SeatableRowBatchAppendModel
                {
                    DTableUuid = "a13abaf8-b79b-427d-802d-303cc1b60f6e",
                    TableName = model.TableName,
                    Rows = rows,
                    Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzIwMzI5MTIsImR0YWJsZV91dWlkIjoiYTEzYWJhZjgtYjc5Yi00MjdkLTgwMmQtMzAzY2MxYjYwZjZlIiwidXNlcm5hbWUiOiI5OTA4ZDAyMTEwZWQ0MDNjOWM0N2JhMTg2OWVjOTE3YUBhdXRoLmxvY2FsIiwiaWRfaW5fb3JnIjoiIiwicGVybWlzc2lvbiI6InJ3In0.VpgzKB7q1hpbE5G4XMPXj56cUj4ceOVM4wMR736qikE"
                });
                ViewData["data"] = result;
            }
            else
            {
                ViewData["data"] = new Dictionary<string, object> {
                    {"inserted_row_count","0"}

                };
            }
            return View();
        }
        public async Task<IActionResult> BatchUpdate(RowUpdateViewModel model)
        {
            if (!string.IsNullOrEmpty(model.TableName))
            {
                var item = await GetListAsync();
                var list = new List<SeatableRowBatchUpdateItem>();
                for (int i = 0; i < item.Rows.Count; i++)
                {
                    list.Add(new SeatableRowBatchUpdateItem
                    {
                        RowId = item.Rows[i]["_id"].ToString(),
                        Row = new Dictionary<string, object> {
                         { "工厂",item.Rows[i]["工厂"]+"_"+i },
                         { "产品",item.Rows[i]["产品"] },
                         { "损失率",item.Rows[i]["损失率"] },
                     }
                    });
                }
                var result = await this._rowService.BatchUpdateAsync(new JackieSoft.SeatableNetCoreSdk.Domain.SeatableRowBatchUpdateModel
                {
                    DTableUuid = "a13abaf8-b79b-427d-802d-303cc1b60f6e",
                    TableName = model.TableName,
                    Rows = list,
                    Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzIwMzI5MTIsImR0YWJsZV91dWlkIjoiYTEzYWJhZjgtYjc5Yi00MjdkLTgwMmQtMzAzY2MxYjYwZjZlIiwidXNlcm5hbWUiOiI5OTA4ZDAyMTEwZWQ0MDNjOWM0N2JhMTg2OWVjOTE3YUBhdXRoLmxvY2FsIiwiaWRfaW5fb3JnIjoiIiwicGVybWlzc2lvbiI6InJ3In0.VpgzKB7q1hpbE5G4XMPXj56cUj4ceOVM4wMR736qikE"
                });
                ViewData["result"] = result;
                await GetListAsync();
            }
            else
            {
                await GetListAsync();
                ViewData["result"] = new Dictionary<string, object> {
                    {"success","0"}

                };
            }
            return View();
        }
        public async Task<IActionResult> GetRow(RowGetViewModel model)
        {
            if (!string.IsNullOrEmpty(model.RowId))
            {
                var result = await this._rowService.GetAsync(new JackieSoft.SeatableNetCoreSdk.Domain.SeatableRowGetModel
                {
                    DTableUuid = "a13abaf8-b79b-427d-802d-303cc1b60f6e",
                    RowId = model.RowId,
                    TableId = model.TableId,
                    Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzIwMzI5MTIsImR0YWJsZV91dWlkIjoiYTEzYWJhZjgtYjc5Yi00MjdkLTgwMmQtMzAzY2MxYjYwZjZlIiwidXNlcm5hbWUiOiI5OTA4ZDAyMTEwZWQ0MDNjOWM0N2JhMTg2OWVjOTE3YUBhdXRoLmxvY2FsIiwiaWRfaW5fb3JnIjoiIiwicGVybWlzc2lvbiI6InJ3In0.VpgzKB7q1hpbE5G4XMPXj56cUj4ceOVM4wMR736qikE"
                });
                ViewData["data"] = result;
            }
            else
            {
                ViewData["data"] = new Dictionary<string, object> {
                    {"_id",""}

                };
            }
            return View();
        }
        public async Task<IActionResult> Lock(RowLockViewModel model)
        {
            await GetListAsync();
            if (model.RowIds != null)
            {
                var ids = model.RowIds.Split(',', System.StringSplitOptions.RemoveEmptyEntries);
                var idList = new List<string>();
                foreach (var id in ids)
                {
                    idList.Add(id);
                }
                var result = await this._rowService.LockAsync(new SeatableRowBatchModel
                {
                    DTableUuid = "a13abaf8-b79b-427d-802d-303cc1b60f6e",
                    RowIds = idList,
                    TableName = model.TableName,
                    Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzIwMzI5MTIsImR0YWJsZV91dWlkIjoiYTEzYWJhZjgtYjc5Yi00MjdkLTgwMmQtMzAzY2MxYjYwZjZlIiwidXNlcm5hbWUiOiI5OTA4ZDAyMTEwZWQ0MDNjOWM0N2JhMTg2OWVjOTE3YUBhdXRoLmxvY2FsIiwiaWRfaW5fb3JnIjoiIiwicGVybWlzc2lvbiI6InJ3In0.VpgzKB7q1hpbE5G4XMPXj56cUj4ceOVM4wMR736qikE"
                });
                ViewData["result"] = result;
            }
            else
            {
                ViewData["result"] = new Dictionary<string, object> {
                    {"success",""}

                };
            }
            return View();
        }
        public async Task<IActionResult> UnLock(RowLockViewModel model)
        {
            await GetListAsync();
            if (model.RowIds != null)
            {
                var ids = model.RowIds.Split(',', System.StringSplitOptions.RemoveEmptyEntries);
                var idList = new List<string>();
                foreach (var id in ids)
                {
                    idList.Add(id);
                }
                var result = await this._rowService.UnLockAsync(new SeatableRowBatchModel
                {
                    DTableUuid = "a13abaf8-b79b-427d-802d-303cc1b60f6e",
                    RowIds = idList,
                    TableName = model.TableName,
                    Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzIwMzI5MTIsImR0YWJsZV91dWlkIjoiYTEzYWJhZjgtYjc5Yi00MjdkLTgwMmQtMzAzY2MxYjYwZjZlIiwidXNlcm5hbWUiOiI5OTA4ZDAyMTEwZWQ0MDNjOWM0N2JhMTg2OWVjOTE3YUBhdXRoLmxvY2FsIiwiaWRfaW5fb3JnIjoiIiwicGVybWlzc2lvbiI6InJ3In0.VpgzKB7q1hpbE5G4XMPXj56cUj4ceOVM4wMR736qikE"
                });
                ViewData["result"] = result;
            }
            else
            {
                ViewData["result"] = new Dictionary<string, object> {
                    {"success",""}

                };
            }
            return View();
        }
        public async Task<IActionResult> Delete(RowLockViewModel model)
        {
            await GetListAsync();
            if (model.RowIds != null)
            {
                var result = await this._rowService.DeleteAsync(new SeatableRowDeleteModel
                {
                    DTableUuid = "a13abaf8-b79b-427d-802d-303cc1b60f6e",
                    RowId = model.RowIds,
                    TableName = model.TableName,
                    Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzIwMzI5MTIsImR0YWJsZV91dWlkIjoiYTEzYWJhZjgtYjc5Yi00MjdkLTgwMmQtMzAzY2MxYjYwZjZlIiwidXNlcm5hbWUiOiI5OTA4ZDAyMTEwZWQ0MDNjOWM0N2JhMTg2OWVjOTE3YUBhdXRoLmxvY2FsIiwiaWRfaW5fb3JnIjoiIiwicGVybWlzc2lvbiI6InJ3In0.VpgzKB7q1hpbE5G4XMPXj56cUj4ceOVM4wMR736qikE"
                });
                ViewData["result"] = result;
            }
            else
            {
                ViewData["result"] = new Dictionary<string, object> {
                    {"deleted_rows",""}

                };
            }
            return View();
        }
        public async Task<IActionResult> BatchDelete(RowLockViewModel model)
        {
            await GetListAsync();
            if (model.RowIds != null)
            {
                var ids = model.RowIds.Split(',', System.StringSplitOptions.RemoveEmptyEntries);
                var idList = new List<string>();
                foreach (var id in ids)
                {
                    idList.Add(id);
                }
                var result = await this._rowService.BatchDeleteAsync(new SeatableRowBatchModel
                {
                    DTableUuid = "a13abaf8-b79b-427d-802d-303cc1b60f6e",
                    RowIds = idList,
                    TableName = model.TableName,
                    Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJleHAiOjE2MzIwMzI5MTIsImR0YWJsZV91dWlkIjoiYTEzYWJhZjgtYjc5Yi00MjdkLTgwMmQtMzAzY2MxYjYwZjZlIiwidXNlcm5hbWUiOiI5OTA4ZDAyMTEwZWQ0MDNjOWM0N2JhMTg2OWVjOTE3YUBhdXRoLmxvY2FsIiwiaWRfaW5fb3JnIjoiIiwicGVybWlzc2lvbiI6InJ3In0.VpgzKB7q1hpbE5G4XMPXj56cUj4ceOVM4wMR736qikE"
                });
                ViewData["result"] = result;
            }
            else
            {
                ViewData["result"] = new Dictionary<string, object> {
                    {"deleted_rows",""}

                };
            }
            return View();
        }
    }
}
