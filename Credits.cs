using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Connect4_Final_Ptoject
{
    internal class Credits
    {
        public Credits() { }

        // i loved working on this credits page !!
        public void ShowCredits()
        {
            Sounds s = new Sounds();
            
            var leftMargin = (Console.WindowWidth - 31) / 2;
            Thread.Sleep(2000);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.CursorLeft = leftMargin;
            Program.typeWrite("PIXELPULSE Studios presents");
            Thread.Sleep(100);
            s.PlayIntro();
            Thread.Sleep(3500);
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.CursorLeft = leftMargin;
            Console.WriteLine(@"
                                                ____ ___  _   _ _   _ _____ ____ _____   _____ ___  _   _ ____  
                                               / ___/ _ \| \ | | \ | | ____/ ___|_   _| |  ___/ _ \| | | |  _ \ 
                                              | |  | | | |  \| |  \| |  _|| |     | |   | |_ | | | | | | | |_) |
                                              | |__| |_| | |\  | |\  | |__| |___  | |   |  _|| |_| | |_| |  _ < 
                                               \____\___/|_| \_|_| \_|_____\____| |_|   |_|   \___/ \___/|_| \_\
                                                                                                                                       
");
            Thread.Sleep(1500);
            Console.CursorLeft = leftMargin;
            Program.typeWrite("By Deepak Poly");
            Thread.Sleep(2500);
            Console.CursorLeft = leftMargin;
            Console.Write("@deepakpoly1980@gmail.com");
            Thread.Sleep(2000);
            Console.CursorLeft = leftMargin;
            Console.Write("                         ");
            Console.CursorLeft = leftMargin;
            Console.Write("Play with your friends and family");
            Thread.Sleep(2000);
            Console.CursorLeft = leftMargin;
            Console.Write("                                 ");
            Console.CursorLeft = leftMargin;
            Console.Write("Enjoy Guys!");
            Thread.Sleep(2000);

        }



    }
}
