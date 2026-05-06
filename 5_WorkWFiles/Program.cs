using System;

class HelloWorld
{
    static void Main()
    {
        // 1. СОЗДАНИЕ СТРОК
        Console.WriteLine(" Создание строк ");

        string s1 = "Обычный текст";
        string s2 = null;
        string s3 = string.Empty;
        string s4 = "Текст\nс переносом";
        string s5 = @"Дословный текст\nбез экранирования";
        string s6 = new string(new char[] { 'A', 'B' });

        const string s7 = "константа";

        Console.WriteLine(s1);
        Console.WriteLine(s6);

        // 2. ОБЪЕДИНЕНИЕ СТРОК
        Console.WriteLine("\n Объединение ");

        string hello = "Hello";
        string world = "world";
        string result = hello + " " + world;

        Console.WriteLine(result);

        // 3. ЭСКЕЙПЫ
        Console.WriteLine("\n Escape ");

        string withNewLine = "First\nSecond";
        string withTab = "A\tB";
        string withSlash = "C:\\Windows";

        Console.WriteLine(withNewLine);
        Console.WriteLine(withTab);
        Console.WriteLine(withSlash);

        // 4. ИНДЕКСЫ
        Console.WriteLine("\n Индексы ");

        string text = "Hello";
        Console.WriteLine(text[0]);

        // 5. МЕТОДЫ СТРОК
        Console.WriteLine("\n=== Методы ===");

        Console.WriteLine("Hello".Length);
        Console.WriteLine("apple".CompareTo("banana"));

        Console.WriteLine(string.Concat("Hello", " ", "World"));
        Console.WriteLine("file.txt".EndsWith(".txt"));

        char[] arr = "ABC".ToCharArray();

        string rem = "Hello world".Remove(5, 1);
        Console.WriteLine(rem);
        string rep = "I like cats".Replace("cats", "dogs");
        Console.WriteLine(rep);
        string sub = "The quick fox".Substring(4, 5);
        Console.WriteLine(sub);
        string txt = "C# is fun";
        Console.WriteLine(txt.IndexOf("is"));

        string pad = "42";
        Console.WriteLine(pad.PadLeft(5, '*'));

        string messy = "  hello  ";
        Console.WriteLine(messy.Trim());

        Console.WriteLine("Hello".ToLower());
        Console.WriteLine("Hello".ToUpper());

        Console.WriteLine("Hello world".Insert(5, ","));

        bool eq = string.Equals("hello", "HELLO", StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(eq);

        // 6. СРАВНЕНИЕ
        Console.WriteLine("\n CompareTo ");

        Console.WriteLine(5.CompareTo(3));
        Console.WriteLine("abc".CompareTo("abd"));

        // 7. ЗАДАНИЯ
        Console.WriteLine("\n Задание 1: swap ");
        string a = "one";
        string b = "two";

        string temp = a;
        a = b;
        b = temp;

        Console.WriteLine(a);
        Console.WriteLine(b);

        Console.WriteLine("\n Задание 2: ignore case ");
        string str1 = "Hello";
        string str2 = "hello";

        bool equal = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(equal);

        Console.WriteLine("\n Задание 3: insert word ");
        string sentence = "Hello world";
        string word = "big";

        int space = sentence.IndexOf(' ');
        if (space != -1)
            sentence = sentence.Insert(space + 1, word + " ");

        Console.WriteLine(sentence);

        Console.WriteLine("\n Задание 4: replace brackets ");
        string phrase = "Hello (old text)";
        string newText = "NEW";

        int open = phrase.IndexOf('('); 
        int close = phrase.IndexOf(')'); 

        if (open != -1 && close != -1)
        {
            string withoutOld = phrase.Remove(open + 1, close - open - 1);
            string final = withoutOld.Insert(open + 1, newText);
            Console.WriteLine(final);
        }

        Console.WriteLine("\nЗадание 5: formatting");

        const int width = 8;
        string[] lines = { "one", "two", "three", "four", "five", "six", "seven" };

        foreach (var line in lines)
        {
            string cut = line.Length > width ? line.Substring(0, width) : line;

            Console.WriteLine(cut.PadLeft(width));
            Console.WriteLine(cut.PadRight(width,'*'));
        }
    }
}