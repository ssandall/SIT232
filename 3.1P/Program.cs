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
                GuessThatNumber();
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
            try
            {
            Option = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Your selection is invalid. Please enter a valid number");
                Option = -1;
            }
        } while (Option < 1 || Option > 3);
        return (MenuOption)(Option - 1);
    }

    private static void TestName()
    {
        string userName;
        Console.WriteLine("You Have Selected Test Name");
        Console.Write("Please eneter your name: ");
        userName = Console.ReadLine();

        if(userName.ToLower() == "suriya")
        {
            Console.WriteLine("Welcome my human overlord!");
        }
        else if (userName.ToLower() == "jake")
        {
            Console.WriteLine("Wassup "+ userName);
        }
        else
        {
            Console.WriteLine("Hello "+ userName);
        }
    }

    private static void GuessThatNumber()
    {
        int target;
        int userGuess;
        int lowestGuess = 1;
        int highestGuess = 100;
        string lowGuess = Convert.ToString(lowestGuess);
        string highGuess = Convert.ToString(highestGuess);

        target = new Random().Next(100) +1;
        Console.WriteLine("Guess a number between {0} and {1}",lowGuess,highGuess);
        do
        {
            userGuess = ReadGuess(lowestGuess,highestGuess);
            if (userGuess < target)
            {
                Console.WriteLine("Your Guess is Lower than the answer");
                lowestGuess = userGuess;
            }
            else if(userGuess > target)
            {
                Console.WriteLine("Your guess is Higher than the answer");
                highestGuess = userGuess;
            }
            else
            {
                Console.Write("You guessed the number!");
            }
        } 
        while (userGuess != target);
    }

    private static int ReadGuess(int min,int max)
    {
        int enteredValue;
        Console.WriteLine("Enter a guess between {0} and {1}",min,max);
        do
        {
            try
            {
            enteredValue = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid Entry, please enter a number between {0} and {1}.",min,max);
                enteredValue = -1;
            }
        } 
        while (enteredValue < min || enteredValue > max);

        Console.WriteLine("You chose "+ enteredValue);
        return(enteredValue);
    }
}
