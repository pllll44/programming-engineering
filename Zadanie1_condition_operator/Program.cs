using System;
using System.Reflection.Metadata.Ecma335;

namespace Lab_2
{
    internal class Program
    {
        static void перваяЗадача(double a, double b, double c)
        {
            // уровнение A*x2 + B*x + C=0
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Любое x.");
                    }
                    else
                    {
                        Console.WriteLine("Нет корней.");
                    }
                }
                else
                {
                    double x = -c / b;
                    Console.WriteLine($"x = {x}");
                }

            }
            else
            {
                double disc = b * b - 4 * a * c;
                if (disc >= 0)
                {
                    disc = Math.Sqrt(disc);
                    double x1 = ((-b + disc) / (2 * a));
                    double x2 = ((-b - disc) / (2 * a));
                    Console.WriteLine($"x1 = {x1}\tx2 = {x2}");

                }
                else { 
                    Console.WriteLine("Нет вещественных корней");
                }
            }
                
            
        }
        static void втораяЗадача(double a, double b, double c)
        {
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            if (b > c)
            {
                double temp = b;
                b = c;
                c = temp;
            }

            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a * a + b * b > c * c)
                {
                    double p = (a + b + c) / 2;
                    double s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
                    Console.WriteLine($"Площадь остроугольного треугольника ровна S={s}");
                }
                    else
                    {
                        Console.WriteLine("Это не остроугольный треугольник!!");
                    }

            }
            else
            {
                Console.WriteLine("Это не треугольник!");
            }
        }
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("1 - Первая задача\n");
                Console.WriteLine("2 - Вторая задача\n");
                Console.WriteLine("0 - Выход");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("Решение квадратного уровнения: A*x2 + B*x + C=0");
                            Console.WriteLine("Введите параметр a = ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nВведите параметр b = ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nВведите параметр c = ");
                            double c = Convert.ToDouble(Console.ReadLine());
                            перваяЗадача(a, b, c);
                            Console.WriteLine("Попробовать еще раз?\n");
                            Console.WriteLine("1 - Да");
                            Console.WriteLine("2 - Нет");
                           int exit = Convert.ToInt32(Console.ReadLine());
                            if (exit == 2)
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                        }
                        
                        break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("Решение поиска площади треугольника");
                            Console.WriteLine("Введите параметр a = ");
                            double a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nВведите параметр b = ");
                            double b = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\nВведите параметр c = ");
                            double c = Convert.ToDouble(Console.ReadLine());
                            втораяЗадача(a, b, c);
                            Console.WriteLine("Попробовать еще раз?\n");
                            Console.WriteLine("1 - Да");
                            Console.WriteLine("2 - Нет");
                            int exit = Convert.ToInt32(Console.ReadLine());
                            if (exit == 2)
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Clear();
                        }

                        break;
                        

                        
                }
                if (input == 0)
                    break;
            }
            
        }
    }
}