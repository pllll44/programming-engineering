using System;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("=== Лабораторная работа 6.1: DateTime ===");


        // 1. Создание DateTime 
        DateTime dt1 = new DateTime(); // 01.01.0001 00:00:00
        DateTime dt2 = new DateTime(2015, 7, 20);
        DateTime dt3 = new DateTime(2015, 7, 20, 18, 30, 25);

        Console.WriteLine("\n--- DateTime создание ---");
        Console.WriteLine(dt1);
        Console.WriteLine(dt2);
        Console.WriteLine(dt3);


        // 2. Текущее время
        Console.WriteLine("\n--- Текущее время ---");
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.UtcNow);
        Console.WriteLine(DateTime.Today);

        // 3. День недели
        DateTime someDate = new DateTime(1582, 10, 5);
        Console.WriteLine("\n--- День недели ---");
        Console.WriteLine(someDate.DayOfWeek);

        // 4. Стандартные форматы
        DateTime now = DateTime.Now;

        Console.WriteLine("\n--- Стандартные форматы ---");
        Console.WriteLine($"D: {now:D}");
        Console.WriteLine($"d: {now:d}");
        Console.WriteLine($"F: {now:F}");
        Console.WriteLine($"f: {now:f}");
        Console.WriteLine($"G: {now:G}");
        Console.WriteLine($"g: {now:g}");
        Console.WriteLine($"M: {now:M}");
        Console.WriteLine($"O: {now:O}");
        Console.WriteLine($"o: {now:o}");
        Console.WriteLine($"R: {now:R}");
        Console.WriteLine($"s: {now:s}");
        Console.WriteLine($"T: {now:T}");
        Console.WriteLine($"t: {now:t}");
        Console.WriteLine($"U: {now:U}");
        Console.WriteLine($"u: {now:u}");
        Console.WriteLine($"Y: {now:Y}");

        // 5. Пользовательские форматы
        Console.WriteLine("\n--- Пользовательские форматы ---");
        Console.WriteLine(now.ToString("hh:mm:ss"));
        Console.WriteLine(now.ToString("dd.MM.yyyy"));
        Console.WriteLine(now.ToString("dddd, MMMM yyyy"));
        Console.WriteLine(now.ToString("HH:mm:ss dd.MM.yyyy"));
        Console.WriteLine(now.ToString("yyyy-MM-ddTHH:mm:ss.fff"));

        // 6. "DateOnly аналог" через DateTime
        Console.WriteLine("\n--- Работа только с датой ---");

        DateTime dateOnly = new DateTime(2022, 1, 6);

        Console.WriteLine(dateOnly);
        Console.WriteLine("Day: " + dateOnly.Day);
        Console.WriteLine("Month: " + dateOnly.Month);
        Console.WriteLine("Year: " + dateOnly.Year);
        Console.WriteLine("DayOfWeek: " + dateOnly.DayOfWeek);
        Console.WriteLine("DayOfYear: " + dateOnly.DayOfYear);

        DateTime datePlus = dateOnly.AddDays(1);
        Console.WriteLine("AddDays +1: " + datePlus);

        // 7. "TimeOnly аналог" через TimeSpan

        Console.WriteLine("\n--- Работа только со временем ---");

        TimeSpan time = new TimeSpan(14, 23, 30);

        Console.WriteLine(time);
        Console.WriteLine("Hours: " + time.Hours);
        Console.WriteLine("Minutes: " + time.Minutes);
        Console.WriteLine("Seconds: " + time.Seconds);

        TimeSpan time2 = TimeSpan.Parse("06:33:22");
        time2 = time2.Add(TimeSpan.FromHours(1));
        time2 = time2.Add(TimeSpan.FromMinutes(-23));

        Console.WriteLine("Short: " + time2);
        Console.WriteLine("Total hours: " + time2.TotalHours);

        // 8. TryParse
        Console.WriteLine("\n--- TryParse ---");

        bool okDate = DateTime.TryParse("2022-01-06", out DateTime parsedDate);
        Console.WriteLine(okDate);
        Console.WriteLine(parsedDate);

        bool okTime = TimeSpan.TryParse("14:23", out TimeSpan parsedTime);
        Console.WriteLine(okTime);
        Console.WriteLine(parsedTime);

        // 9. Итоговое задание
        Console.WriteLine("\n--- Задание ---");

        Console.WriteLine(now.ToString("dd.MM.yyyy HH:mm:ss"));
        Console.WriteLine(now.ToString("yyyy-MM-dd"));
        Console.WriteLine(now.ToString("dddd, d MMMM yyyy 'г.'"));
        Console.WriteLine(now.ToString("HH:mm:ss.fff"));
        Console.WriteLine(now.ToString("h:mm tt"));
    }
}