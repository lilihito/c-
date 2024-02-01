using System;

class SimpleCalculator
{
    static void Main()
    {
        // declare the variables.
        int num1, num2;

        // get the input from the user.
        Console.WriteLine("Enter first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        // performs the following arithmetic operations
        Console.WriteLine($" [Addition] Sum: {num1 + num2}");
        Console.WriteLine($" [Subtraction] Difference: {num1 - num2}");
        Console.WriteLine($" [Multiplication] Product: {num1 * num2}");

        // Check for division by zero
        if (num2 != 0)
        {
            double quotient = (double)num1 / num2;
            Console.WriteLine($" [Division] Quotient: {quotient}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }

        Console.ReadLine(); // Keep console window open
    }
}
