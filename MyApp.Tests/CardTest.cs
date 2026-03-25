using MyApp; // Imports the namespace with the classes to test
using Xunit; // Imports xUnit so [Fact] and Assert can be used

namespace MyApp.Tests; // Places the test class inside the MyApp.Tests namespace

public class CardTest // Defines the test class for Card
{
    [Fact] // Marks this method as a test
    public void CheckPin_Returns_True_For_Correct_Pin() // Tests that the correct PIN is accepted
    {
        Account account = new Account(9000); // Creates an account
        Card card = new Card("0123", account); // Creates a card with PIN 0123

        Assert.True(card.CheckPin("0123")); // Checks that the correct PIN returns true
    }

    [Fact]
    public void CheckPin_Returns_False_For_Wrong_Pin() // Tests that the wrong PIN is rejected
    {
        Account account = new Account(9000); // Creates an account
        Card card = new Card("0123", account); // Creates a card with PIN 0123

        Assert.False(card.CheckPin("1234")); // Checks that the wrong PIN returns false
    }
}