using System;

namespace Task3._1._1
{   /*В одномерном целочисленном массиве переставить элементы в обратном порядке, не используя других массивов. */
    class Program
    {
        static void Swap(int[] arr) //функция, в которой мы меняем местами элементы массива
        {
            int i = 0;
            int j = arr.Length - 1;
            int temp;
            while (i < j) //По сути алгоритм простой, состоит он в том, что мы меняем местами первый и последний элемент
            {             //До тех пор, пока не дойдём до условной половины массива
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            Console.Write("Reversed array: ");
            foreach (int element in arr)
            {
                Console.Write(element);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 0,1,2,3,4};
            Console.Write("Array: ");
            foreach (int element in arr) //Вывод изначального массива
            {
                Console.Write(element);
            }
            Console.WriteLine("");
            Swap(arr);
        }
    }
}
