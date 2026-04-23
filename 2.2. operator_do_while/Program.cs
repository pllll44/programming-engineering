using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2.operator_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {

                // ========================
                // Пример 1 — простой while
                // ========================
                int i = 1;

                while (i <= 5)
                {
                    Console.WriteLine($"Итерация {i}");
                    i++;
                }

                Console.WriteLine("-----");

                // ========================
                // Пример 2 — for и while
                // ========================
                for (byte k = 0; k <= 10; k++)
                {
                    Console.WriteLine(k);
                }

                Console.WriteLine("-----");

                byte j = 0;
                while (j <= 10)
                {
                    Console.WriteLine(j);
                    j++;
                }

                Console.WriteLine("-----");

                // ========================
                // Пример 3 — while с вводом
                // ========================
                bool inWork = true;

                while (inWork)
                {
                    Console.WriteLine("Введи что-нибудь (напиши 'конец' для выхода):");

                    string input = Console.ReadLine();

                    if (input == "конец")
                    {
                        inWork = false;
                    }
                }

                Console.WriteLine("-----");

                // ========================
                // Пример 4 — do...while
                // ========================
                int x = 0;

                do
                {
                    Console.WriteLine(x);
                    x++;
                }
                while (x < 5);

                Console.WriteLine("-----");

                // ========================
                // Пример 5 — проверка ввода
                // ========================
                int number;

                do
                {
                    Console.WriteLine("Введи число больше 0:");
                    number = Convert.ToInt32(Console.ReadLine());

                } while (number <= 0);

                Console.WriteLine("Ок, число принято");
        }
    }

}
    

