namespace ProductsAPI.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public char Gender { get; set; }
        public bool OnSale { get; set; }
        public string Type { get; set; }
    }
}
