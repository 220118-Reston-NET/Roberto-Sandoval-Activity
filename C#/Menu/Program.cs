// See https://aka.ms/new-console-template for more information
using Menufunction;

Console.Clear();
Console.WriteLine("Welcome user!");
Console.WriteLine("What is your name?");

Menu user1 = new Menu();

user1.Name = Console.ReadLine();
bool repeat = true;

Console.WriteLine("");


while (repeat){
    Console.WriteLine($"Hello {user1.Name}, what calculation or task would you like to do today?");
    Console.WriteLine("Type 1 for addition");
    Console.WriteLine("Type 2 for subtraction");
    Console.WriteLine("Type 3 for multiplication");
    Console.WriteLine("Type 4 for division");
    Console.WriteLine("Type 5 to find a total");
    Console.WriteLine("Type 6 to find and delete a total");
    Console.WriteLine("Type 7 to exit program");

    int userInput = Convert.ToInt32(Console.ReadLine());
    double total;
    //bool add;

    if (userInput == 1){
        
        Console.WriteLine("What two numbers would you like to add?");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        total = num1+num2;

        user1.CalcStatement(total);

        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 2){
        Console.WriteLine("What two numbers would you like to subtract?");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        total = num1-num2;

        user1.CalcStatement(total);

        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 3){
        Console.WriteLine("What two numbers would you like to multiply?");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        total = num1*num2;

        user1.CalcStatement(total);

        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 4){
        Console.WriteLine("What two numbers would you like to divide");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        total = num1/num2;

        user1.CalcStatement(total);

        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 5){
        Console.WriteLine("What total would you like to check if it exists?");
        double findTotal = Convert.ToDouble(Console.ReadLine());
        user1.FindTotal(findTotal);

        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 6){
        Console.WriteLine("What total would you like to remove from list?");
        double removeTotal = Convert.ToDouble(Console.ReadLine());
        user1.RemoveTotal(removeTotal);

        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 7){
        Console.WriteLine("Thanks for using our calculator. Goodbye!");
        repeat = false;

    } else{
        Console.WriteLine("You have entered an incorrect option");
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();
    } 
}