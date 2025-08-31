using System;

class Program
{
    static void Main()
    {
        // Initial user instruction
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Gather and evaluate weight first
        Console.Write("Weight of package (lbs): ");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Reject package if it's too heavy
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Proceed to dimension inputs
        Console.Write("Width (in inches): ");
        decimal w = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Height (in inches): ");
        decimal h = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Length (in inches): ");
        decimal l = Convert.ToDecimal(Console.ReadLine());

        // Evaluate size restriction
        if ((w + h + l) > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate and present final quote
        decimal quote = (w * h * l * weight) / 100;
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");
        Console.WriteLine("Thank you!");
    }
}
