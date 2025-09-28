using System; // Import the System namespace for basic functionalities like Console

// Define the Program class that contains Main and the Employee class
class Program
{
    // Entry point of the application
    static void Main(string[] args)
    {
        // Instantiate the first Employee object
        Employee emp1 = new Employee
        {
            Id = 1,
            FirstName = "Hanadi",
            LastName = "Mohamad"
        };

        // Instantiate the second Employee object
        Employee emp2 = new Employee
        {
            Id = 1,
            FirstName = "Bob",
            LastName = "Bob"
        };

        // Compare the two employees using the overloaded == operator
        bool areEqual = emp1 == emp2;

        // Display the result of the comparison
        Console.WriteLine("Are the two employees equal? " + areEqual);

        // Also demonstrate use of the != operator
        bool areNotEqual = emp1 != emp2;

        // Display the result of the inequality check
        Console.WriteLine("Are the two employees not equal? " + areNotEqual);

        // Wait for user input before exiting
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Define the Employee class
    public class Employee
    {
        // Public property for employee ID
        public int Id { get; set; }

        // Public property for first name
        public string FirstName { get; set; }

        // Public property for last name
        public string LastName { get; set; }

        // Overload the == operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If either is null, return false
            if ((object)emp1 == null || (object)emp2 == null)
                return false;

            // Compare based on Id
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator as required when overloading ==
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2); // Inverse of ==
        }

        // Override Equals to be consistent with operator overloads
        public override bool Equals(object obj)
        {
            // Try to cast the object to Employee
            Employee other = obj as Employee;

            // Return false if casting fails
            if (other == null)
                return false;

            // Use Id to determine equality
            return this.Id == other.Id;
        }

        // Override GetHashCode to be consistent with Equals
        public override int GetHashCode()
        {
            // Use Id's hash code
            return this.Id.GetHashCode();
        }
    }
}
