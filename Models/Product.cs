using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;

namespace Willgoods.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Sku { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        // public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        [Required]
        public int CategoryId { get; set; } = 0;
        [JsonIgnore]
        public virtual Category? Category {get; set;}
    }
}