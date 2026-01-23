using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}!");

        DayOfWeek currentDay = DateTime.Now.DayOfWeek;
        Console.WriteLine($"Текущий день недели: {currentDay}");
    }
}