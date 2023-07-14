using System;

class BankAccount
{
    private int accountNumber;
    public int AccountNumber {
        get 
        {
            return accountNumber;
        }
        set
        {
            accountNumber = value;
        }
    }
    private double balance = 0;
    public BankAccount(int _accountNumber)
    {
        accountNumber = _accountNumber;
    }
    public void Deposit(double amount) 
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}, New balance: {balance}.");
    }
    public void WithDraw(double amount)
    {
        if (amount <= balance) 
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount},New balance: {balance}.");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}

