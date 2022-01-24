namespace OOPFunction
{
    public class OOP
    {
        public static void OOPMain()
        {
            Console.WriteLine("--- Inheritance Demo ---");
            Dog dog1 = new Dog();
            dog1.Talk();
            dog1.Talk("German Sheppard");
        }
    }

    // Base/Parent class
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void Talk ()
        {
            Console.WriteLine("Animal is talking");
        }

        public void Talk(string p_talk)
        {
            Console.WriteLine($"{p_talk} is talking");
        }



        public Animal()
        {
            Name = "Animal";
            Color = "Navy Blue";
        }

        public Animal(string p_name)
        {
            Name = p_name;
            Color = "Navy Blue";
        }
    }

    // Derived/Child class
    public class Dog : Animal
    {
        public Dog() : base()
        {

        }
        public Dog(string p_name) : base(p_name)
        {

        }

        // Method Overriding
        public override void Talk()
        {
            Console.WriteLine("Barking");
        }

    }
}