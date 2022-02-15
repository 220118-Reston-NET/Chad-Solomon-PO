using PokeModel;

namespace PokeDL
{
    public interface IOrderRepo
    {

        public void AddOrder(int _orderLocation, int _price, int _custID);

        public List<Order> GetOrder();

        // public List<Order> GetAllOrder();
    }
}