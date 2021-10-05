using System;

namespace Task1._1
{
    //Номер в списке - 13
    //Задание: Написать программу, которая введет 5 значений и посчитает произведение чисел, делящихся без остатка на 7 или 3.
    class Program
    {
        public static void Func()
        {
            int mult = 1;
            int[] arr = new int[5];
            Random rn = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rn.Next(0, 30);
            }
            Console.WriteLine("Array numbers: ");
            foreach (int element in arr)
            {
                Console.WriteLine(element);
                if (element % 7 == 0 || element % 3 == 0)
                {
                    mult *= element;
                }
            }
            if (mult == 1)
            {
                Console.WriteLine("No numbers found");
            }
            else
            {
                Console.WriteLine("Nubmers multiplication: " + mult);
            }
        }



        static void Main(string[] args)
        {
            Func();
        }
    }   
 }
