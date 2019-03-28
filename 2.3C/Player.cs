using SplashKitSDK;

public class Player{

    private Bitmap _PlayerBitmap;
    // Read/Write Variables
    public double X { get; set; }
    public double Y { get; set; }
    // Read Only Variables?
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

    public Player(Window gameWindow, double X, double Y) {
        
        Bitmap _PlayerBitmap = new Bitmap("Player","Player.png");

        X = (gameWindow.Width - Width)/2;
        Y = (gameWindow.Height - Height)/2;

    }

    public void Draw()
    {
        
    }
}
