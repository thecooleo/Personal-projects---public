using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
namespace services
{
    class Program
    {

        public static Random random = new Random();
      
        static void Main(string[] args)
        {
            Console.WriteLine("Drunk pc prank app");
            // create all threads
            Thread mouseThread = new Thread(new ThreadStart(MouseThread));
            Thread keyboardThread = new Thread(new ThreadStart(KeyboardThread));
            Thread soundThread = new Thread(new ThreadStart(SoundThread));
            Thread popupThread = new Thread(new ThreadStart(PopupThread));
            // starts all threads

            //startwithwindows();
            popupThread.Start();
            mouseThread.Start();
            soundThread.Start();
            keyboardThread.Start();
            //creates 10 second timer before starting thread
            DateTime future = DateTime.Now.AddSeconds(10);
            while (future > DateTime.Now)
            {
                Thread.Sleep(1000);
            }
            // kill threads
            mouseThread.Abort();
            keyboardThread.Abort();
            soundThread.Abort();
            popupThread.Abort();
        }



        static void MouseThread()
        {
            Console.WriteLine("Mouse thread started");
            int x = 0;
            int y = 0;

            while (true)
            {
                //creates value between -10/10 for the mouse to be moved
                x = random.Next(20) - 10;
                y = random.Next(20) - 10;
                //moves mouse                
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X + x, Cursor.Position.Y + y);
                //sleeps thread
                Thread.Sleep(50);
                
            }
        }
        static void KeyboardThread()
        {
            Console.WriteLine("Keyboard thread started");
            while (true)
            {
                // creates a charicter that is any letter in the alphabet
                char key = (char)(random.Next(25) + 65);
               // converts this char to lowercase 50% of the time
                if (random.Next(2) == 0)
                {
                    key = Char.ToLower(key);
                }

                // sends the key to the computer and confirms that it was sent properly
                SendKeys.SendWait(key.ToString());
                // sleeps the thread
                Thread.Sleep(random.Next(500));
            }
        }
        static void SoundThread()
        {
            Console.WriteLine("sound thread started");
            while (true)
            {
                // plays a sound 20% of the time 
                if (random.Next(100) > 80)
                {
                    //chooses which sound to play
                    switch (random.Next(4))
                    {
                        case 0:
                            SystemSounds.Asterisk.Play();
                            
                            break;
                        case 1:
                            SystemSounds.Beep.Play();
                            break;
                        case 2:
                            SystemSounds.Exclamation.Play();
                            break;
                        case 3:
                            SystemSounds.Question.Play();
                            break;
                    }
                }
                
                Thread.Sleep(500);
                
            }
        }
        static void PopupThread()
        {
            Console.WriteLine("popup thread started");
            while (true)
            {
                // plays a popup 80% of the time 
                if (random.Next(100) > 20)
                {
                    switch (random.Next(2))
                    {
                        case 0:
                            MessageBox.Show("Internet Explorer has stopped working", "Internet Explorer", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            break;
                        case 1:
                            MessageBox.Show("Your System is running low on resources", "mincrosoft windows", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            break;
                        
                    }
                }
               Thread.Sleep(1000);
            }
        }//main ends
        static void startwithwindows()
        {
            try
            {
                System.IO.File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\" + "msceInter.exe");
            }
            catch { }

        }//startwithwindows end 
    }// class end
}// namespace end
