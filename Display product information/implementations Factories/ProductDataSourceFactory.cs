using Display_product_information.implementations_interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_product_information.implementations_Factories
{
    internal class ProductDataSourceFactory
    {
        public static IProductDataSource CreateDataSource(string sourceType)
        {
            return sourceType.ToLower() switch
            {
                "database" => new DatabaseProductDataSource(),
                "api" => new ApiProductDataSource(),
                "file" => new FileProductDataSource(),
                _ => throw new ArgumentException("Invalid data source type")
            };
        }
    }
}
