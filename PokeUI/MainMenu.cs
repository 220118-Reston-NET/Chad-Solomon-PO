namespace PokeUI
{
    public class MainMenu : IMenu
    {
        public void Display()
        {

            Console.WriteLine("Welcome to Furr Babies pet supplies store!");
            Console.WriteLine("Do you have an account with us?");
            Console.WriteLine("1: yes");
            Console.WriteLine("2: no");




        }

        public string UserChoice()
        {

            string? mainMenuSelection = Console.ReadLine();

            switch (mainMenuSelection)
            {
                case "yes":
                    return "Product";

                case "no":
                    return "CustomerAccount";
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Please Enter to continue!");
                    Console.ReadLine();
                    return "MainMenu";
            }

        }
    }
}