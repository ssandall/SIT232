using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {

        Account jaccount = new Account("Jake's Account", 200000);
        jaccount.Print();
        jaccount.Deposit(500);
        jaccount.Print();
        jaccount.Withdraw(500);
        jaccount.Print();

        Account account = new Account("Suriya's Account", 100000);
        account.Print();
        account.Deposit(2000);
        account.Print();
        account.Withdraw(2000);
        account.Print();

    }
}
