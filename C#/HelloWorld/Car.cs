namespace CarFunction
{
    public class Car
    {
        // Fields
        private string _color = "Blue";
        private string _owner;
        private int _gallonPerMile;

        // Property
        public string Color{

            // Getter and setter
            get{ return "The color is "+_color; }
            set{ _color = value; }
        }

        
        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        
        public int Fuel { get; set; }

        // Method
        public void Start(){

            Console.WriteLine("The car is starting up");
            Console.WriteLine($"Current fuel: {Fuel}");
        }

        public void Start(int p_fuel){

            Fuel = p_fuel;
            Console.WriteLine("The car is starting up");
            Console.WriteLine($"Current fuel: {Fuel}");
        }

    }

}