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
    public class Player
    {

        public Bitmap PlayerBitmap { get; set; }
        private Bitmap _PlayerBitmap;
        public double Xcoord { get; set; }
        public double Ycoord { get; set; }
        public int Width { 
            get
            {
                return _PlayerBitmap.Width;
            } 
        }
        public int Height { 
            get
            {
                return _PlayerBitmap.Height;
            }
        }

        public Player(Window gameWindow) {
            
            // Bitmap _PlayerBitmap; 
            _PlayerBitmap = new Bitmap("Player","Player.png");
            PlayerBitmap = _PlayerBitmap;

            Xcoord = (gameWindow.Width - Width)/2;
            Ycoord = (gameWindow.Height - Height)/2;
            
        }
    }   

    public class DrawMethod
    {
        public static void Draw()
        {
            Window gameWindow;

            gameWindow = new Window("Game Window",500,500);
            Player Character = new Player(gameWindow);

            gameWindow.Clear(Color.White);
            gameWindow.Refresh(60);
            gameWindow.DrawBitmap(Character.PlayerBitmap,Character.Xcoord, Character.Ycoord);
            gameWindow.Refresh(60);

            SplashKit.Delay(10000);
        }
    }

}