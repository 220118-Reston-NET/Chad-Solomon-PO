using PokeModel;

namespace PokeBL;
public interface IPokemonBL
{
    Customer AddCustomer(Customer c_name);

    public List<Customer> SearchCustomer(string c_customer);
}
