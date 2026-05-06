using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_operator_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Лабораторная работа 3.2 Оператор foreach

            //Синтаксис

            //foreach( элемент in in итерируемый объект) 
            //{
            //Тело цикла
            //}

            //Пример 1 Вывод элементов массива с помощью оператора for
            //char[] array = {"H","e","l","l","o","W","o","r","l","d"};

            //for (int i = 0; i < array.Lenght; i++)
            //{
            //Console.Writeline(array[i]);
            //}

            //Пример 2 Вывод элементов массива с помощью оператора foreach
            //foreach (char ch in array)
            //{
            //Console.Writeline(ch);
            //}

            //Пример 3 Перебор массива, содержащего данные о поле соискателя
            //char [] gender = {'м','ж','м','ж','м','ж','м','ж','м','ж',};
            //int mans = 0,womens = 0;

            //foreach (char g in gender)
            //{
            //if (g == 'м')
            //mans++;
            //else 
            //womens++;

            //}

            //Console.Writeline("Количество мужчин ровно: {0}", mans);
            //Console.Writeline("Количество женщин ровно: {0}", womens);

            //Пример 4 работа цикла foreach сщ списком
            // Сума элементов списка

            //var numbers = new list<int> {5,-8,2,15,9,17,0,4};

            //int sum = 0;

            //foreach (int num in numbers) 
            //{
            //sum+=num;
            //}
            //Console.Writeline(sum);
        }
    }
}
