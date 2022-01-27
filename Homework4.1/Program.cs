using System;


namespace Homework4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int x, y;
            // Проверка введённых параметров на положительное число
            do
            {
                Console.WriteLine("Введите количество строк матрицы: ");
                y = int.Parse(Console.ReadLine());
                if (y <= 0)
                {
                    Console.WriteLine("Неверное значение\n");
                }
            } while (y <= 0);

            do
            {
                Console.WriteLine("Введите количество столбцов матрицы: ");
                x = int.Parse(Console.ReadLine());
                if (x <= 0)
                {
                    Console.WriteLine("Неверное значение\n");
                }
            } while (x <= 0);

            Console.Clear();

            Random rand = new Random();
            int[,] matrix = new int[y, x];

            Console.CursorLeft = 30;
            Console.WriteLine("\n = Матрица \n");
            // Вывод первого массива-матрицы
            for (int i = 0; i < y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < x; j++)
                {
                    matrix[i, j] = rand.Next(50);
                    Console.Write($"{matrix[i, j],5} ");
                }
                Console.WriteLine("|");
            }

            // Сложение всех элементов матрицы
            int add, add2, add3;
            int sum = 0;
            for (int i = 0; i < y; i++)
            {
               
                for (int j = 0; j < x; j++)
                {
                    add = matrix[i, j];
                    add2 = matrix[i, j];
                    add3 = ((add + add2)/2);
                    sum = sum + add3;
                }
                
            }
            Console.WriteLine("\n = Сумма чисел матрицы \n");
            Console.WriteLine($" {sum} ");
            Console.ReadLine();

        }

    }
}
