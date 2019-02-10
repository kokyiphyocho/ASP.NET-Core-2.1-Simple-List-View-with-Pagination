using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleListView.Models
{
    public class Pagination
    {
        public int PageNo               { get; set; } = 1;  // Assign Default PageNo to 1.
        public int PageSize             { get; set; } = 6;  // Assign Default PageSize to 6.
        public int TotalCount           { get; set; }
        public int PageButtonCount      { get; set; } = 10; // Assign Display PageButtonCount to 10;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount, PageSize));
    }
}
