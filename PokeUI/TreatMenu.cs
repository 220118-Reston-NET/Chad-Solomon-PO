//using PokeModel;
namespace PokeUI
{

    public class TreatMenu : IMenu
    {
        //IMenu _newTreat = new TreatMenu();

        public void Display()
        {
            Console.WriteLine("Here at Furr Babies, we believe in having the highest quality products!");
            Console.WriteLine("Our pet treats are all Home Made with organic ingredients!");
            Console.WriteLine("If your pet could talk, they would tell you that it is the best thing they have ever eaten!");
            Console.WriteLine("Please make a selection!");
            Console.WriteLine("> 1: Sweet Potato and Bacon Bytes");
            Console.WriteLine("> 2: Atlantic Salmon and Jasmine Rice Nibbles");
            Console.WriteLine("> 3: Duck Cauliflower and Pea Chews");
            Console.WriteLine("> 4: Lamb Green Bean and Potato Tasties");


        }

        public string UserChoice()
        {
            string? leashMenuSelection = Console.ReadLine();

            switch (leashMenuSelection)
            {
                case "1":
                    return "LeashMenu";

                case "2":
                    return "CollarMenu";
                case "3":
                    return "ToyMenu";
                case "4":
                    return "TreatMenu";
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.WriteLine("Please Enter to continue!");
                    Console.ReadLine();
                    return "LeashMenu";
            }


        }
    }
}