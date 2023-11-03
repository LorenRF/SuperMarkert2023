using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.ViewModel
{
    public class ProductListViewModel
    {
        public List<ProductViewModel> Fruits { get; set; } = new();
        public List<ProductViewModel> Vegetables { get; set; } = new();
        public List<ProductViewModel> DairyProducts { get; set; } = new();

    }
}
