﻿using System;
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
            /////////////////////////////////////////////
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var Color = Console.ReadLine();
            int t = 3;
            do
            {
                switch (Color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is Cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is Yellow!");
                        break;
                }
                var Text = Console.ReadLine();
                if (Text == "stop") break;
                t--;
            }
            while (t > 0);
            Console.ReadLine();
        }
    }
}

