using PokeModel;

namespace PokeBL
{
    public interface IPokemonBL
    {
        public Customer AddCustomer(Customer c_name);

        public List<Customer> SearchCustomer(int c_id);
    }

}
