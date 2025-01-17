using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_product_information.ProductService
{
    internal class ProductService
    {
        private readonly IProductDataSource _dataSource;

        public ProductService(IProductDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void DisplayProducts()
        {
            var products = _dataSource.GetProducts();
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
