using PokeModel;
using PokeDL;
namespace PokeBL
{
    /*
    The Business layer will essentially return your added custoemr i think.
    Also, we could add the function of assigning a random ID to the customer or the customers order or the products
    */
    public class CustomerBL : IPokemonBL
    {
        //Dependency Injection Pattern
        //- This is the main reason why we created interface first before the class
        //- This will save you time on re-writting code that breaks if you updated a completely separate class
        //- Main reason is to prevent us from re-writting code that already existed on (potentailly) 50 files or more without
        //the compiler helping us
        //===========================


        private IRepository _repo;
        public CustomerBL(IRepository c_repo)
        {
            _repo = c_repo;
        }

        //=========================

        public Customer AddCustomer(Customer c_name)
        {
            return _repo.AddCustomer(c_name);

        }

    }
}