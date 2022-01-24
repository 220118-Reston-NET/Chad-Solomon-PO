using PokeModel;
namespace PokeUI
{

    public class CustomerAccount : IMenu
    {

        private static Customer _newCustomer = new Customer();

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
                    return "MainMenu";

                case "5":
                    return "MainMenu";
                default:
                    Console.WriteLine("Please enter a valid response");
                    return "MianMenu";


            }

        }
    }
}