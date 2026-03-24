using MyApp; // Imports the namespace with the classes to test
using Xunit; // Imports xUnit so [Fact] and Assert can be used

namespace MyApp.Tests; // Places the test class inside the MyApp.Tests namespace

public class AccountTest // Defines the test class for Account
{
    [Fact] // Marks this method as a test
    public void GetBalance_Returns_Initial_Balance() // Tests that the constructor sets the starting balance correctly
    {
        Account account = new Account(9000); // Creates an account with 9000
        Assert.Equal(9000, account.GetBalance()); // Checks that GetBalance returns 9000
    }

    [Fact] // Marks this method as a test
    public void Withdraw_Decreases_Balance_When_Enough_Money() // Tests successful withdrawal
    {
        Account account = new Account(9000); // Creates an account with 9000
        bool result = account.Withdraw(5000); // Tries to withdraw 5000

        Assert.True(result); // Checks that the withdrawal succeeded
        Assert.Equal(4000, account.GetBalance()); // Checks that the new balance is 4000
    }

    [Fact] // Marks this method as a test
    public void Withdraw_Returns_False_When_Not_Enough_Money() // Tests failed withdrawal when balance is too low
    {
        Account account = new Account(4000); // Creates an account with 4000
        bool result = account.Withdraw(5000); // Tries to withdraw more than the balance

        Assert.False(result); // Checks that the withdrawal failed
        Assert.Equal(4000, account.GetBalance()); // Checks that the balance did not change
    }

    [Fact] // Marks this method as a test
    public void Deposit_Increases_Balance() // Tests successful deposit
    {
        Account account = new Account(4000); // Creates an account with 4000
        bool result = account.Deposit(1000); // Deposits 1000

        Assert.True(result); // Checks that the deposit succeeded
        Assert.Equal(5000, account.GetBalance()); // Checks that the new balance is 5000
    }
}