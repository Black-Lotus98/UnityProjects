using State_Pattern_Console_App;


Console.WriteLine("Enter 1 For Insert Coin");
Console.WriteLine("Enter 2 For Eject Coin");
Console.WriteLine("Enter 3 For Select Coin");
Console.WriteLine("Enter 4 To End");
VendingMachine aVendingMachine = new VendingMachine();

while (true)
{
    Console.WriteLine("Enter a Command");
    string command = Console.ReadLine();
   
    if(command == "1")
    {
        aVendingMachine.InsertCoin();
    }
    if (command == "2")
    {
        aVendingMachine.EjectCoin();
    }

    if (command == "3")
    {
        aVendingMachine.SelectItem();
    }
    if (command == "4")
    {
        break;
    }

}

Console.ReadLine();