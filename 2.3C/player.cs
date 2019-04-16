using System;
using SplashKitSDK;

namespace GameProgram
{
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

}