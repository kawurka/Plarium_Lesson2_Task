using System;

namespace Task2._2._1
{
    /* Дано натуральное число.  Определить, есть ли в нем цифры а и b. */
    class Program
    {
        static bool Check(int a, int b, int n) //Функция, в которой описан метод нахождения цифр с помощью остатка от делния
        {
            bool B = false;
            bool A = false;
            while (n != 0)
            {
                if (n % 10 == a)
                {
                    A = true;
                }
                if (n % 10 == b)
                {
                    B = true;
                }
                n /= 10;
            }
            return (A && B) ? true : false; // использован оператор ? для удобного возвращения значения 0 и 1 соответственно
        }
        static void Main(string[] args)
        {
           
            Random random = new Random();
            int a = random.Next(0, 9);
            int b = random.Next(1, 9); //для уменьшения шанса повтора значения a
            Console.WriteLine("Digits: " + a + " " + b);
            int n = random.Next(100, 10000); // Случайным образом генерируем натуральное число
            Console.WriteLine("Number: " + n);
          
            if (Check(a, b, n)) //Т.к. функция типа bool, вывод с помощью if подходит лучше всего 
            {
                Console.WriteLine("Number {0} has digits {1}, {2} ", n, a, b);
            }
            else
            {
                Console.WriteLine("Number {0} hasn't digits {1}, {2} ", n, a, b);
            }
        }
    }
}
