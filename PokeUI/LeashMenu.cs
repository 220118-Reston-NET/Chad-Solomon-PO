using PokeModel;
namespace PokeUI
{

    public class LeashMenu : IMenu
    {
        //IMenu _newLeash = new LeashMenu();

        public void Display()
        {
            Console.WriteLine("Here at Furr Babies, we believe in having the highest quality products!");
            Console.WriteLine("Our leashes are super functional to keep your pet safe!");
            Console.WriteLine("We know your Pet will absolutly love showing off their new bling!");
            Console.WriteLine("Please make a selection!");
            Console.WriteLine("> 1: Nylon Fabric");
            Console.WriteLine("> 2: Rope Fabric");
            Console.WriteLine("> 3: Pericord Fabric");
            Console.WriteLine("> 4: Retractable style");


        }

        //Once a selection has been made here, we will need to add this to the customers order/chart
        public string UserChoice()
        {
            string? leashMenuSelection = Console.ReadLine();

            switch (leashMenuSelection)
            {
                case "LeashMenu":
                    return "LeashMenu";

                case "Collars":
                    return "CollarMenu";

                case "Toys":
                    return "ToyMenu";

                case "Treats":
                    return "TreatsMenu";
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Please Enter to continue!");
                    Console.ReadLine();
                    return "MainMenu";
            }


        }
    }
}