using PokeDL;
using PokeModel;

namespace PokeBL
{


    public class OrderHistoryBL : IOrderHistoryBL
    {

        private IOrderHistRepo _orderrepo;
        public OrderHistoryBL(IOrderHistRepo o_orderrepo)
        {

            _orderrepo = o_orderrepo;
        }


        public List<Order> SearchOrderHist(string c_name)
        {

            List<Order> listOfOrders = _orderrepo.GetAllOrders();

            return listOfOrders
                .Where(order => order._custName.Contains(c_name))
                .ToList();


        }

        // public List<Order> SearchCustomer(StoreFront s_name)
        // {

        //     List<Order> listOfOrders = _orderrepo.GetAllOrders();

        //     return listOfOrders
        //         .Where(order => order._storeName.Contains(s_name))
        //         .ToList();


        // }
    }

}