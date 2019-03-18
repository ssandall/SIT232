// using System;
using SplashKitSDK;

public class Program
{
    public static void Main(string[] args)
    {
        Window houseWindow;
        Window carWindow;

        // House window Section
        houseWindow = new Window("Shapes by ...", 800, 600);

        houseWindow.Clear(Color.White);
        houseWindow.FillEllipse(Color.BrightGreen, 0,400, 800, 400);
        houseWindow.FillRectangle(Color.Gray, 300, 300, 200, 200);
        houseWindow.FillTriangle(Color.Red, 250, 300, 400, 150, 550, 300);
        houseWindow.Refresh();
        
        // Car Window Section
        carWindow = new Window("Car Window", 800,600);

        carWindow.Clear(Color.LightBlue);
        carWindow.FillRectangle(Color.Red, 150, 300, 500, 200);
        carWindow.FillTriangle(Color.Black, 250,300,350,300,350,200);
        carWindow.FillRectangle(Color.Black,350,200,150,100);
        carWindow.FillTriangle(Color.Black,500,300,500,200,550,300);
        carWindow.FillCircle(Color.Black,250,500,60);
        carWindow.FillCircle(Color.Black,550,500,60);
        carWindow.Refresh();


        SplashKit.Delay(10000);
    }
}
