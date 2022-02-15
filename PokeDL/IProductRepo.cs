using PokeModel;
namespace PokeDL
{

    public interface IProductRepo
    {

        public Product AddProduct(Product c_product);

        public List<Product> GetAllProduct();
    }
}