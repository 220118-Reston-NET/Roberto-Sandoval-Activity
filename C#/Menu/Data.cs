using System.Text.Json;

namespace Menufunction
{
    public class Menu
    {
        private static string _filepath = "./Database/Car.json";
        private Dictionary<string, double> _tracker = new Dictionary<string, double>();
        public string Name { get; set; }

        public void addNewDate(string p_date){
            _tracker.Add(p_date,0.0);
            Console.WriteLine($"The date {p_date} has been added to your budget log");
        }

        public void addAmount(double p_amount){
            string currKey = _tracker.Keys.Last();
            double currAmount = _tracker.Values.Last();

            _tracker[currKey] = currAmount+p_amount;
            Console.WriteLine($"The amount {p_amount} has been added to your current day expense");
        }

        public void subAmount(double p_amount){
            string currKey = _tracker.Keys.Last();
            double currAmount = _tracker.Values.Last();

            _tracker[currKey] = currAmount-p_amount;
            Console.WriteLine($"The amount {p_amount} has been subtracted from your current day expense");
        }

        public void printCurrExpense(){
            string currKey = _tracker.Keys.Last();
            Console.WriteLine($"The expense amount for today {currKey} is: ");
            Console.WriteLine(_tracker[currKey]);
        }

        public void printSpecificDate(string date){
            Console.WriteLine($"The expense amount for date {date} is: ");
            Console.WriteLine(_tracker[date]);
        }


        public void printAllDates(){
            Console.WriteLine("All dates on your budget log along with expenses are: ");

            string output = "";
            foreach (KeyValuePair<string, double> pair in _tracker){
                output += string.Format("Date: {0} Amount: {1}", pair.Key, pair.Value);
                output += "\n";
            }
            Console.WriteLine(output);
        }

        public void saveChanges(){
            string jsonString = JsonSerializer.Serialize(_tracker, new JsonSerializerOptions{WriteIndented = true});

            // Export dictionary data to JSON file
            File.WriteAllText(_filepath, jsonString);

            Console.WriteLine("All changes have been saved succesfully. Goodbye!");
        }

        public void loadData(){
            // Converting JSON to Object
            string jsonString2 = File.ReadAllText(_filepath);
            
            // Load Objects onto new dictionary
            Dictionary<string, double> _trackerNew = JsonSerializer.Deserialize<Dictionary<string, double>>(jsonString2);
            _tracker = _trackerNew;

            Console.WriteLine("Previous saved state hs been loaded succesfully");
        }


    }
}