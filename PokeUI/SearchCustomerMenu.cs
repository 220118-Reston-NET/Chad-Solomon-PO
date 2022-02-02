using PokeBL;
using PokeModel;

namespace PokeUI
{

    public class SearchCustomerMenu : IMenu
    {
        //private static Customer _newCustomer = new Customer();
        //Dependency injection
        private IPokemonBL _customerBL;
        public SearchCustomerMenu(IPokemonBL c_customerBL)
        {

            _customerBL = c_customerBL;
        }
        public void Display()
        {
            Console.WriteLine("===========Search Customer Menu============");
            Console.WriteLine("Enter the Number of Your Desired Choice");
            Console.WriteLine("1. Search for Customer!");
            Console.WriteLine("2. Return to Main Menu");
        }

        public string UserChoice()
        {
            string? searchCustInput = Console.ReadLine();

            switch (searchCustInput)
            {

                case "1":
                    Console.WriteLine("Please Enter the Name of the Customer!");
                    string custName = Console.ReadLine();

                    List<Customer> listOfCustomer = _customerBL.SearchCustomer(custName);
                    foreach (var cust in listOfCustomer)
                    {
                        Console.WriteLine(cust);

                    }

                    //return "SearchCustomerMenu";



                    Console.WriteLine("Pleas press enter to continue");
                    Console.ReadLine();
                    return "SearchCustomerMenu";
                // Console.WriteLine("Pleas press enter to continue");
                // Console.ReadLine();

                /* 
                    Continue implementing your seach function here
                    Going to have to call the search funtion 
                    and possible create a new instance of a list
                */
                case "2":
                    return "MainMenu";

                default:

                    Console.WriteLine("This customer may not exist in our database");
                    Console.WriteLine("Please press enter to search again");
                    Console.ReadLine();
                    return "SearchCustomerMenu";


            }

            /*
Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
at PokeBL.CustomerBL.SearchCustomer(String c_customer) in C:\Users\chadc\Documents\Revature\C#\Poke\PokeBL\PokemonBL.cs:line 40
   at PokeUI.SearchCustomerMenu.UserChoice() in C:\Users\chadc\Documents\Revature\C#\Poke\PokeUI\SearchCustomerMenu.cs:line 35    
   at Program.<Main>$(String[] args) in C:\Users\chadc\Documents\Revature\C#\Poke\PokeUI\Program.cs:line 48
   */



        }


    }
}