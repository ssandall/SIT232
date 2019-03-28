using System;
using SplashKitSDK;

public enum MenuOption {
    TestName,
    GuessThatNumber,
    Quit
}

public class Program
{
    public static void Main()
    {
        MenuOption userSelection;
        do{
            userSelection = ReadUserOption();
            // Console.WriteLine("You selected: " + userSelection);

            switch (userSelection) 
            {
                case MenuOption.TestName:
                TestName();
                break;

                case MenuOption.GuessThatNumber:
                Console.WriteLine("You Have Selected Guess That Number");
                break;

                case MenuOption.Quit:
                Console.WriteLine("You Have Chosen Quit, Thankyou.");
                break;
            }
        }while(userSelection != MenuOption.Quit);
    }

    private static MenuOption ReadUserOption()
    {
        int Option;
        Console.WriteLine("Please make a selection");
        Console.WriteLine("1, will run TestName, 2 will run Guess that number, 3 Wil quit the program.");
        do 
        {
            Option = Convert.ToInt32(Console.ReadLine());
        } while (Option < 1 || Option > 3);
        return (MenuOption)(Option - 1);
    }

    private static void TestName()
    {
        string userName;
        Console.WriteLine("You Have Selected Test Name");
        Console.Write("Please eneter your name: ");
        userName = Console.ReadLine();
        Console.WriteLine("Hello "+ userName); 

        
    }
}
