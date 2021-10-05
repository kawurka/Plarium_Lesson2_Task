using System;

namespace Task1._2
{
    /*Предприниматель 1 марта открыл счет в банке, вложив 1000 руб. 
     Через каждый месяц размер вклада увеличивается на 2% от имеющейся суммы. Определить:
        а) прирост суммы вклада за первый, второй, ..., десятый месяц;
        б) сумму вклада через три, четыре, ..., двенадцать месяцев.*/
    class Program
    {
        public static void Bank() //Функция, в которой мы находим прирост суммы вклада
        {
            decimal cont = 1000; //Для работы с данными было решено взять тип decimal, т.к. задача про банк
            decimal sum;
            for (int i=0; i < 10; i++)
            {
                sum = (cont / 100) * 2; //вычисляем прирост суммы
                cont += sum; //Т.к. сумма зависит от общих вложений, добавляем прирост к вкладу
                Console.WriteLine("Sum scale after " + (i+1) + " month: " + Math.Round(sum,3) );
            }                                                               //Math.Round() для округления чисел

        }
        public static void Sum() //Функция, в которой мы находим саму сумму вклада
        {
            decimal summ = 1000;
           
            for (int i = 0; i < 12; i++)
            {
                summ += (summ / 100) * 2;
                if ( i >= 2) //Т.к. нас просят найти вклад от 3+ месяца, начинаем вывод с 3ьей итерации
                {
                    Console.WriteLine("Amount of contribution after " + (i + 1) + "month: " + Math.Round(summ,3));
                }
            }
        }

        static void Main(string[] args)
        {
            Bank();
            Sum();
        }
    }
}
