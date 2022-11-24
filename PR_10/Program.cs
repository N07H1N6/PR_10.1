//********************************************************************************************
//*Практическая работа №10                                                                   *   
//* Выполнил: Кондаков.П.А.,группа 2ИСП                                                      *
//* Задание: получение практических навыков алгоритмизации и программирования вычислительных *
//*процессов с использованием двумерных массивов;                                            *
//********************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PR_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Объявление и инициализация
            try
            {
                int n, m, i = 0, j = 0;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Здравстуйте!");
                Console.Write("Практическая работа №10.");
                Console.Write("Выберите размерность массива n : 4 или 3:");
                n = Convert.ToInt32(Console.ReadLine());
                m = n;

                int[,] mas = new int[n, m];
                //2.заполнение двумерного массива
                Random rnd = new Random();
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        mas[i, j] = rnd.Next(-10, 10);
                    }
                }
                //3.Вывод массива на экран
                Console.WriteLine("Исходный массив");
                
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {                        
                        Console.Write(String.Format("{0,3}", mas[i, j]));
                    }
                    Console.Write("\n");

                }
                Console.WriteLine(" ");
                int buffer;
                int buffer2;
                Console.WriteLine("измененный массив");
                if (n == 3) //это для нечетного
                {
                    for (i = 0; i < m; i++)
                    {
                        buffer = mas[i, 0];
                        mas[i, 0] = mas[i, 1];
                        mas[i, 1] = buffer;
                    }

                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            if (j == 1 || j == 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Write(String.Format("{0,3}", mas[i, j]));
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(String.Format("{0,3}", mas[i, j]));
                            }
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                    }
                    buffer = 0;
                }


                else //это для чётного
                {
                    for (i = 0; i < m; i++)
                    {
                        buffer = mas[i, 0];
                        buffer2 = mas[i, 3];
                        mas[i, 0] = mas[i, 1];
                        mas[i, 3] = mas[i, 2];
                        mas[i, 1] = buffer;
                        mas[i, 2] = buffer2;
                    }
                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            if (j == 1 || j == 2)
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Write(String.Format("{0,3}", mas[i, j]));
                                Console.ResetColor();
                            }                            
                            else
                            {
                                Console.Write(String.Format("{0,3}", mas[i, j]));
                            }
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка ввода данных!" + e.Message);
            }
            Console.ReadKey();
        }
        
    }
}

        