// Comparison.cs
// Comparing integers using if statements, equality operators and relational operators.

class Comparison
{
    static void Main()
    {
        // prompt user to enter the first integer
        Console.Write("Please enter the first integer :");
        int number1 = int.Parse(Console.ReadLine());

        // prompt user to enter the second integer
        Console.Write("Please enter the second integer :");
        int number2 = int.Parse(Console.ReadLine());

        // check if is equal
        if (number1 == number2)
        {
            Console.WriteLine($"{number1} is equal to {number2}");
        }

        // check if not equal
        if (number1 != number2)
        {
            Console.WriteLine($"{number1} is not equal to {number2}");
        }

        // check if smaller
        if (number1 < number2)
        {
            Console.WriteLine($"{number1} is smaller than {number2}");
        }

        // check if smaller or equal
        if (number1 <= number2)
        {
            Console.WriteLine($"{number1} is smaller or equal to {number2}");
        }

        // check if greater.
        if (number1 > number2)
        {
            Console.WriteLine($"{number1} is greater than {number2}");
        }

        // check if greater than or equal
        if (number1 > number2)
        {
            Console.WriteLine($"{number1} is greater than or equal to {number2}");
        }
    }
}
