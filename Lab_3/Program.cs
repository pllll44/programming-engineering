//Лабораторная работа №3 Оператор switch ... case 
// Пример 1

//while (true)
//{
//    short user_input = Convert.ToInt16(Console.ReadLine());
//    if (user_input == 0)
//        break;
//    switch (user_input)
//    {

//        case 5:
//            Console.WriteLine("Номер 5\n");
//            break;
//        case 6:
//            Console.WriteLine("Номер 6\n");
//            break;
//        case 20:
//            Console.WriteLine("Номер 20\n");
//            break;
//        case 40:
//            Console.WriteLine("Номер 40\n");
//            break;
//        case > 20:
//            Console.WriteLine("Номер больше 20\n");
//            break;
//        default:
//            Console.WriteLine("Такого номер нет в базе\n");
//            break;
//    }


//}

//using System;

//public  class Program

//{
//    public static void Main()
//    {
//        DisplayUserInput(-4.2);
//        DisplayUserInput(5.5);
//        DisplayUserInput(30);
//        DisplayUserInput(double.NaN);
//        void DisplayUserInput(double userInput)
//        {
//            switch (userInput)
//            {
//                case < 0.0:
//                    Console.WriteLine($"Значение переменной {userInput}; слишком низкое\n");
//                    break;
//                case > 15.0:
//                    Console.WriteLine($"Значение переменной {userInput}; слишком высокое\n");
//                    break;
//                case double.NaN:
//                    Console.WriteLine("Значение не определено\n");
//                    break;
//                default:
//                    Console.WriteLine($"Значение переменной равно {userInput}\n");
//                    break;
//            }
//        }
//    }
//}
using System;

public class Program

{
    public static void Main()
    {
        ФункцияИзмерения(-4);
        ФункцияИзмерения(50);
        ФункцияИзмерения(133);
        void ФункцияИзмерения(int измерения)
        {
            switch (измерения)
            {
                case < 0:
                case > 100:
                    Console.WriteLine($"Значение измерения меньше 0, либо больше 100 и равно {измерения};\n");
                    break;
                
                default:
                    Console.WriteLine($"Значение измерения равно {измерения}\n");
                    break;
            }
        }
    }
}





