// Addition.cs
// Displaying the sum of two numbers input from the keyboard.

class Addition
{
    static void Main()
    {
        int number1; // declare first number to add
        int number2; // declare second number to add
        int sum;     // declare sum of number1 and number2

        Console.WriteLine("Please enter first integer :");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second integer :");
        number2 = int.Parse(Console.ReadLine());

        sum = number1 + number2;

        Console.WriteLine($"The sum of {number1} and {number2} is {sum}");
    }
}
