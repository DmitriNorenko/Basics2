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
            //var sumArray = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            //int sum = 0;
            //for(int i = 0; i < sumArray.Length; i++)
            //{
            //    sum += sumArray[i];
            //}
            //Console.WriteLine(sum);
            //////////////////////////Задание 4.3.14
            //var array = new int[3][];
            //array[0] = new int[2] { 1, 2 };
            //array[1] = new int[3] { 1, 2, 3 };
            //array[2] = new int[5] { 1, 2, 3, 4, 5 };
            //foreach (var item in array)
            //{
            //foreach ( var item2 in item)
            //    {
            //        Console.Write(item2 + " ");
            //    }
            //Console.WriteLine();
            //}
            //////////////////////////Задание 4.3.15
            //var array3 = new int[] { 1, -13, 3, -7, -19, -7, 6, 14, -67 };
            //int count = 0;
            //for (int i = 0; i < array3.Length; i++)
            //{
            //    if (array3[i] >= 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            //////////////////////////////Задание 4.3.16
            //int[,] array4 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            //int count = 0;
            //for (int i = 0; i < array4.GetUpperBound(0) + 1; i++)
            //{
            //    for (int k = 0; k < array4.GetUpperBound(1) + 1; k++)
            //    {
            //        if (array4[i,k] >= 0)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine(count);
            ////////////////////////////Задание 4.3.17
            // int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            // int c = 0;
            // for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            // {
            //     for (int j = 1; j < arr.GetUpperBound(1) + 1; j++)
            //     {
            //         for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
            //         {
            //             if (arr[i, k] > arr[i, j])
            //             {
            //                 c = arr[i, j];
            //                 arr[i, j] = arr[i, k];
            //                 arr[i, k] = c;
            //             }
            //         }
            //     }
            // }
            //for( int i =0;i<arr.GetUpperBound(0) + 1; i++)
            // {
            //     for(int k = 0;k<arr.GetUpperBound(1) +1;k++)
            //     {
            //         Console.Write(arr[i,k]+" ");
            //     }
            //     Console.WriteLine();
            // }
            ////////////////////////////Задание 4.4.5
            (string Name, string Type, double Age, int NameCount) Pet;
            Console.WriteLine("Введите имя питомца: ");
            Pet.Name = Console.ReadLine();
            Console.WriteLine("Введите тип питомца: ");
            Pet.Type = Console.ReadLine();
            Console.WriteLine("Введите возраст питомца: ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;
            Console.WriteLine("В имени вашего питомца :{0} букв", Pet.NameCount);
            Console.ReadLine();
        }
    }
}