using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_api.Models
{
    public class Stock
    {
        public int MyProperty { get; set; }
        public string Symbol { get; set; }  = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; } 
         [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
        public List<Comment> MyProperty { get; set; }
        public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();

    }
}