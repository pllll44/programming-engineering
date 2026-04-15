namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Теоретическая часть Лаборатороной работы №2 
            //(для быстрой проверки работы отработанных кодов теоретической части можно сочетанием клавиш (ctrl + k,ctrl + u)
            //int   a = 7
            //    , b = 4
            //    , c = 3
            //    , d
            //    , e;
            //d = (a + b) / c;
            //e = (a + b) % c;
            //Console.WriteLine($"целое: {d}"); $ - Интерполяция, которая позволяет внедрять переменныйе прямо в строку
            //Console.WriteLine($"остаток: {e}");
            //Console.ReadLine();


            //int max = int.MaxValue;
            //int min = int.MinValue;
            //Console.WriteLine($"Максимальное значение Integer = {max}\nМинимальное значение Integer = {min}");
            //Console.ReadLine();

            //double a = 19, b = 23,c = 8, d = (a+b)/c;
            //Console.WriteLine($"{d}");
            //Console.ReadLine();


            //double max = double.MaxValue, min = double.MinValue;
            //Console.WriteLine($"{max}\n{min}");
            //Console.ReadLine();

            //double third = 1.0 / 3.0;
            //Console.WriteLine($"{third}");
            //Console.ReadLine();

            //             *Задача №1*
            //            Выполните другие вычисления с большими числами, малыми числами, умножением и
            //            делением с помощью типа double.Попробуйте выполнить более сложные вычисления
            Console.WriteLine("Задача №1\n");
            int a = 783478
                , b = 4626364
                , c = 3382834
                , d
                , e
                , f = 342873287
                ;
            d = (a + b) / c * f;
            e = (a + b) % c*f;
            Console.WriteLine($"Целое: {d}"); 
            Console.WriteLine($"Остаток: {e}");
            Console.WriteLine("Double:\n");
            double g = 20
               , h = 60
               , j = 9
               , k
               ,l
               , o = 7
               ;
            k = ((g + h )*h) / (j * o + (j + o) / g * h);
            l = (g + h) % (j * o + ((c + f) % g) * h);
            Console.WriteLine($"первое сложное вычисление с плавающей точкой: {k}");
            Console.WriteLine($"Второе: {l}");
            Console.ReadLine();
            // Данные вычления считаются не до конца правильными потому как являются не совсем точными из за сложности вычисления

            //decimal min = decimal.MinValue;
            //decimal max = decimal.MaxValue;
            //Console.WriteLine($"Max:{max}\nMin:{min}");
            //Console.ReadLine();

            //double ab = 0.1, ba = 0.3;
            //Console.WriteLine(ab / ba);
            //Console.ReadLine() ;


            //decimal abb = 0.1M, baa = 0.3M;
            //Console.WriteLine(abb / baa);
            //Console.ReadLine();


            //             *Задача №2*
            //            Теперь, когда вы ознакомились с разными числовыми типами, напишите код, который
            //              позволяет вычислить площадь круга с радиусом 2,50 см.Помните, что площадь круга равна
            //              квадрату радиуса, умноженному на число пи.Подсказка: в.NET есть константа пи Math.PI,
            //              которую можно использовать.Math.PI, как и все константы, объявленные в пространстве
            //              имен System.Math, — это значение double.По этой причине вместо значений decimal для
            //              этой задачи следует использовать double.
            //              Вы должны получить ответ от 19 до 20
            //              Решение:

            double radius = 0;
            Console.WriteLine("Задача №2\n");
            Console.Write("Введи радиус круга через запятую: ");
            while  (true)
                {
                try
                {
                    radius = Convert.ToDouble(Console.ReadLine()); break;
                }
                
                catch
                {
                    Console.WriteLine("При вводе десятичных чисел используйте запятую");
                    Console.Write("Введи радиус круга через запятую: ");

                }
                
            }
            // формула площади круга s = radius * radius *math.p 
            double s = 0;
            s = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine($"площадь круга ровна: {s}");
            Console.ReadLine();

        }


    }
}
