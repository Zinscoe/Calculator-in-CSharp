using System.Net.Security;

internal class Program
{
    private static void Main(string[] args)
    {
        string answer;
        int num1;
        int num2;
        int result;

        // Asks User for first number and reads their input
        Console.WriteLine("Welcome to the Calculator Program.");
        Console.WriteLine("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        // Asks User for second number and reads their input
        Console.WriteLine("Please enter your second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What kind of operation would you like to do?");
        Console.WriteLine("Please enter an 'a' for Addition. 's' for Subtraction, 'm' for Multiplication, or a 'd' for Division.");

        answer = Console.ReadLine();

        if (answer == "a")
        {
            result = num1 + num2;
            Console.WriteLine($"Your answer is {result}.");
        }
        else if (answer == "s")
        {
            result = num1 - num2;
            Console.WriteLine($"Your answer is {result}.");
        }
        else if (answer == "m")
        {
            result = num1 * num2;
            Console.WriteLine($"Your answer is {result}.");
        }
        else if (answer == "d")
        {
            result = num1 / num2;
            Console.WriteLine($"Your result is {result}.");
        }
    }
}
