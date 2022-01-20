using System.Collections;

namespace Collectionfunction{
    public class Collection
    {
        // Array initialization
        private int[] _nums = new int[5];

        // Generic Collection --------
        // List (No set size, specific data type, zero based index)
        private List<string> strings = new List<string>();

        // Hashset (no specific order, no duplicate elements)
        private HashSet<int> numbsCollection = new HashSet<int>();

        // Dictionary (no particular order, not zero based index)
        private Dictionary<string,int> _directory = new Dictionary<string, int>();


        // Non-generic Collection -------
        // ArrayList (can use different data types, can be indexed)
        private ArrayList _nonGeneric = new ArrayList();

        public void CollectionMain(){

            Console.WriteLine("----");

            _nums[0] = 3;
            _nums[1] = 10;
            _nums[2] = 4;

            // Looping through the array
            Console.WriteLine("--- Foreach Loop ---");

            foreach (int num in _nums){
                Console.WriteLine(num);
            }

            // For loops are for more complex manipulation
            Console.WriteLine("--- For Loop ---");

            for (int i = 0; i < _nums.Length; i++){
                Console.WriteLine(_nums[i]);
            }

            Console.WriteLine(">>> Generic Collections <<<");

            Console.WriteLine("--- List ---");
            strings.Add("First element");
            strings.Add("Second element");
            strings.Add("Thrid element");
            strings.Add("First element");

            foreach (string item in strings){
                Console.WriteLine(item);
            }
            Console.WriteLine(strings[1]);

            Console.WriteLine("--- Hashset ---");

            // Can't index through a hashset
            numbsCollection.Add(1);
            numbsCollection.Add(2);
            numbsCollection.Add(3);
            numbsCollection.Add(1);

            foreach (int item in numbsCollection){
                Console.WriteLine(item);
            }

            Console.WriteLine("---Dictionary---");
            // Keys need to be unique but values can repeat
            _directory.Add("Name1", 10);
            _directory.Add("Name2", 20);
            _directory.Add("Name3", 30);

            Console.WriteLine(_directory["Name2"]);
            Console.WriteLine(_directory["Name3"]);

            Console.WriteLine("--- Non-generic Collection ---");

            Console.WriteLine("ArrayList");

            _nonGeneric.Add("Name");
            _nonGeneric.Add(10);
            _nonGeneric.Add(true);
            _nonGeneric.Add(10.70);
        }
    }
}