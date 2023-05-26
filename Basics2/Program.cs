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
            //string A = "Привет!";
            //string B = "Пока!";
            //bool C = A != B;
            //Console.WriteLine(C);
            ///////////////////////////////
            //int a = 4, b = 3;
            //double x = 7, y = 5;
            //bool c = (a < b) || (x > y);
            //Console.WriteLine(c);
            //////////////////////////////
            //var inv = true;
            //var result = !inv;
            //Console.WriteLine(result);
            //////////////////////////////
            //var f = 6;
            //var g = 7;

            //if (f != g)
            //{
            //    Console.WriteLine("Условие истинно");
            //}
            //else
            //{
            //    Console.WriteLine("Условие ложно");
            //}
            /////////////////////////////////////////////
            //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            //var text = Console.ReadLine();
            //int t = 3;
            //do
            //{
            //    switch (text)
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;
            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is Cyan!");
            //            break;

            //        case "yellow":
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is Yellow!");
            //            break;
            //        case "stop": t = 0; break;
            //        default: continue;
            //    }
            //    t--;
            //}
            //while (t > 0);
            ///////////////////////////////////////////Задание 4.3.11
            //Console.WriteLine("Введите имя:");
            //string Name = Console.ReadLine();
            //foreach (var i in Name)
            //{
            //    Console.Write(i + " ");
            //}

            //for (int i = Name.Length; i != 0; i--)
            //{
            //    Console.Write(" " + Name[i - 1]);
            //}
            //Console.WriteLine();

            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.Write("\nКоличество строк: ");
            //Console.WriteLine(array.GetUpperBound(0) + 1 + " ");
            //Console.Write("Количество колонок: ");
            //Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

            //for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
            //    {
            //        Console.Write(array[k, i] + " ");
            //    }
            //    Console.WriteLine();
            //}
            ////////////////////////////////Задание 4.3.12
            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            //int c = 0;
            //for (int k = 0; k < arr.Length; k++)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[k] < arr[i])
            //        {
            //            c = arr[i];
            //            arr[i] = arr[k];
            //            arr[k] = c;
            //        }
            //    }
            //}
            //foreach (var n in arr)
            //{
            //    Console.Write(n+" ");
            //}
            ///////////////////////////Задание 4.3.13
            var sumArray = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;
            for(int i = 0; i < sumArray.Length; i++)
            {
                sum += sumArray[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}