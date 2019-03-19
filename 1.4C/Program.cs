using System;
using SplashKitSDK;

namespace Animation
{
    public class Program
        {
            public static void Main()
                {
                    // Variables
                    // Window Variables
                    Window page1;
                    // Sound Effect Variables
                    SoundEffect Alert;
                    SoundEffect Door;
                    SoundEffect Footsteps;
                    SoundEffect Sigh;
                    // Bitmap Variables
                    Bitmap frameOne;
                    Bitmap frameTwo;
                    Bitmap frameThree;
                    Bitmap frameFour;
                    // Variable Assignment
                    frameOne = new Bitmap("Frame 1","1st.png");
                    frameTwo = new Bitmap("Frame 2","2nd.png");
                    frameThree = new Bitmap("Frame 3","3rd.png");
                    frameFour = new Bitmap("Frame 4","4th.png");

                    Alert = new SoundEffect("Alert","iphone_text_message.wav");
                    Door = new SoundEffect("Door","door squeak.wav");
                    Footsteps = new SoundEffect("Footsteps","running.wav");
                    Sigh = new SoundEffect("Sigh","sigh.wav");
                    // Page Drawing, Sound Effect Playing
                    page1 = new Window("Page 1",800,800);
                    page1.Clear(Color.Black);
                    page1.DrawBitmap(frameOne,80,80);
                    page1.Refresh();
                    Alert.Play();

                    SplashKit.Delay(5000);

                    page1.Clear(Color.Black);
                    page1.DrawBitmap(frameTwo,80,80);
                    page1.Refresh();
                    Footsteps.Play();

                    SplashKit.Delay(5000);

                    page1.Clear(Color.Black);
                    page1.DrawBitmap(frameThree,80,80);
                    page1.Refresh();
                    Door.Play();

                    SplashKit.Delay(5000);

                    page1.Clear(Color.Black);
                    page1.DrawBitmap(frameFour,80,80);
                    page1.Refresh();
                    Sigh.Play();

                    SplashKit.Delay(5000);


                }
        }   
}

