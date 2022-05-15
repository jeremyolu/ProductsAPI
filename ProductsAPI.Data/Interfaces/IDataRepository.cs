using ProductsAPI.Data.Models;
using System.Collections.Generic;

namespace ProductsAPI.Data.Interfaces
{
    public interface IDataRepository
    {
        IEnumerable<Product> GetProductsList();
        IEnumerable<Product> GetProductById(int id);
        IEnumerable<Product> GetSaleProductsList();
        IEnumerable<Product> GetProductsByNameList(string name);
        IEnumerable<Product> GetMaleProductsList();
        IEnumerable<Product> GetFemaleProductsList();
    }
}
