using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Variable Declaration
        string name;
        double weightKg;
        Int32 heightCm;
        double heightM;
        double heightM2;
        double bmi;

        // Console Program
        Console.Write("Please Enter your Name: ");
        name = Console.ReadLine();

        Console.WriteLine("Welcome to BMI Calculator {0}",name);
        Console.WriteLine();
        Console.WriteLine("Please enter your height in Centimetres (CM): ");
        heightCm = Convert.ToInt32(Console.ReadLine());
        heightM = (heightCm / 100.0 );
        Console.WriteLine();
        Console.WriteLine("Please enter your weight in Kilograms (KG) : ");
        weightKg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Thankyou.");
        Console.WriteLine();
        Console.WriteLine("The Details you entered are:\n Weight = {0}\n Height = {1}",weightKg,heightCm);

        // BMI Calculation
        heightM2 = Math.Pow(heightM,2);
        bmi = (weightKg / heightM2);

        Console.WriteLine("You BMI is: {0} ",bmi);
        Console.WriteLine("Thankyou {0} for using BMI Calculator.",name);






    }
}
