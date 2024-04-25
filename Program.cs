
// Final Project
// Author : Deepak Poly
// Course : SODV 1202

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Connect4_Final_Ptoject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WriteLine("Hello there! ");
            Console.WriteLine("The game is all center aligned. So befor playing the game please set the console size full or stable.");
            Console.WriteLine(" ");
            Console.WriteLine("HEADPHONES recommended // ");
            Console.WriteLine("Press any key to start the game !");
            Console.ReadKey();

            Console.Clear();

            Credits c = new Credits();
            c.ShowCredits();

            // Setting controller for gameboard
            Controller controller = new Controller();
            
            // menu display
            Menu menu = new Menu();
            menu.MenuDisplay(controller, menu); 
        }


        // function for aligning items in center
        public static void ConsoleCenter(string text)
        {

            int totalWidth = Console.WindowWidth;
            int textWidth = text.Length;
            int padding = (totalWidth - textWidth) / 2;

            Console.Write(string.Format("{0," + (padding + textWidth) + "}", text));

        }

        // function for typeWrite animation
        public static void typeWrite(string text, int delay = 50)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }

    }
}
