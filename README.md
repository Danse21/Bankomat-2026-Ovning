## The logic is:

- `Account` stores money
- `Card` stores PIN and connected account
- `AtmService` handles ATM behavior

- test classes check that each method works correctly

## Example:

- account starts with 9000
- ATM starts with 11000
- wrong PIN returns false
- correct PIN returns true
- withdrawing 5000 succeeds
- account becomes 4000
- ATM becomes 6000

# ATM Simulation (C#)

This project is a simple simulation of an ATM (Automated Teller Machine) written in **C# using .NET**.  
The purpose of the project is to demonstrate **object-oriented programming and unit testing with xUnit**.

The system models the basic interaction between:

- A **bank account**
- A **bank card with a PIN**
- An **ATM machine**

Unit tests verify that the ATM behaves correctly in both successful and failure scenarios.

---

# Project Structure

MySolution
│
├── MyApp
│ ├── Program.cs
│ ├── Account.cs
│ ├── Card.cs
│ └── AtmService.cs
│
└── MyApp.Tests
├── AccountTest.cs
├── CardTest.cs
└── AtmServiceTest.cs

### MyApp

Contains the main ATM logic.

- **Account.cs**  
  Handles account balance, deposits, and withdrawals.

- **Card.cs**  
  Represents a bank card and verifies the user's PIN.

- **AtmService.cs**  
  Simulates ATM behavior such as inserting a card, entering a PIN, checking balance, depositing money, and withdrawing money.

- **Program.cs**  
  Demonstrates a simple ATM usage scenario.

### MyApp.Tests

Contains **xUnit unit tests** to verify the system works correctly.

Tests cover:

- Account deposits and withdrawals
- PIN verification
- ATM withdrawals
- ATM balance logic
- Failure scenarios such as insufficient funds

---

# Example Scenario

The ATM starts with **11000** and the account starts with **9000**.

Example interactions:

1. User inserts card
2. User enters incorrect PIN → rejected
3. User enters correct PIN → accepted
4. User checks balance → 9000
5. User withdraws 5000 → success
6. Account balance becomes 4000
7. ATM balance becomes 6000

The tests verify these behaviors automatically.

---

# How to Run the Project

### 1. Clone the repository

git clone https://github.com/YOUR\_USERNAME/YOUR\_REPOSITORY.git

### 2. Go to the project folder

cd YOUR_REPOSITORY

### 3. Build the solution

dotnet build

### 4. Run the unit tests

dotnet test

You should see output similar to:

Passed! 16 tests

---

# Running the Console Demo

You can also run the console example:

dotnet run --project MyApp

This will simulate a small ATM interaction in the console.

---

# Technologies Used

- **C#**
- **.NET**
- **xUnit**
- **dotnet CLI**

---

# Learning Goals

This project demonstrates:

- Object-oriented design in C#
- Separation of responsibilities between classes
- Writing unit tests with xUnit
- Testing both successful and failing scenarios
- Structuring a .NET solution with multiple projects

---

# Possible Improvements

Future improvements could include:

- Limiting the number of incorrect PIN attempts
- ATM withdrawal limits
- Multiple accounts per card
- Transaction history
- Logging

---

# Author

Created as part of a **software testing and integration course assignment**.
