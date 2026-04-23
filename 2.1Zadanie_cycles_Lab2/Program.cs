using System;

class Program
{
    // Задание 1 Цикл for 
    static void Main(string[] args)
    {
        //Теоретическая часть
        //*Пример цикла while

        //int counter = 0;
        //while (counter < 10)
        //{
        //    Console.WriteLine($"Hello World! The Counter is: {counter}");
        //    counter++;
        //}

        //*Пример цикла do..while

        //int counter = 0;
        //do
        //{
        //    Console.WriteLine($"Hello World! The Counter is: {counter}");
        //    counter++;

        //} while ( counter < 10 );

        //for (int counter = 10; counter <= 100; counter+=5)
        //{
        //    Console.WriteLine($"Htllo world! The counter is:{counter}");
        //}

        //for (char column = 'a'; column < 'k'; column++)
        //{
        //    for (int row = 1; row < 11; row++)
        //    {
        //        Console.WriteLine($"The cell is ({row},{column})");
        //    }

        //}
        //Практическая часть решение задачи 1
        Console.WriteLine("Введите диапозон вычисления сумы делителей на 3:\n");
        Console.WriteLine("Введите первое число:");
        int i1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int i2 = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        if (i1 > i2)
        {
            int temp = i1;
            i1 = i2;
            i2 = temp;
        }
        for (int v = i1; v <= i2; v++)
        {
            if (v%3 == 0)
            {
                Console.WriteLine(v);
                result += v;
            }
        }
        Console.WriteLine(result);

    }
}