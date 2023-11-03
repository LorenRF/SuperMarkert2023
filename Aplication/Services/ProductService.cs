using Aplication.Enum;
using Aplication.Repositorio;
using Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public class ProductService
    {
      
        public ProductListViewModel GetProducts()
        {
            return ProductRepository.Instance.ProductList;
        }

        public void Add (CreateProductViewModel product)
        {
            //Enum
            switch (product.productType)
            {
                case (int)ProductTypeEnum.FRUIT:
                    ProductRepository.Instance.ProductList.Fruits.Add(new ProductViewModel { Name = product.Name, Price = product.Price });
                    break;
                case (int)ProductTypeEnum.VEGETABLE:
                    ProductRepository.Instance.ProductList.Vegetables.Add(new ProductViewModel { Name = product.Name, Price = product.Price });
                    break; 
                case (int)ProductTypeEnum.DAIRY:
                    ProductRepository.Instance.ProductList.DairyProducts.Add(new ProductViewModel { Name = product.Name, Price = product.Price });

                    break;
            }
        }
    }
}
