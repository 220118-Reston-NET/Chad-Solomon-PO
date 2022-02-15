using System.Linq;
using PokeDL;
using PokeModel;
namespace PokeBL
{
    public class OrderBL : IOrderBL
    {

        //Dependency Injection
        private IOrderRepo _orderRepo;
        public OrderBL(IOrderRepo c_orderRepo)
        {

            _orderRepo = c_orderRepo;
        }

        //public void AddOrder(Order _custID, Order _orderLocation, LineItem _cart)
        public void AddOrder(int _orderLocation, int _price, int _custID)
        {
            _orderRepo.AddOrder(_orderLocation, _price, _custID);

        }

        // public List<Order> SearchOrder(ng c_nam)
        // {

        //     List<Order> listOfOrder = _orderRepo.GetAllOrder();

        //     return listOfOrder
        //         .Where(order => order._custName.Contains(c_name))
        //         .ToList();
        // }

    }
}