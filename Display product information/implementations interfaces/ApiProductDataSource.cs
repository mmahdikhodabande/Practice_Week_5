using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_product_information.implementations_interfaces
{
    internal class ApiProductDataSource :IProductDataSource
    {
        public List<string> GetProducts()
        {
            return new List<string> { "Product from API 1", "Product from API 2" };
        }
    }
}
