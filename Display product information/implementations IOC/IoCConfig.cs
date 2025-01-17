using Display_product_information.implementations_interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace Display_product_information.ProductService
{
    internal class IoCConfig
    {
        public static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

           
            services.AddTransient<DatabaseProductDataSource>();
            services.AddTransient<ApiProductDataSource>();
            services.AddTransient<FileProductDataSource>();

           
            services.AddTransient<IProductDataSource>(provider =>
            {
                string selectedSource = "api"; 
                return selectedSource switch
                {
                    "database" => provider.GetRequiredService<DatabaseProductDataSource>(),
                    "api" => provider.GetRequiredService<ApiProductDataSource>(),
                    "file" => provider.GetRequiredService<FileProductDataSource>(),
                    _ => throw new ArgumentException("Invalid data source type")
                };
            });

          
            services.AddTransient<ProductService>();

            return services.BuildServiceProvider();
        }
    }
}
