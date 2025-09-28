using System; // Import the System namespace for basic functionalities like Console

// Define an interface named IQuittable
// This interface declares a method called Quit that does not return a value (void)
public interface IQuittable
{
    void Quit(); // Method signature - no implementation here
}

// Define the Employee class
// This class implements the IQuittable interface, which requires defining the Quit method
public class Employee : IQuittable
{
    // Public property for employee ID
    public int Id { get; set; }

    // Public property for employee first name
    public string FirstName { get; set; }

    // Public property for employee last name
    public string LastName { get; set; }

    // Implementation of the Quit method from IQuittable interface
    public void Quit()
    {
        // You can customize this message however you'd like
        Console.WriteLine($"{FirstName} {LastName} has quit the company.");
    }
}

// Define the main Program class
class Program
{
    // Main method - the entry point of the application
    static void Main(string[] args)
    {
        // Instantiate an Employee object and assign values to its properties
        Employee emp = new Employee
        {
            Id = 1,
            FirstName = "Hanadi",
            LastName = "Mohamad"
        };

        // Use polymorphism to assign the Employee object to a variable of type IQuittable
        IQuittable quittableEmp = emp;

        // Call the Quit method using the IQuittable interface reference
        // This demonstrates polymorphism: the method call is resolved at runtime
        quittableEmp.Quit();

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
