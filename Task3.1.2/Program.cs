using System;

namespace Task3._1._2
{   /*Найти количество элементов массива, встречающихся в нем один раз. */
    class Program
    {
        static void Unique(int[] arr)
        {
            int k = 0;
            for (int i=0; i < arr.Length; i++) //просматриваем весь массив
            {
                for(int j=0; j < arr.Length; j++) //сравниваем одно число с остальными в массиве
                {
                  if ( j != i) 
                    {
                        if (arr[i] == arr[j]) //если это не одно и то же число, то записываем его как дупликат
                        {
                            k++;
                            break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                
            }
            Console.WriteLine("Amount of unique elements: " + (arr.Length-k)); //отнимаем от размерности массива число дупликатов
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length;i++)
            {
                arr[i] = random.Next(0,9);
            }
            Console.WriteLine("Array: ");
            foreach(int element in arr)
            {
                Console.Write(element + " ");
            }
            Unique(arr);

        }
    }
}
