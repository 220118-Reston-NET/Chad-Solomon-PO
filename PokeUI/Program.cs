// See https://aka.ms/new-console-template for more information
using PokeBL;
using PokeDL;
using PokeModel;
using PokeUI;


bool repeat = true;
IMenu menu = new MainMenu();

/*
*****Originally, I was thinking of creating a pet supplies store. Which may still be a good Idea

*****I think it may be a bit simpler or just more fun to do a Mr. + Mrs. Potato head store for potatos.
>the store could sell all of the potato parts. 
>



***** Idea for the for the products Menus:
> Once a customer picks a product, we could try to suggest another product that would 
    go well with their origonal purchase.
    for instance....if a customer buys a leash we could suggest a new collar also!
                    or if they buy a toy, we could suggest some treats.

******* Idea for for functionality

> Once a customer picks a product form the category they chose I should ask what quantity they would like and show the price and description fo the item.


dotnet add package Serilog.Sinks.File
dotnet add package
dotnet add package Serilog

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
            menu = new CustomerAccount(new CustomerBL(new Repository()));
            break;


        case "LeashMenu":
            menu = new LeashMenu();
            break;

        case "CollarMenu":
            menu = new CollarMenu();
            break;

        case "ToyMenu":
            menu = new ToyMenu();
            break;

        case "TreatMenu":
            menu = new TreatMenu();
            break;

        default:
            Console.WriteLine("Page does not exist");
            break;
    }
}



