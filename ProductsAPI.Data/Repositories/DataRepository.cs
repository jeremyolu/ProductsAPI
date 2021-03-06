using ProductsAPI.Data.Interfaces;
using ProductsAPI.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductsAPI.Data.Repositories
{
    public class DataRepository : IDataRepository
    {
        public IEnumerable<Product> GetProductsList()
        {
            return new List<Product>()
            {
                new Product { Id = 1001, Name = "Nike Valtec Sports Bra", Description = "Nike Valtec sports bra summer edition with v line straps", ImageUrl = "https://products.jeremyolu.com/img/products/nike-valtec-sports-bra.jpg",
                    Gender = 'F', Price = 32.00m, OnSale = false, Type = Type.Bras },
                new Product { Id = 1002, Name = "Grenande Carb Kill", Description = "Grenade innovative and trusted sports performance drink", ImageUrl = "https://products.jeremyolu.com/img/products/grenade-protein-shake.jpg",
                    Gender = 'M', Price = 25.00m, OnSale = false, Type = Type.Supplements },
                new Product { Id = 1003, Name = "Reebok Classics White", Description = "White Rebook classics", ImageUrl = "https://products.jeremyolu.com/img/products/white-reebok-classics-trainers.jpg",
                    Gender = 'M', Price = 50.00m, OnSale = false, Type = Type.Trainers },
                new Product { Id = 1004, Name = "Clantel Free Weights", Description = "Clantel free weights 5-10kg sets", ImageUrl = "https://products.jeremyolu.com/img/products/clantel-free-weights.jpg",
                    Gender = 'M', Price = 60.00m, OnSale = false, Type = Type.Accessories },
                new Product { Id = 1005, Name = "Adidas Sports Tights", Description = "Adidas tight fit sports gym tights", ImageUrl = "https://products.jeremyolu.com/img/products/adidas-sports-tights.jpg",
                    Gender = 'F', Price = 28.00m, OnSale = false, Type = Type.Tights },
                new Product { Id = 1006, Name = "Nike Pro Trainers", Description = "Nike pro trainers 2022 edition", ImageUrl = "https://products.jeremyolu.com/img/products/nike-pro-trainers.jpg",
                    Gender = 'F', Price = 80.00m, OnSale = false, Type = Type.Trainers },
                new Product { Id = 1007, Name = "New Balance Light Joggers", Description = "New Balance summer light joggers", ImageUrl = "https://products.jeremyolu.com/img/products/new-balance-light-joggers.jpg",
                    Gender = 'F', Price = 15.00m, OnSale = true, Type = Type.Joggers },
                new Product { Id = 1008, Name = "Wench Protein Shake", Description = "Wench protien shake", ImageUrl = "https://products.jeremyolu.com/img/products/wench-protein-shake.jpg",
                    Gender = 'M', Price = 19.00m, OnSale = true, Type = Type.Supplements },
                new Product { Id = 1009, Name = "Adidas Sports Bra", Description = "Adidas sports gym bra fitted with extra straps for support", ImageUrl = "https://products.jeremyolu.com/img/products/adidas-sports-bra.jpg",
                    Gender = 'F', Price = 20.00m, OnSale = true, Type = Type.Bras },
                new Product { Id = 1010, Name = "Black Multipurose Gym Mat", Description = "Black exercise gym mat for home and outdoor use", ImageUrl = "https://products.jeremyolu.com/img/products/black-gym-mat.jpg",
                    Gender = 'U', Price = 10.00m, OnSale = false, Type = Type.Accessories },
                new Product { Id = 1011, Name = "Adidas Gym Leggins Tights", Description = "Adidas gym leggin tights", ImageUrl = "https://products.jeremyolu.com/img/products/adidas-gym-leggins-tights.jpg",
                    Gender = 'F', Price = 20.00m, OnSale = false, Type = Type.Tights },
                new Product { Id = 1012, Name = "JFitness Brand Fitness Joggers", Description = "JFitness brand fitness joggers for gym use", ImageUrl = "https://products.jeremyolu.com/img/products/jfitness-brand-fitness-joggers.jpg",
                    Gender = 'M', Price = 40.00m, OnSale = false, Type = Type.Joggers }
            };
        }

        public IEnumerable<Product> GetProductById(int id)
        {
            return GetProductsList().Where(p => p.Id == id).ToList();
        }

        public IEnumerable<Product> GetSaleProductsList()
        {
            return GetProductsList().Where(p => p.OnSale == true);
        }

        public IEnumerable<Product> GetProductsByNameList(string name)
        {
            return GetProductsList().Where(p => p.Name.ToLower().StartsWith(name.ToLower()) || p.Name.ToLower().Contains(name.ToLower()));
        }

        public IEnumerable<Product> GetMaleProductsList()
        {
            return GetProductsList().Where(p => p.Gender == 'M' || p.Gender == 'U');
        }

        public IEnumerable<Product> GetFemaleProductsList()
        {
            return GetProductsList().Where(p => p.Gender == 'F' || p.Gender == 'U');
        }
    }
}
