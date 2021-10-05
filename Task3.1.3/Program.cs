using System;

namespace Task3._1._3
{   /*В одномерном целочисленном массиве x[1]…x[n+m], рассматриваемом как соединение двух его отрезков: 
    начала x[1]…x[n] длины n и конца x[n]… [n+m] длины m, 
    переставить местами начало и конец, не используя дополнительных массивов.  */
    class Program
    {
        static int n = 4;
        static int m = 2;
        public static void Shuffle(ref int[] arr) //принцип - я отсортировую малый отрезок, а затем большой путём перестановок.
        {
            int temp;
            int i = 0;
            int j = n;
            while (j <= n+m-1 && i < m)  //малый отрезок идёт в начало, часть большего - в конец
            {
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j++;
            }
                
            
            int left = m;
            int right = n;
            int t;
            while (left < n && right <= n+m-1)  //"сортирую" больший отрезок
            {
                t = arr[left];
                arr[left] = arr[right];
                arr[right] = t;
                left++;
                right++;
            }
            Console.WriteLine("Shuffeled array: ");
            foreach(int element in arr)
            {
                Console.Write(element + "");
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[n+m];           //заполняем массив
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 9);
            }
            Console.WriteLine("Array: ");
            foreach (int element in arr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Shuffle(ref arr);
        }
    }
}
