using System;

namespace Task2._2._2
{
    /*Дано натуральное число. Найти число, получаемое при прочтении его цифр справа налево.*/
    class Program
    {
        static int Reverse(int n) // Функция, в которой мы отзеркаливаем число
        {
            int m = 0, k;
            while (n != 0) //По сути мы используем тот же остаток от деления, что и в предыдущем задании.
            {
                k = n % 10;
                m = 10 * m + k; //Грубо говоря, мы инверсируем деление числа n, и т.к. за добавление остатка отвечает переменная k,
                n /= 10;        //Мы как бы "сдвигаем" последнюю полученную цифру с помощью умножения 10*m
            }
            return m;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(); // Случайным образом генерируем натуральное число
            Console.WriteLine("Number: " + n);
            Reverse(n);
            Console.WriteLine("Reverse number: " + Reverse(n));
            
        }
    }
}
