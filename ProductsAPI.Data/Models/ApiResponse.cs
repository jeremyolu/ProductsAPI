using System.Collections.Generic;

namespace ProductsAPI.Data.Models
{
    public class ApiResponse<T>
    {
        public int Total { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
