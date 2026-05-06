using System;
using System.Linq;
using System.Collections.Generic;

// Класс для примера
class Person
{
    public string Name { get; }
    public Person(string name) => Name = name;
}

class HelloWorld
{
    static void Main()
    {
        Example1();
        Example2();
        Example3();
        Example4();
        Example5();
        Example6();
        Example7();
        Example8();
    }

    // Пример 1: создание и перебор
    static void Example1()
    {
        Console.WriteLine("=== Пример 1 ===");

        List<string> people = new List<string>() { "Tom", "Bob", "Sam" };

        Console.WriteLine(people[0]); // Tom
        people[0] = "Mike";

        Console.WriteLine(people.Count);

        foreach (var person in people)
            Console.WriteLine(person);

        for (int i = 0; i < people.Count; i++)
            Console.WriteLine(people[i]);
    }

    // Пример 2: добавление
    static void Example2()
    {
        Console.WriteLine("=== Пример 2 ===");

        List<string> people = new List<string>() { "Tom" };

        people.Add("Bob");
        people.AddRange(new[] { "Sam", "Alice" });
        people.Insert(0, "Eugene");
        people.InsertRange(1, new string[] { "Mike", "Kate" });

        foreach (var p in people)
            Console.WriteLine(p);
    }

    // Пример 3: удаление
    static void Example3()
    {
        Console.WriteLine("=== Пример 3 ===");

        var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };

        people.RemoveAt(1);
        people.Remove("Tom");
        people.RemoveAll(p => p.Length == 3);
        people.RemoveRange(1, 2);

        foreach (var p in people)
            Console.WriteLine(p);

        people.Clear();
    }

    // Пример 4: поиск
    static void Example4()
    {
        Console.WriteLine("=== Пример 4 ===");

        var people = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam" };

        Console.WriteLine(people.Contains("Bob"));
        Console.WriteLine(people.Exists(p => p.Length == 3));

        Console.WriteLine(people.Find(p => p.Length == 3));
        Console.WriteLine(people.FindLast(p => p.Length == 3));

        var result = people.FindAll(p => p.Length == 3);

        foreach (var p in result)
            Console.WriteLine(p);
    }

    // Пример 5: диапазон и копирование
    static void Example5()
    {
        Console.WriteLine("=== Пример 5 ===");

        List<string> people = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };

        var range = people.GetRange(1, 3);

        foreach (var p in range)
            Console.WriteLine(p);

        string[] arr = new string[3];
        people.CopyTo(0, arr, 0, 3);
    }

    // Пример 6: Reverse
    static void Example6()
    {
        Console.WriteLine("=== Пример 6 ===");

        var people = new List<string>() { "Eugene", "Tom", "Mike", "Sam", "Bob" };

        people.Reverse();

        foreach (var p in people)
            Console.WriteLine(p);

        people.Reverse(1, 3);
    }

    // Пример 7: LinkedList
    static void Example7()
    {
        Console.WriteLine("=== Пример 7 ===");

        var list = new List<string> { "Tom", "Sam", "Bob" };
        LinkedList<string> people = new LinkedList<string>(list);

        Console.WriteLine(people.Count);
        Console.WriteLine(people.First.Value);
        Console.WriteLine(people.Last.Value);

        var node = people.First;
        while (node != null)
        {
            Console.WriteLine(node.Value);
            node = node.Next;
        }

        node = people.Last;
        while (node != null)
        {
            Console.WriteLine(node.Value);
            node = node.Previous;
        }
    }

    // Пример 8: методы LinkedList
    static void Example8()
    {
        Console.WriteLine("=== Пример 8 ===");

        var people = new LinkedList<string>();

        people.AddLast("Tom");
        people.AddFirst("Bob");

        if (people.First != null)
            people.AddAfter(people.First, "Mike");

        foreach (var p in people)
            Console.WriteLine(p);

        var company = new LinkedList<Person>();

        company.AddLast(new Person("Tom"));
        company.AddLast(new Person("Sam"));
        company.AddFirst(new Person("Bill"));

        foreach (var p in company)
            Console.WriteLine(p.Name);
    }
}