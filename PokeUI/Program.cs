// See https://aka.ms/new-console-template for more information
using PokeModel;
using PokeUI;

bool repeat = true;
MainMenu menu = new MainMenu();

while (repeat)
{

    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {

        case "yes":
            return "products";

        case "no":
            menu = new CustomerAccount;
    }
}



