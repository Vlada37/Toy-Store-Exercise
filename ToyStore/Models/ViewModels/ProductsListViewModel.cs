using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToyStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();
        public PagingInfo PagingInfo { get; set; } = new();
        public string? CurrentCategory { get; set; }  
 
    }
}