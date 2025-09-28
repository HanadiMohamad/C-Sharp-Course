using System; // Import the System namespace to use basic functionality like Console

namespace MathOperationApp // Define a namespace to contain the class and main program
{
    // Create a class called MathProcessor
    class MathProcessor
    {
        // Create a method that takes two integers and returns void (no return value)
        public void ProcessNumbers(int num1, int num2)
        {
            // Perform a math operation on the first integer (e.g., multiply by 2)
            int result = num1 * 8;

            // Display the result of the operation
            Console.WriteLine("The result of the operation on the first number is: " + result);

            // Display the second number as required
            Console.WriteLine("The second number is: " + num2);
        }
    }

    // Main program class
    class Program
    {
        // The Main method is the entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the MathProcessor class
            MathProcessor processor = new MathProcessor();

            // Call the method using positional arguments
            // This passes 5 as num1 and 10 as num2
            processor.ProcessNumbers(25, 30);

            // Call the method again, this time using named arguments
            // This explicitly assigns values to the parameter names
            processor.ProcessNumbers(num1: 17, num2: 28);

            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
