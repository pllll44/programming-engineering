using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Array
{
    internal class Program
    {
        //Методы для примера 2
        static void DisplayArray(string[] arr)
        {
            Console.WriteLine(string.Join(",", arr));
        }

        static void ReverseArray(string[] arr)
        {
            Array.Reverse(arr);
        }

        static void ChangeElements(string[] arr)
        {
            arr[0] = "Mon";
            arr[1] = "Wed";
            arr[2] = "Fri";
        }

        //Метод для примера 5
        // Данный метод принимает целочисленный массив и выводит его
        static void Print2DArray(int[,] arr)
        {
            for (int i = 0; i< arr.GetLength(0); i++)
            { 
                for (int j = 0; j < arr.GetLength(1);j++)
                {
                    System.Console.WriteLine($"Element({0},{1}) = {2}", i, j, arr[i,j]);
                }
            }
        }

        static void Main(string[] args)
        {
            //Лабораторная №3 Массивы 
            // Пример 1 

            ////Объявление одномерного массива из 5 целых чисел
            //int[] array1 = new int[5];
            ////Объявить и задать значения элементов массива
            //int[] array2 = [1, 2, 3, 4, 5, 6];
            ////Объявить двумерный массив
            //int[,] multiDimensionalArray1 = new int[2, 3];
            ////Объявить и задать значения элементов массива
            //int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            ////Объявить зубчатый(рваный) массив
            //int[][] jaggedArray = new int[6][];
            ////Задать значения первого массива внутри зубчатого массива
            //jaggedArray[0] = [1, 2, 3, 4];


            //int[] array = new int[7];
            //Так как в примере используется версия языка C# 12.0 Заполнение массива выполнено квадратными скобками, версия C# на которой я делаю 7.3 поэтому заполнение делаю фигурными скобками

            //Пример 2
            string[] weekDayes = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            for (int i = 0; i < weekDayes.Length; i++)
            {
                Console.WriteLine($"День {i}: {weekDayes[i]}");
            }

            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            Console.WriteLine("Исходный массив:");
            DisplayArray(weekDays);
            Console.WriteLine();

            ReverseArray(weekDays);
            Console.WriteLine("После переворота:");
            DisplayArray(weekDays);
            Console.WriteLine();

            ChangeElements(weekDays);
            Console.WriteLine("После изменения элементов:");
            DisplayArray(weekDays);

            //Пример 3 Многомерный массив

            //int[,] array2DDeclaration = new int[4,2];

            //int[,,] array3DDeclaration = new int[4, 2, 3];

            //int[,] array2DDeclaration = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            int[,,] array3D = new int[,,] { { { 1,2,3},{4,5,6 } },
                                           { {7,8,9 },{10,11,12 } } };

            //int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            //foreach (int i in numbers2D)
            //{
            //    System.Console.WriteLine($"{i} ");
            //}

            //Пример 4
            //Контроль вывода элементов массива

            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        System.Console.Write($"{array3D[i, j, k]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            //Пример 5
            //Метод принимает значения массиива
            Print2DArray(new int[,] { { 9, 99 }, { 3, 33 }, { 5, 55 } });


            //Пример 6 массивы массивов
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 12 };

            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 12 }
            };

            jaggedArray2[0][1] = 77;

            jaggedArray2[2][1] = 88;

            int[][,] jaggedArray3 = new int[][,]
            {
                    new int[,] { { 1, 3},
                                 { 5, 7} },

                    new int[,] { { 0, 2},
                                 { 4, 6},
                                 {8,10 } },

                    new int[,] { { 11, 20},
                                 { 99, 98},
                                 {0,9 } },
            };



        }
    }
}
