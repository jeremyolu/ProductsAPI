using ProductsAPI.Data.Models;
namespace ProductsAPI.Data.Interfaces
{
    public interface IApiService
    {
        ApiResponse<Product> GetProducts();
        ApiResponse<Product> GetProductById(int id);
        ApiResponse<Product> GetProductsByName(string name);
        ApiResponse<Product> GetSaleProducts();
        ApiResponse<Product> GetMaleProducts();
        ApiResponse<Product> GetFemaleProducts();
    }
}
