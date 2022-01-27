using PokeDL;
using PokeModel;
using System.Text.Json;

namespace PokeDL
{

    public class Repository : IRepository
    {
        private string _filepath = "../PokeDL/Database/";
        private string? _jsonString;
        public Customer AddCustomer(Customer c_customer)
        {
            string path = _filepath + "Customer.json";

            _jsonString = JsonSerializer.Serialize(c_customer, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(path, _jsonString);

            return c_customer;
        }

        // public Customer AddCustomer(Customer c_name)
        // {
        //     throw new NotImplementedException();
        // }
    }


}