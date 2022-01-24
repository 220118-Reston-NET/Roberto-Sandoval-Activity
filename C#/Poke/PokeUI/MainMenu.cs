namespace PokeUI
{
    public class MainMenu : IMenu
    {

        public void Display()
        {
            Console.WriteLine("Welcome to Pokemon");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] Add Pokemon to your team");
            Console.WriteLine("[0] Exit");

        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "AddPokemon";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
        }
    }
}