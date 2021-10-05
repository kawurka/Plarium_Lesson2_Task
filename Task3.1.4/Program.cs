using System;

namespace Task3._1._4
{   /*Дана целочисленная прямоугольная матрица. Определить:
количество столбцов, содержащих хотя бы один нулевой элемент;
номер строки, в которой находится самая длинная серия одинаковых элементов.
*/
    class Program
    {
       
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Size of matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n+1];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n+1; j++)
                {
                    matrix[i, j] = random.Next(0, 10); //Заполнение и вывод матрицы
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine("");
            }
            int count = 0;
            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[j, i] == 0)
                    {
                        count++;              //считываем наличие нулей каждого столбца 
                        break;
                    }
                }
            }
            Console.WriteLine("Amount of 0: " + count);
            int temp = 0;
            int equal = 0;
            int flag = -1;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (matrix[i,j] == matrix[i, j + 1]) //рассчитываем серию идентичных элементов, самую большую заносим в temp
                    {
                        equal++;
                    }
                }
                if(equal > temp)
                {
                    temp = equal;
                    flag = i;        //номер строки, если мы нашли серию повторов, присваиваем флагу
                }
            }
            if (flag == -1)
            {
                Console.WriteLine("There is no row with same elements!");
            }
            else
            {
                Console.WriteLine("Row with the longest series of elements : " + (flag+1));
            }
        }
    }
}
