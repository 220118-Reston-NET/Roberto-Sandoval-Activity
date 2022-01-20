namespace ConversionFunction
{
    public class ConversionFunction
    {
        public static int _num;

        public static void ConversionMain(){
            // Implicit Conversion (something is done automatically for you - The compiler takes care of it)
            // Explicit Conversion (you have to write something to have it done)

            Console.WriteLine("--- Conversion Demo ---");
            int x = 10;
            double y = 85.29;
            string str = "Hello World";
            string doubleStr = "85.29.";

            // Implicit conversion
            double anotherDouble = x;
            Console.Write(anotherDouble);

            // Explicit Conversion
            // You might loose data in doing so
            int anotherInt = (int)y;
            Console.WriteLine(anotherInt);

            double anotherdouble2 = Convert.ToDouble(doubleStr);

        }

        public int GiveMeNumber(){
            return _num;
        }

    }
}