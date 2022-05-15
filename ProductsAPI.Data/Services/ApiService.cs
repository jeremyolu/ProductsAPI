using ProductsAPI.Data.Interfaces;
using ProductsAPI.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductsAPI.Data.Services
{
    public class ApiService : IApiService
    {
        private IDataRepository _dataRepository;

        public ApiService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public ApiResponse<Product> GetProducts()
        {
            var products = _dataRepository.GetProductsList();

            return FormatApiResponse(products);
        }

        public ApiResponse<Product> GetProductById(int id)
        {
            var products = _dataRepository.GetProductById(id);

            return FormatApiResponse(products);
        }

        public ApiResponse<Product> GetProductsByName(string name)
        {
            var products = _dataRepository.GetProductsByNameList(name);

            return FormatApiResponse(products);
        }

        public ApiResponse<Product> GetSaleProducts()
        {
            var products = _dataRepository.GetSaleProductsList();

            return FormatApiResponse(products);
        }

        public ApiResponse<Product> GetMaleProducts()
        {
            var products = _dataRepository.GetMaleProductsList();

            return FormatApiResponse(products);
        }

        public ApiResponse<Product> GetFemaleProducts()
        {
            var products = _dataRepository.GetFemaleProductsList();

            return FormatApiResponse(products);
        }

        private ApiResponse<T> FormatApiResponse<T>(IEnumerable<T> collection)
        {
            return new ApiResponse<T>
            {
                Total = collection.Count(),
                Items = collection
            };
        }
    }
}
