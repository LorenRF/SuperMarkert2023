using Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Repositorio
{
    public sealed class ProductRepository
    {
        private ProductRepository() 
        { 
        
        }

        public static ProductRepository Instance { get; } = new ProductRepository();

        public ProductListViewModel ProductList { get; set; } = new();
    }
}
