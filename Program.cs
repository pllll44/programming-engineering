using System;

namespace Lab_2_2
{
        static void Main(string[] args)
        {
            //Пример 1
            //int i = 1;

            //while (i <= 5)
            //{
            //    Console.WriteLine("Цикл while C#: итерация {0}", i);
            //    i++;
            //}

            //Console.WriteLine("Нажмите Enter для выхода...");
            //Console.ReadLine();

            //Пример 2

            // for
            //for (byte i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //// while
            //byte j = 0;
            //while (j <= 10)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}

            // while с вводом
            //bool outInProg = true;

            //while (outInProg)
            //{
            //    string end = Console.ReadLine();

            //    if (end == "конец")
            //        outInProg = false;
            //}

            //Пример 3

            //int i = 0, sum = 0;

            //while (i<=5)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine($"Сумма = {sum}");


            //Пример 4
            //byte i = 100;

            //do
            //{
            //    i++;
            //} while (i<=10);

            //Пример 5

            //int i = 0, n=5, product;
            //do
            //{
            //    product = n*i;
            //    Console.WriteLine($"{n} * {i} = {product}");
            //    i++;
            //} while (i <= 10); 


            //Пример 6

            //for (short i = 0; i<10;i++)
            //{
            //    if (i > 5)
            //        break;
            //    Console.WriteLine(i);
            //}

            //Пример 7

            for (short i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
            }


        }
    
}