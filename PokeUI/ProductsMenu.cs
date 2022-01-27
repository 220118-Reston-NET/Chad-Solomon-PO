using PokeModel;
namespace PokeUI
{

    public class ProductsMenu : IMenu
    {
        //IMenu _LeashMenu = new LeashMenu();
        public void Display()
        {

            Console.WriteLine("Which category of products are you looking to buy?");
            Console.WriteLine("> 1: Leashes");
            Console.WriteLine("> 2: Collars");
            Console.WriteLine("> 3: Toys");
            Console.WriteLine("> 4: Treats");
        }

        public string UserChoice()
        {
            string? productMenuSelection = Console.ReadLine();

            switch (productMenuSelection)
            {
                case "1":
                    //IMenu _newLeashMenu = new LeashMenu();
                    return "LeashMenu";


                case "2":
                    //IMenu _newCollarMenu = new CollarMenu();
                    return "CollarMenu";

                case "3":
                    //IMenu _newToyMenu = new ToyMenu();
                    return "ToyMenu";

                case "4":
                    //IMenu _newTreatMenu = new TreatMenu();
                    return "TreatMenu";

                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Please Enter to continue!");
                    Console.ReadLine();
                    return "ProductsMenu";
            }

        }


    }
}