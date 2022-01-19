Console.Clear();
Console.WriteLine("Welcome user!");
Console.WriteLine("What is your name?");

string name = Console.ReadLine();
bool repeat = true;

while (repeat){
    Console.WriteLine($"Hello {name}, what calculation would you like to do today?");
    Console.WriteLine("Type 1 for addition");
    Console.WriteLine("Type 2 for subtraction");
    Console.WriteLine("Type 3 for multiplication");
    Console.WriteLine("Type 4 for division");
    Console.WriteLine("Type 5 to exit program");

    int userInput = Convert.ToInt32(Console.ReadLine());

    if (userInput == 1){
        
        Console.WriteLine("What two numbers would you like to add?");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The result is: {num1+num2}");
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 2){
        Console.WriteLine("What two numbers would you like to subtract?");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The result is: {num1-num2}");
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 3){
        Console.WriteLine("What two numbers would you like to multiply?");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The result is: {num1*num2}");
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 4){
        Console.WriteLine("What two numbers would you like to divide");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The result is: {num1/num2}");
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    } else if (userInput == 5){
        Console.WriteLine("Thanks for using our calculator. Goodbye!");
        repeat = false;

    } else{
        Console.WriteLine("You have entered an incorrect option");
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();
    }
}