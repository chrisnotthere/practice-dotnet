using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Portfolios")]
    public class Portfolio
    {
        // [Key] 
        // public int PortfolioId { get; set; }
        public string? AppUserId { get; set; }
        public int StockId { get; set; }
        public AppUser? AppUser { get; set; }
        public Stock? Stock { get; set; }
    }
}