using System;
using System.Collections.Generic;
class HelloWorld
{
    //Методы для примера 3
    static Array myReturn()
    {
        string[] Info = { "Name", "Family", "Adress" };
        return Info;
    }

    // Передача массива в метод, сортировка и возврат одного элемента
    static int mySort(Array sortArray, int i)
    {
        Array.Sort(sortArray);
        return (int)sortArray.GetValue(i);
    }

    // Метод для примера 4 
    static int SumArraySegments(ArraySegment<int>[] value)
    {
        int sum = 0;
        foreach (var s in value)
            for (int i = s.Offset; i < s.Offset + s.Count; i++)
                sum += s.Array[i];
        return sum;
    }

    static void Main()
    {
        // Двумерный: запятая между измерениями
        int[,] matrix = new int[3, 4];       // 3 строки, 4 столбца

        // Трёхмерный
        int[,,] cube = new int[2, 3, 4];    // 2*3*4 = 24 элемента
                                            //Инициализация многомерного массива    
        int[,] myArt = new int[4, 5]
        {
            { 13, 10, 3, 7, 11 },
            { 7, 12, 11, 11, 8 },
            { 13, 6, 12, 13, 2 },
            { 13, 5, 11, 6, 2 }
        };

        // Ступенчатый массив: 3 строки, строки разной длины
        int[][] jagged = new int[3][];
        jagged[0] = new int[] { 1, 2 };
        jagged[1] = new int[] { 3, 4, 5 };
        jagged[2] = new int[] { 6 };

        //Пример 1 Работа с интерфейсами IList<T> b IReadOnlyList<T>


        string[] sa = new string[5];
        object[] oa1 = new object[5];
        object[] oa2 = sa;                     // допустимо (ковариантность)

        IList<string> lst1 = sa;               // OK
        IList<string> lst2 = oa1;              // Ошибка, нужно явное приведение
        IList<object> lst3 = sa;               // OK
        IList<object> lst4 = oa1;              // OK

        IList<string> lst5 = (IList<string>)oa1;   // Исключение (oa1 - не string[])
        IList<string> lst6 = (IList<string>)oa2;   // OK

        IReadOnlyList<string> lst7 = sa;       // OK
        IReadOnlyList<string> lst8 = oa1;      // Ошибка, нужно приведение
        IReadOnlyList<object> lst9 = sa;       // OK
        IReadOnlyList<object> lst10 = oa1;     // OK

        IReadOnlyList<string> lst11 = (IReadOnlyList<string>)oa1; // Исключение
        IReadOnlyList<string> lst12 = (IReadOnlyList<string>)oa2; // OK

        //Пример 2 Создание массива через Array.CreateInstance, мутожы SetValue, Clone, Copy

        string[] arr2 = new string[5];

        // Создаём массив типа string длиной 5
        Array myArr = Array.CreateInstance(typeof(string), 5);

        // Заполняем первые три элемента
        myArr.SetValue("Name", 0);
        myArr.SetValue("Age", 1);
        myArr.SetValue("Adress", 2);

        // Клонирование
        //string[] arr1 = (string[])myArr.Clone();
        //foreach (string s in arr1)
        //    Console.Write("\t" + s);

        // Копирование в другой массив
        Console.WriteLine();
        Array.Copy(myArr, arr2, myArr.Length);
        foreach (string s in arr2)
            Console.Write("\t" + s);

        Console.ReadLine();

        // Пример 3 Возхврат массива из метода и передача массива в метод, сортировка

        // Возврат массива методом myReturn()
        foreach (string s in myReturn())
            Console.WriteLine(s);

        // Сортировка
        int[] mySortArray = { 4, 1, 2, 5, 3 };
        for (int i = 0; i <= 4; i++)
            mySortArray[i] = mySort(mySortArray, i);

        Console.WriteLine("\nОтсортированный массив:\n");
        foreach (int i in mySortArray)
            Console.Write("\t" + i);

        Console.ReadLine();

        //Пример 4 использование ArraySegment<T>

        int[] arr1 = { 1, 2, 3, 4, 5, 6 };
        int[] arr2 = { 7, 8, 9, 10 };

        var mySegmentsArray = new ArraySegment<int>[3]
        {
            new ArraySegment<int>(arr1, 0, 2),   // элементы arr1[0],arr1[1]
            new ArraySegment<int>(arr2, 0, 1),   // arr2[0]
            new ArraySegment<int>(arr1, 1, 2)    // arr1[1],arr1[2]
        };

        Console.WriteLine("Сумма выбранных значений равна:\n" + SumArraySegments(mySegmentsArray));
        Console.ReadLine();



    }
}