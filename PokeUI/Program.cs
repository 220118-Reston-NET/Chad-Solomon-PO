// See https://aka.ms/new-console-template for more information
using PokeModel;
using PokeUI;

bool repeat = true;
IMenu menu = new MainMenu();

/*
*****Originally, I was thinking of creating a pet supplies store. Which may still be a good Idea

*****I think it may be a bit simpler or just more fun to do a Mr. + Mrs. Potato head store for potatos.
>the store could sell all of the potato parts. 
>


*/

while (repeat)
{

    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {

        case "ProductsMenu":
            menu = new ProductsMenu();
            break;

        case "CustomerAccount":
            menu = new CustomerAccount();
            break;

        default:
            Console.WriteLine("Page does not exist");
            break;
    }
}



