using JackieSoft.SeatableNetCoreSdk.Domain;
using JackieSoft.SeatableNetCoreSdk.DTableServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSample.Models
{
    public class RowBatchUpdateViewModel
    {
        public List<SeatableRowBatchUpdateItem> Rows { get; set; }
        public string UUID { get; set; }
        public string TableName { get; set; }
    }
}
