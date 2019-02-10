using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreListView.Models
{
    public class Pagination
    {
        public int PageNo { get; set; } = 1;
        public int PageSize { get; set; } = 6;
        public int TotalCount { get; set; }
        public int PageButtonCount { get; set; } = 10;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));
    }
}
