using System;

public class Account{

    private Decimal _balance;
    private String  _name;

    // Read Only Account Name
    public string Name{

        get { return _name;}

    }

    // Account Constructor
    public Account (string name, decimal startingBalance){

        _name = name;
        _balance = startingBalance;
    }

    // Deposit Method
    public void Deposit(decimal amountToAdd){

        _balance = _balance + amountToAdd;

    }

    // Withdraw Method
    public void Withdraw(decimal amountToWithdraw){

        _balance = _balance - amountToWithdraw;

    }

    // Print Details to console
    public void Print(){

        Console.WriteLine("Account Name is : {0}",_name);
        Console.WriteLine("Account Balance is : {0}",_balance);

    }

    

}