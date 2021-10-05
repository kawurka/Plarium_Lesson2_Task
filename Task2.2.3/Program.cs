using System;

namespace Task2._2._3
{
    /*Дано натуральное число. Найти число, получаемое удалением из исходного всех цифр а.*/
    class Program
    {
        static int Edit(ref int n, int x)
        {
            int m = 0, k;
            while (n != 0) //Используя алгоритм из прошлой задачи, я решил немного улучшить его.
            {
                k = n % 10;
                if (k != x) // Рассматривая каждый остаток от деления, мы НЕ записываем его, если он совпадает с заданной цифрой
                {
                   m = 10 * m + k;
                }     
                n /= 10; 
            }                  //Но число у нас развернутое, поэтому
            while (m != 0) //Запускаем повторный цикл, чтобы повернуть его обратно
            {
                n = n * 10 + m % 10;
                m /= 10;
            }
            

            return n; 
        }
        static void Main(string[] args)
        {
            Random random = new Random(10000); //Указал начальное значение большим, чтобы увеличить шансы нахождения цифры в числе.
            int n = random.Next(); // Случайным образом генерируем натуральное число
            int x = random.Next(0, 9); 
            Console.WriteLine("Number {0} and digit {1} ", n, x);
            Edit(ref n, x);
            Console.WriteLine("Number without digit: " + Edit(ref n, x));

            
        }
    }
}
