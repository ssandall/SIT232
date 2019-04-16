using System;
using SplashKitSDK;

namespace GameProgram
{
    public class Program
    {
        public static void Main()
        {
            DrawMethod.Draw();
        }  
    }
    public class DrawMethod
    {
        public static void Draw()
        {
            Window gameWindow;

            gameWindow = new Window("Game Window",800,800);
            Player Character = new Player(gameWindow);

            gameWindow.Clear(Color.White);
            gameWindow.Refresh(60);
            gameWindow.DrawBitmap(Character.PlayerBitmap,Character.Xcoord, Character.Ycoord);
            gameWindow.Refresh(60);

            SplashKit.Delay(10000);
        }
    }

}