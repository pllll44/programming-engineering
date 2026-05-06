using System;


// 1. БАЗОВЫЙ КЛАСС

class Person
{
    public string Name = "Undefined";
    public int Age;

    public void Print()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }
}


// 2. КОНСТРУКТОР

class Container
{
    private int _capacity;

    public Container(int capacity)
    {
        _capacity = capacity;
    }

    public void Show()
    {
        Console.WriteLine($"Capacity: {_capacity}");
    }
}


// 3. НАСЛЕДОВАНИЕ

class Employee
{
    public string Name { get; set; }

    public void Work()
    {
        Console.WriteLine("Working...");
    }
}

class Manager : Employee
{
    public void Manage()
    {
        Console.WriteLine("Managing...");
    }
}


// 4. АБСТРАКТНЫЙ КЛАСС

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}


// 5. SEALED КЛАСС

sealed class FinalClass
{
    public void Show()
    {
        Console.WriteLine("я класс который нельзя наследовать");

    }
}


// MAIN

class HelloWorld
{
    static void Main()
    {
        //Пример 1: Person 
        Console.WriteLine("=== Person ===");

        Person tom = new Person();
        tom.Name = "Tom";
        tom.Age = 37;
        tom.Print();

        //Пример 2: Container
        Console.WriteLine("\n=== Container ===");

        Container c = new Container(10);
        c.Show();

        //Пример 3: наследование
        Console.WriteLine("\n=== Inheritance ===");

        Manager m = new Manager();
        m.Name = "Alice";
        m.Work();
        m.Manage();

        //Пример 4: abstract
        Console.WriteLine("\n=== Abstract ===");

        Circle circle = new Circle();
        circle.Radius = 5;

        Console.WriteLine(circle.GetArea());

        //Пример 5: sealed 
        Console.WriteLine("\n=== Sealed ===");

        FinalClass f = new FinalClass();
        f.Show();
    }
}