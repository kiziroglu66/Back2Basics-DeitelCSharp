// AccountTest.cs
// Creating and manipulating an Account object.

class AccountTest
{
    static void Main()
    {
        // create an Account object and assign it to myAccount
        Account myAccount = new();

        // display myAccount's initial name (there isn't one)
        Console.WriteLine($"myAccount object's initial name is {myAccount.GetName()}");

        // prompt for and read the name, then put the name in the object
        Console.Write("Please enter the name of the account :");
        myAccount.SetName(Console.ReadLine());

        // display the name stored in the myAccount object
        Console.WriteLine($"myAccount object's name is {myAccount.GetName()}");

    }
}