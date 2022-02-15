using PokeModel;

namespace PokeBL
{
    public interface IOrderHistoryBL
    {
        // public Customer AddCustomer(Customer c_name);

        public List<Order> SearchOrderHist(string c_name);

        // public List<Order> SearchCustomer(string s_name);
    }

}