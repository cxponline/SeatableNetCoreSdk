using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationSample.Models
{
    public class RowUpdateViewModel
    {
        public string Field { get; set; }
        public string Value { get; set; }
        public string TableName { get; set; }
        public string RowId { get; set; }
    }
}
