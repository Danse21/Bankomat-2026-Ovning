using MyApp; // Imports the MyApp namespace so the classes can be used

Account account = new Account(9000); // Creates an account with 9000 kronor
Card card = new Card("0123", account); // Creates a card with PIN 0123 connected to the account
AtmService atm = new AtmService(11000); // Creates an ATM with 11000 kronor

atm.InsertCard(card); // Inserts the card into the ATM

Console.WriteLine(atm.EnterPin("1234")); // Tries a wrong PIN and prints the result
Console.WriteLine(atm.EnterPin("0123")); // Tries the correct PIN and prints the result
Console.WriteLine(atm.GetBalance()); // Prints the account balance

Console.WriteLine(atm.Withdraw(5000)); // Withdraws 5000 and prints whether it succeeded
Console.WriteLine(atm.GetBalance()); // Prints the new account balance
Console.WriteLine(atm.AtmBalance); // Prints the new ATM balance
