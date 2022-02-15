using PokeModel;
namespace PokeDL
{

    /*


    */
    public interface IRepository
    {
        public Customer AddCustomer(Customer c_name);


        public List<Customer> GetAllCustomers();




    }
}
