## The logic is:

`Account` stores money
`Card` stores PIN and connected account
`AtmService` handles ATM behavior

- test classes check that each method works correctly

## Example:

- account starts with 9000
- ATM starts with 11000
- wrong PIN returns false
- correct PIN returns true
- withdrawing 5000 succeeds
- account becomes 4000
- ATM becomes 6000
