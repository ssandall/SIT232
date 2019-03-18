using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("hello world");

        Window w = new Window("My First Program",200, 100);
        w.DrawText("Hello World", Color.Black, 10, 45);
        w.Refresh(60);
        SplashKit.Delay(5000);

    }
}
