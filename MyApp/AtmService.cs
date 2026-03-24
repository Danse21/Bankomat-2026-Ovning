namespace MyApp; // Places the class inside the MyApp namespace

public class AtmService // Defines the AtmService class
{
    private Card? _insertedCard; // Stores the currently inserted card or null if no card is inserted
    private bool _loggedIn; // Stores whether the user has entered the correct PIN

    public int AtmBalance { get; private set; } // Stores the ATM balance and allows only this class to change it

    public AtmService(int balance) // Constructor that runs when an ATM is created
    {
        AtmBalance = balance; // Sets the ATM starting balance
    }

    public void InsertCard(Card card) // Method that inserts a card into the ATM
    {
        _insertedCard = card; // Saves the inserted card
        _loggedIn = false; // Resets login status when a new card is inserted
    }

    public bool EnterPin(string pin) // Method that checks the entered PIN
    {
        if (_insertedCard == null) // Checks if no card is inserted
        {
            return false; // Returns false because PIN cannot be checked without a card
        }

        _loggedIn = _insertedCard.CheckPin(pin); // Checks if the entered PIN is correct and saves the result
        return _loggedIn; // Returns true if login succeeded, otherwise false
    }

    public int GetBalance() // Method that returns the balance of the connected account
    {
        if (_insertedCard == null || !_loggedIn) // Checks if there is no card or the user is not logged in
        {
            throw new InvalidOperationException("Not authorized"); // Throws an error if the user is not authorized
        }

        return _insertedCard.Account.GetBalance(); // Returns the account balance
    }

    public bool Withdraw(int amount) // Method that tries to withdraw money through the ATM
    {
        if (_insertedCard == null || !_loggedIn) // Checks if there is no card or the user is not logged in
        {
            throw new InvalidOperationException("Not authorized"); // Throws an error if the user is not authorized
        }

        if (amount <= 0) // Checks that the withdrawal amount is valid
        {
            return false; // Returns false if the amount is invalid
        }

        if (amount > AtmBalance) // Checks if the ATM has enough cash
        {
            return false; // Returns false if the ATM does not have enough money
        }

        bool ok = _insertedCard.Account.Withdraw(amount); // Tries to withdraw the money from the account

        if (!ok) // Checks if the account withdrawal failed
        {
            return false; // Returns false if the account did not have enough money
        }

        AtmBalance -= amount; // Decreases the ATM balance after a successful withdrawal
        return true; // Returns true because the withdrawal succeeded
    }

    public bool Deposit(int amount) // Method that deposits money into the connected account
    {
        if (_insertedCard == null || !_loggedIn) // Checks if there is no card or the user is not logged in
        {
            throw new InvalidOperationException("Not authorized"); // Throws an error if the user is not authorized
        }

        return _insertedCard.Account.Deposit(amount); // Deposits money into the account and returns the result
    }
}