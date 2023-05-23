using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = "Привет!";
            string B = "Пока!";
            bool C = A != B;
            Console.WriteLine(C);
            /////////////////////////////
            int a = 4, b = 3;
            double x = 7, y = 5;
            bool c = (a < b) || (x > y);
            Console.WriteLine(c);
            ////////////////////////////
            var inv = true;
            var result = !inv;
            Console.WriteLine(result);
            ////////////////////////////
            var f = 6;
            var g = 7;

            if (f != g)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }
            /////////////////////////////////////////
            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }
        }
    }
}
