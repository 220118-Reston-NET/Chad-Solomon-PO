//using PokeModel;
namespace PokeUI
{
    public class ToyMenu : IMenu
    {
        IMenu _newToy = new ToyMenu();

        public void Display()
        {
            Console.WriteLine("Here at Furr Babies, we believe in having the highest quality products!");
            Console.WriteLine("Our pet toys are super tough for the strongest chewers and made with the safest material!");
            Console.WriteLine("Your pet will never want to put their new toy down!");
            Console.WriteLine("Please make a selection!");
            Console.WriteLine("> 1: Chew Toy");
            Console.WriteLine("> 2: Tug 'o War Toy");
            Console.WriteLine("> 3: Squeaky Toy");
            Console.WriteLine("> 4: Treat Hiding Toy");

        }

        public string UserChoice()
        {
            string? leashMenuSelection = Console.ReadLine();

            switch (leashMenuSelection)
            {
                case "1":
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