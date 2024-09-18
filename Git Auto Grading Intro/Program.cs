namespace StudentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Welcome to the calculator project, complete the methods

            // Call the methods here ex.
            int result = Add(2, 3);
            Console.WriteLine("The result of adding 2 and 3 is: " + result);
            result = Subtract(5, 3);
            Console.WriteLine("The result of subtracting 5 and 3 is: " + result);
            result = Multiply(2, 3);
            Console.WriteLine("The result of Multipling 2 and 3 is: " + result);
            result = (int)Divide(6, 3);
            Console.WriteLine("The result of Dividing 2 and 3 is: " + result);
        }

        // Methods Here
        public static int Add(int a, int b)
        {
            // Code
            return a+b; // Placeholder

        }
        public static int Subtract(int a, int b)
        {
            // Code
            return a - b; // Placeholder
        }
        public static int Multiply(int a, int b)
        {
            // Code
            return a*b; // Placeholder
        }
        public static decimal Divide(int a, int b)
        {
            // Code
            return a/b; // Placeholder
        }
    }
}
