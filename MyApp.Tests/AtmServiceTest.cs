using MyApp; // Imports the namespace with the classes to test
using Xunit; // Imports xUnit so [Fact] and Assert can be used

namespace MyApp.Tests; // Places the test class inside the MyApp.Tests namespace

public class AtmServiceTest // Defines the test class for AtmService
{
    [Fact] // Marks this method as a test
    public void EnterPin_Returns_False_For_Wrong_Pin() // Tests that a wrong PIN is rejected
    {
        Account account = new Account(9000); // Creates an account with 9000
        Card card = new Card("0123", account); // Creates a card with PIN 0123
        AtmService atm = new AtmService(11000); // Creates an ATM with 11000

        atm.InsertCard(card); // Inserts the card into the ATM

        Assert.False(atm.EnterPin("1234")); // Checks that a wrong PIN returns false
    }

    [Fact] // Marks this method as a test
    public void EnterPin_Returns_True_For_Correct_Pin() // Tests that the correct PIN is accepted
    {
        Account account = new Account(9000); // Creates an account with 9000
        Card card = new Card("0123", account); // Creates a card with PIN 0123
        AtmService atm = new AtmService(11000); // Creates an ATM with 11000

        atm.InsertCard(card); // Inserts the card into the ATM

        Assert.True(atm.EnterPin("0123")); // Checks that the correct PIN returns true
    }

    [Fact] // Marks this method as a test
    public void GetBalance_Returns_Account_Balance() // Tests that balance can be read after login
    {
        Account account = new Account(9000); // Creates an account with 9000
        Card card = new Card("0123", account); // Creates a card with PIN 0123
        AtmService atm = new AtmService(11000); // Creates an ATM with 11000

        atm.InsertCard(card); // Inserts the card into the ATM
        atm.EnterPin("0123"); // Logs in with the correct PIN

        Assert.Equal(9000, atm.GetBalance()); // Checks that the account balance is returned
    }

    [Fact] // Marks this method as a test
    public void Withdraw_5000_Works_When_Both_Account_And_Atm_Have_Money() // Tests a successful withdrawal of 5000
    {
        Account account = new Account(9000); // Creates an account with 9000
        Card card = new Card("0123", account); // Creates a card with PIN 0123
        AtmService atm = new AtmService(11000); // Creates an ATM with 11000

        atm.InsertCard(card); // Inserts the card into the ATM
        atm.EnterPin("0123"); // Logs in with the correct PIN

        bool result = atm.Withdraw(5000); // Tries to withdraw 5000

        Assert.True(result); // Checks that the withdrawal succeeded
        Assert.Equal(4000, atm.GetBalance()); // Checks that the account balance became 4000
        Assert.Equal(6000, atm.AtmBalance); // Checks that the ATM balance became 6000
    }

    [Fact] // Marks this method as a test
    public void Withdraw_Fails_When_Atm_Has_Too_Little_Money() // Tests failed withdrawal because the ATM lacks cash
    {
        Account account = new Account(9000); // Creates an account with 9000
        Card card = new Card("0123", account); // Creates a card with PIN 0123
        AtmService atm = new AtmService(6000); // Creates an ATM with only 6000

        atm.InsertCard(card); // Inserts the card into the ATM
        atm.EnterPin("0123"); // Logs in with the correct PIN

        bool result = atm.Withdraw(7000); // Tries to withdraw 7000

        Assert.False(result); // Checks that the withdrawal failed
        Assert.Equal(9000, atm.GetBalance()); // Checks that the account balance did not change
        Assert.Equal(6000, atm.AtmBalance); // Checks that the ATM balance did not change
    }

    [Fact] // Marks this method as a test
    public void Withdraw_Fails_When_Account_Has_Too_Little_Money() // Tests failed withdrawal because the account lacks money
    {
        Account account = new Account(4000); // Creates an account with only 4000
        Card card = new Card("0123", account); // Creates a card with PIN 0123
        AtmService atm = new AtmService(11000); // Creates an ATM with 11000

        atm.InsertCard(card); // Inserts the card into the ATM
        atm.EnterPin("0123"); // Logs in with the correct PIN

        bool result = atm.Withdraw(6000); // Tries to withdraw 6000

        Assert.False(result); // Checks that the withdrawal failed
        Assert.Equal(4000, atm.GetBalance()); // Checks that the account balance did not change
        Assert.Equal(11000, atm.AtmBalance); // Checks that the ATM balance did not change
    }
}