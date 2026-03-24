namespace MyApp; // Places the class inside the MyApp namespace

public class Account // Defines the Account class
{
    private int _balance; // Stores the account balance in a private field

    public Account(int balance) // Constructor that runs when an account is created
    {
        _balance = balance; // Sets the starting balance
    }

    public int GetBalance() // Method that returns the current account balance
    {
        return _balance; // Returns the balance
    }

    public bool Withdraw(int amount) // Method that tries to withdraw money from the account
    {
        if (amount <= 0) // Checks that the amount is greater than zero
        {
            return false; // Returns false if the amount is invalid
        }

        if (amount > _balance) // Checks if the account has enough money
        {
            return false; // Returns false if there is not enough money
        }

        _balance -= amount; // Decreases the balance by the withdrawal amount
        return true; // Returns true because the withdrawal succeeded
    }

    public bool Deposit(int amount) // Method that tries to deposit money into the account
    {
        if (amount <= 0) // Checks that the deposit amount is greater than zero
        {
            return false; // Returns false if the amount is invalid
        }

        _balance += amount; // Increases the balance by the deposit amount
        return true; // Returns true because the deposit succeeded
    }
}