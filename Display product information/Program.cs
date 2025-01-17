using Display_product_information.ProductService;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = IoCConfig.ConfigureServices();

var productService = serviceProvider.GetRequiredService<ProductService>();


productService.DisplayProducts();