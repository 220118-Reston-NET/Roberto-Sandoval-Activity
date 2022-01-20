// See https://aka.ms/new-console-template for more information
using Menufunction;

Console.Clear();
Console.WriteLine("Welcome To Our Budget Tracking Helper!");
Console.WriteLine("What is your name?");

Menu user1 = new Menu();

user1.Name = Console.ReadLine();
bool repeat = true;

Console.WriteLine("");

Console.WriteLine("Loading previous saved state...");
user1.loadData();



while (repeat){
    Console.WriteLine($"Hello {user1.Name}, what would you like to do today?");
    Console.WriteLine("Type 1 to add a new date (MM-DD-YYYY)");
    Console.WriteLine("Type 2 to add onto daily expenses for the current date");
    Console.WriteLine("Type 3 to subtract from expenses for current date");
    Console.WriteLine("Type 4 to print current date expenses");
    Console.WriteLine("Type 5 to print an specific date");
    Console.WriteLine("Type 6 to print all dates being tracked");
    Console.WriteLine("Type 7 to exit program and save all changes");

    int userInput = Convert.ToInt32(Console.ReadLine());
    double total;
    //bool add;

    if (userInput == 1){
        
        Console.WriteLine("Enter the date you would like to add (MM-DD-YYYY)");
        string currDate = Console.ReadLine();

        user1.addNewDate(currDate);

        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 2){
        Console.WriteLine("Enter the amount you would like to add");
        double amount = Convert.ToDouble(Console.ReadLine());

        user1.addAmount(amount);

        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 3){
        Console.WriteLine("Enter the amount you would like to subtract");
        double amount = Convert.ToDouble(Console.ReadLine());

        user1.addAmount(amount);

        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 4){
        user1.printCurrExpense();

        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 5){
        Console.WriteLine("Enter date to print (MM-DD-YYYY)");
        string date = Console.ReadLine();
        user1.printSpecificDate(date);

        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 6){
        user1.printAllDates();
    

        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 7){
        Console.WriteLine("Thanks For Using Our Budget Tracking Helper");
        Console.WriteLine("All changes will now be saved...");
        user1.saveChanges();
        repeat = false;

    } else{
        Console.WriteLine("You have entered an incorrect option");
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();
    } 
}