

//creating a list that will house the cart of the user 
List<string> Cart = new List<string>();
decimal total = 0;
//creating a dictionary that houses all the menu items along with the prices associated with them
Dictionary<string, decimal> menu = new Dictionary<string, decimal>()
{
    { "eggs",2.99m },
    { "milk",1.99m }, 
    { "juice",4.99m },
    { "cheese",6.49m },
    { "tomatos",1.49m },
    { "apples",1.29m },
    { "bread",2.49m },
    { "redbull",12.99m }
};
//listing the menu to the customer
Console.WriteLine("\t\tMENU");
Console.WriteLine("=====================================");
foreach (KeyValuePair<string, decimal> kvp in menu)
{
    Console.WriteLine($"{kvp.Key}:   \t\t\t${kvp.Value}");
}
bool goagain = true;
while (goagain == true)
{
    while (true)
    {
        //prompting the user to enter in the item they wish to purchase
        Console.WriteLine("\nWhat do you want to order?");
        string userinput = Console.ReadLine();
        if (menu.ContainsKey(userinput))
        {
            //adding the value of what the user ordered into cart
            Cart.Add(userinput);
            break;
        }
        else
        {
            Console.WriteLine("You have entered an invalid response please try again");
            goagain = true;
        }
    }
    goagain = Continue();
}
Console.WriteLine("RECEIPT");
Console.WriteLine("========================");
Console.WriteLine("ITEM\t\tPRICE");
foreach (string s in Cart)
{
    Console.WriteLine($"{s}\t\t${menu[s]}");
    total = total + menu[s];
}
Console.WriteLine("========================");
Console.WriteLine($"TOTAL\t\t${total}");
//this series of loops will display to the user the recipt of what they have in the cart


static bool Continue()
{
    while (true)
    {
        //prompting the user if they wish to add something else to their cart
        Console.WriteLine("Do you want to add something else to your cart? (y/n)");
        string answer = Console.ReadLine();

        if (answer == "y")
        {
            return true;
        }
        else if (answer == "n")
        {
            return false;
        }
        else
        {
            Console.WriteLine("The input you have entered is invalid. Please try again.");
        }
    }
}










//REFERENCE CODE
//foreach (KeyValuePair<string, int> kvp in phonebook)
//{
//    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//}
//phonebook["Purple giraffe Real Estate"]