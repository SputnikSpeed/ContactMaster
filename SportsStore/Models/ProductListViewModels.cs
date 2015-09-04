using System.Collections.Generic;
using SportsStore.Domain.Entities;
namespace SportsStore.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
        public string CurrentBranche { get; set; }
    }
}