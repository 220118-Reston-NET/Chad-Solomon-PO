using PokeModel;
namespace PokeBL
{
    public interface IProductBL
    {
        public Product AddProduct(Product c_product);

        public List<Product> SearchProduct(string c_product);


    }
}