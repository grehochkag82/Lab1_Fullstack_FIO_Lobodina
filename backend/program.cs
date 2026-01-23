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

        Console.Write("Хотите продолжить? (y/n): ");
        string answer = Console.ReadLine();
        
        if (answer.ToLower() == "y")
        {
            Console.WriteLine("Программа продолжает работу...");
        }
        else if (answer.ToLower() == "n")
        {
            Console.WriteLine("Программа завершена.");
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }
    }
}