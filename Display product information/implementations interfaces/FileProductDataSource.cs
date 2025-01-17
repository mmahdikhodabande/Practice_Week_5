namespace Display_product_information.implementations_interfaces
{
    internal class FileProductDataSource : IProductDataSource 
    {
        public List<string> GetProducts()
        {
            return new List<string> { "Product from File 1", "Product from File 2" };
        }
    }
}
