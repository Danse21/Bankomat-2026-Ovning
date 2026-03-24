namespace MyApp; // Places the class inside the MyApp namespace

public class Card // Defines the Card class
{
    public string PinCode { get; } // Stores the card PIN code
    public Account Account { get; } // Stores the connected account

    public Card(string pinCode, Account account) // Constructor that runs when a card is created
    {
        PinCode = pinCode; // Saves the PIN code
        Account = account; // Saves the connected account
    }

    public bool CheckPin(string pin) // Method that checks whether the entered PIN is correct
    {
        return PinCode == pin; // Returns true if the entered PIN matches the stored PIN
    }
}