namespace PokeUI
{
    public class MainMenu : IMenu
    {
        public void Display()
        {

            Console.WriteLine("Welcome to Furr Babies pet supplies store!");
            Console.WriteLine("If you are new to our Store, please create an account!");
            Console.WriteLine("If you already have an account you are welcome to continue to the Product Menu");

        }

        public string UserChoice()
        {

            string? mainMenuSelection = Console.ReadLine();

            switch (mainMenuSelection)
            {
                case "Products":
                    return "ProductsMenu";

                case "CustomerAccount":
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