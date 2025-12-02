namespace ConstructorOverloading
{
    public class ConOverloading
    {
        // Instance variables (fields)
        int i;         // Will store integer value
        string? str;   // Will store string value

        // ---------------------------------------------
        // Constructor 1: DEFAULT CONSTRUCTOR
        // No parameters → Used when object is created without passing any value
        // ---------------------------------------------
        public ConOverloading()
        {
            // Default values: i = 0, str = null
        }

        // ---------------------------------------------
        // Constructor 2: PARAMETERIZED (int)
        // Used when user passes an integer
        // ---------------------------------------------
        public ConOverloading(int i)
        {
            this.i = i; // 'this' differentiates instance variable from parameter
        }

        // ---------------------------------------------
        // Constructor 3: PARAMETERIZED (string)
        // Used when user passes a string
        // ---------------------------------------------
        public ConOverloading(string? str)
        {
            this.str = str;
        }

        // ---------------------------------------------
        // Constructor 4: OVERLOADED (int + string)
        // Used when user passes BOTH int and string
        // ---------------------------------------------
        public ConOverloading(int i, string? str)
        {
            this.i = i;
            this.str = str;
        }

        // ---------------------------------------------
        // Method to display field values
        // This shows what values were assigned by the constructor
        // ---------------------------------------------
        public void Display()
        {
            Console.WriteLine("Value of i: " + i + " String: " + str);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Object 1 → Calls default constructor
            ConOverloading obj1 = new ConOverloading();
            obj1.Display();

            // Object 2 → Calls constructor with int parameter
            ConOverloading obj2 = new ConOverloading(10);
            obj2.Display();

            // Object 3 → Calls constructor with string parameter
            ConOverloading obj3 = new ConOverloading("Hello");
            obj3.Display();

            // Object 4 → Calls constructor with both int + string
            ConOverloading obj4 = new ConOverloading(50, "Hii");
            obj4.Display();

            Console.ReadLine();
        }
    }
}
