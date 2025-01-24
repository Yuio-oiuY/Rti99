using SquareLibrary;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Демонстрация работы с библиотекой SquareLibrary");
        Console.WriteLine("---------------------------------------------\n");

        Console.WriteLine("Введите сторону квадрата:");
        if (double.TryParse(Console.ReadLine(), out double a))
        {
            try
            {
                Square square = new Square(a);
                Square square1 = new Square(a);
                Console.WriteLine($"Сторона квадрата : {square.Side}");
                Console.WriteLine($"Площадь квадрата равна: {square.Area()}");
                Console.WriteLine($"Периметр квадрата равен : {square1.Perimeter()}");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
        }


    }
}