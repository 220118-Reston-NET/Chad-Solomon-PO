using PokeBL;
using PokeModel;

namespace PokeUI
{

    public class CustomerAccount : IMenu
    {

        private static Customer _newCustomer = new Customer();

        private IPokemonBL _pokeBL;

        // public CustomerAccount()
        // {
        // }

        public CustomerAccount(IPokemonBL c_pokeBl)//THis is supposed to be like a constructor so it needs to have the same name as the class
        {
            _pokeBL = c_pokeBl;
        }

        public void Display()
        {
            Console.WriteLine("Please enter your information!");
            Console.WriteLine("[1] Name - " + _newCustomer._name);
            Console.WriteLine("[2] Address - " + _newCustomer._address);
            Console.WriteLine("[3] Email - " + _newCustomer._email);
            Console.WriteLine("[4] Save");
            Console.WriteLine("[5] Go back to MainMenu");
        }

        public string UserChoice()
        {

            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Please enter your name");
                    _newCustomer._name = Console.ReadLine();
                    return "CustomerAccount";

                case "2":
                    Console.WriteLine("Please enter your street address!");
                    _newCustomer._address = Console.ReadLine();
                    return "CustomerAccount";

                case "3":
                    Console.WriteLine("Please enter your email address!");
                    _newCustomer._email = Console.ReadLine();
                    return "CustomerAccount";

                case "4":
                    try
                    {
                        _pokeBL.AddCustomer(_newCustomer);
                    }
                    catch (System.Exception exc)
                    {
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return "ProductsMenu";


                case "5":

                    return "ProductsMenu";

                default:
                    Console.WriteLine("Please enter a valid response");
                    return "ProductsMenu";


            }

        }
    }
}