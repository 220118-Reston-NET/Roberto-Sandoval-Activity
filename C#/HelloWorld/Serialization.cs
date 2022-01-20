using System.Text.Json;
using CarFunction;

namespace SerializationFunction
{
    /*
        - Serialization is the process of converting C# objects into JSON
        - Collection memory is temporary so this saves the data for later use
    */
    
    public class Serialization
    {
        private static string _filepath = "./Database/Car.json";
        public static void SerialMain()
        {
            Console.WriteLine("--- Serialization Demo ---");

            Console.WriteLine("--- Converting object to JSON ---");
            List<Car> listOfCars = new List<Car>();
            Car car1 = new Car()
            {
                Color = "silver",
                Fuel = 50,
                Owner = "Stephen"
            };

            listOfCars.Add(car1);
            listOfCars.Add(car1);

            // Create a JSON file if there isn't one or overwrite (Make data in an easier readable format)
            string jsonString = JsonSerializer.Serialize(listOfCars, new JsonSerializerOptions{WriteIndented = true});
            Console.WriteLine(jsonString);

            File.WriteAllText(_filepath, jsonString);

            Console.WriteLine("--- Converting JSON to Object ---");
            string jsonString2 = File.ReadAllText(_filepath);

            List<Car> car2 = JsonSerializer.Deserialize<List<Car>>(jsonString2);

            Console.WriteLine(car2[0].Color);
            Console.WriteLine(car2[0].Fuel);
            Console.WriteLine(car2[0].Owner);

        }
    }
}