using ProductsAPI.Data.Models;
using ProductsAPI.Data.Services;

namespace ProductsAPI.Data.Interfaces
{
    public interface IApiService
    {
        ApiResponse<Product> GetProducts();
        ApiResponse<Product> GetProductById(int id);
        ApiResponse<Product> GetProductsByName(string name);
    }
}
