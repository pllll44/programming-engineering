using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__1_test
{
    internal class Program
    {
        //Лабораторная работа №1 
        //в данной лабороторной работе будут отработаны все изученные базовые навыки языка С#
        static void ShowCars(string[] car)
        {
            Console.WriteLine("\nМашины:\n");
            for (int i = 0; i < car.Length; i++)
            {
                Console.Write(car[i] + " ");
            }
            Console.WriteLine();
        }
        struct Car
        {
            public string Name;
            public int Year;
        }
        static void Main(string[] args)
        {
            //Пример объявление массива
         
            int i = 0;
            string [] car = new string[10];
            car[0] = "camry";
            car[1] = "chaser";
            car[2] = "mark_2";
            car[3] = "crown";
            car[4] = "supra";
            car[5] = "celica";
            car[6] = "corolla";
            car[7] = "prius";
            car[8] = "rav4";
            car[9] = "Land_Cruser";

            
            string[,] divaces = new string[5, 5];
            divaces[0,0] = "Свеча зажигания";
            divaces[0, 1] = "Аккумулятор";
            divaces[0, 2] = "Генератор";
            divaces[0, 3] = "Стартер";
            divaces[0, 4] = "Радиатор";

            divaces[1, 0] = "Тормозные колодки";
            divaces[1, 1] = "Диск сцепления";
            divaces[1, 2] = "Амортизатор";
            divaces[1, 3] = "Фильтр воздушный";
            divaces[1, 4] = "Фильтр масляный";

            divaces[2, 0] = "Топливный насос";
            divaces[2, 1] = "Инжектор";
            divaces[2, 2] = "Дроссель";
            divaces[2, 3] = "Ремень ГРМ";
            divaces[2, 4] = "Цепь ГРМ";

            divaces[3, 0] = "Подшипник";
            divaces[3, 1] = "Ступица";
            divaces[3, 2] = "Шаровая опора";
            divaces[3, 3] = "Рулевая тяга";
            divaces[3, 4] = "Рулевая рейка";

            divaces[4, 0] = "Глушитель";
            divaces[4, 1] = "Катализатор";
            divaces[4, 2] = "Лямбда-зонд";
            divaces[4, 3] = "Бензобак";
            divaces[4, 4] = "Турбина";
            //Вывод машин
                Console.WriteLine("\n"+"Объявление и заполнение массива машин:" + "\n");
                for (i = 0; i < car.Length; i++)
                {
                    Console.Write(car[i] + " ");
                }
                Console.WriteLine();
            //Вывод дивайсов
                Console.WriteLine("\n"+"Объявление и заполнение массива девасы:" + "\n");
                for (i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(divaces[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            

            //Арифметические и логические операции
            Console.WriteLine("\n"+"Арифметические и логические операции:" + "\t");

            int a, b, c, d;
            a = 10;
            b = 11;
            c = a + b;
            d = a - b;
            double e = Convert.ToDouble(c)/b;
            Console.WriteLine("a= {0}",a);
            Console.WriteLine("b= {0}", b);
            Console.WriteLine("c= {0}", c);
            Console.WriteLine("d= {0}", d);
            Console.WriteLine("e= {0}", e);

            //Циклы
            Console.WriteLine("\n"+"Цикл for:" + "\t");
                for (i = 0; i < 5; i++) {
                    if (a % 2 == 0 || b % 3 == 0)
                    {
                        a++;
                        b++;
                        Console.WriteLine("a = {0}", a);
                        Console.WriteLine("b = {0}", b);
                    }
                    else
                    {
                        a = +2;
                        b = +2;
                        Console.WriteLine("a = {0}", a);
                        Console.WriteLine("b = {0}", b);
                    }
                }
            i = 0;


                
            
            Console.WriteLine("\n"+"Цикл While:" + "\t");
            
                while (i < car.Length)
                {
                    Console.WriteLine("Mark - toyota:" + car[i]);
                    i++;
                }

            
            //функциии смотреть выше ^^^
            //                      |||
            //Null_i(i);
            ShowCars(car);

            Console.WriteLine("\n" + "Структура для заполнения информации о машине:" + "\t");
            Car[] garage = new Car[2];

            garage[0].Name = car[0];
            garage[0].Year = 2020;

            garage[1].Name = car[1];
            garage[1].Year = 2000;
            for ( i = 0; i < garage.Length; i++)
            {
                Console.WriteLine(garage[i].Name + " " + garage[i].Year);
            }
            Console.WriteLine("Нажми Enter чтобы выйти");
            Console.ReadLine();
        }
        
    }
}
