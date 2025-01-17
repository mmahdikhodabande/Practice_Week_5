using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_product_information
{
    public interface IProductDataSource
    {
       List<string> GetProducts();

    }
}
