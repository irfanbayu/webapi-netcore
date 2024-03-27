using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Willgoods.API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name {get; set;} = string.Empty;
    public virtual List<Product> Products {get; set;}
    }
}