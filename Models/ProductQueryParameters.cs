using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Willgoods.Models
{
    public class ProductQueryParameters : QueryParameters
    {
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        public string Sku { get; set; } = string.Empty;
        public string Name {get; set; } = string.Empty;
        public string SearchTerm { get; set; } = string.Empty;
    }
}