using PokeModel;
namespace PokeUI
{

    public class CollarMenu : IMenu
    {
        //IMenu _newCollar = new CollarMenu();
        public void Display()
        {
            Console.WriteLine("Here at Furr Babies, we believe in having the highest quality products!");
            Console.WriteLine("Our Collars are super functional and stylish!");
            Console.WriteLine("We know your Pet will absolutly love showing off their new bling!");
            Console.WriteLine("Please make a selection!");
            Console.WriteLine("> 1: Rainbow Unicorn Design");
            Console.WriteLine("> 2: Super Hero Design");
            Console.WriteLine("> 3: Worlds Best Dog print Design");
            Console.WriteLine("> 4: Custom Quote Design");


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