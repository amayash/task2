using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("С каким массивом будем работать?");
                Console.WriteLine("1. Одномерный");
                Console.WriteLine("2. Двумерный");
                ConsoleKeyInfo d = Console.ReadKey();
                if (d.Key == ConsoleKey.UpArrow)
                {
                    num = 1;
                }
                if (d.Key == ConsoleKey.DownArrow)
                {
                    num = 2;
                }
                Random r = new Random();
                if (num == 1)
                {
                    Console.Clear();
                    Console.WriteLine("С каким массивом будем работать?");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1. Одномерный");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("2. Двумерный");
                    Console.ForegroundColor = ConsoleColor.Gray;

                } else
                {
                    Console.Clear();
                    Console.WriteLine("С каким массивом будем работать?");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("1. Одномерный");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("2. Двумерный");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                try
                {
                    switch (num)
                    {
                        case 1:
                            {
                                int size = 0;
                                int how = 0;

                                Console.WriteLine("Введите размер массива");
                                try { 
                                    size = Convert.ToInt32(Console.ReadLine());
                                } catch (Exception c) {
                                    Console.WriteLine(c.Message);
                                    break;
                                }

                                nom5 arr = new nom5(size);
                                Console.WriteLine("Как будет задавать массив?\n1. Вручную\n2. Случайно");
                                
                                try
                                {
                                    how = Convert.ToInt32(Console.ReadLine());
                                } catch (Exception c)
                                {
                                    Console.WriteLine(c.Message);
                                    break;
                                }
                                switch (how)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("Начните вводить элементы");
                                            for (int i = 0; i < size; i++)
                                                arr[i] = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine("Ваш массив: " + arr.Print());
                                        }
                                        break;
                                    case 2:
                                        {
                                            Console.WriteLine("Ваш массив: ");
                                            for (int i = 0; i < size; i++)
                                            {
                                                arr[i] = r.Next(10);
                                                Console.Write(arr[i] + " ");
                                            }

                                        }
                                        break;
                                        default: throw new Exception();
                                }
                                arr.work();
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Введите размер массива. Кол-во строк и столбцов");
                                int n = Convert.ToInt32(Console.ReadLine());
                                int m = Convert.ToInt32(Console.ReadLine());
                                int[,] arr2 = new int[n, m];
                                Console.WriteLine("Как будет задавать массив?\n1. Вручную\n2. Случайно");
                                int how2 = Convert.ToInt32(Console.ReadLine());
                                if (how2 == 1)
                                {
                                    Console.WriteLine("Начните вводить элементы");
                                    for (int i = 0; i < n; i++)
                                    {
                                        for (int j = 0; j < m; j++)
                                        {
                                            arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                                        }
                                    }
                                    Console.WriteLine("Ваш массив:");
                                    for (int i = 0; i < n; i++)
                                    {
                                        for (int j = 0; j < m; j++)
                                        {
                                            Console.Write(arr2[i, j] + "\t");
                                            Console.Write("|");
                                        }
                                        Console.WriteLine();
                                    }
                                    int max = 0;
                                    int maxst = 0;
                                    int st = 0;
                                    for (int i = 0; i < n; i++)
                                    {
                                        for (int j = 0; j < m; j++)
                                        {
                                            if (arr2[i, j] > max)
                                            {
                                                max = arr2[i, j]; maxst = i;
                                            }
                                            if (arr2[i, j] < 0)
                                            {
                                                if (arr2[i, j] % 2 == -1)
                                                {
                                                    st = i;
                                                }
                                            }
                                        }
                                    }
                                    Console.WriteLine("Строка с отрицательным - " + st + "\nСтрока с макс. - " + maxst);
                                    int[,] dubl = new int[1, m];
                                    for (int i = 0; i < 1; i++)
                                    {
                                        for (int j = 0; j < m; j++)
                                        {
                                            dubl[i, j] = arr2[maxst, j];
                                        }
                                    }
                                    for (int i = 0; i <= st; i++)
                                    {
                                        for (int j = 0; j < m; j++)
                                        {
                                            Console.Write(arr2[i, j] + "\t");
                                            Console.Write("|");
                                        }
                                        Console.WriteLine();
                                    }
                                    for (int j = 0; j < m; j++)
                                    {
                                        Console.Write(dubl[0, j] + "\t");
                                        Console.Write("|");
                                    }
                                    Console.WriteLine();
                                    for (int i = st + 1; i < n; i++)
                                    {
                                        for (int j = 0; j < m; j++)
                                        {
                                            Console.Write(arr2[i, j] + "\t");
                                            Console.Write("|");
                                        }
                                        Console.WriteLine();
                                    }

                                }
                                if (how2 == 2)
                                {
                                    for (int i = 0; i < n; i++)
                                    {
                                        for (int j = 0; j < m; j++)
                                        {
                                            arr2[i, j] = r.Next(100);
                                            Console.Write(arr2[i, j] + "\t");
                                            Console.Write("|");
                                        }
                                        Console.WriteLine();
                                    }
                                }
                            }
                            break;
                        default: throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadLine();
            }
        }
    }
}
