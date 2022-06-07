// Account.cs

class Account
{
    private string name; // instance variable

    // method that sets the account name in the object
    public void SetName(string accountName)
    {
        name = accountName; // store the account name
    }

    // 
    public string GetName()
    {
        return name; // returns name's value to this method's caller
    }
}