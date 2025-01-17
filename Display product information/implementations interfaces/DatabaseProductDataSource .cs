using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_product_information.implementations_interfaces
{
    internal class DatabaseProductDataSource :IProductDataSource
    {
        public List<string> GetProducts()
        {
            return new List<string> { "Product from Database 1", "Product from Database 2" };
        }
    }
}
