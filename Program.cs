﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2        1, -7, 567, 89, 223-> 3
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите числа (не более 10 чисел) через запятую: ");
        string numbers = Console.ReadLine();
        Console.Write("[");
        
        string[] newNumbers = new string[numbers.Length];
        int k = 0;
        for (int i = 0; i < newNumbers.Length; i++)
        {
            if (numbers[i] == ',')
            {
                k++;
            }
            else
            {
                newNumbers[k] = newNumbers[k] + $"{numbers[i]}";
            }
        }
        k++;
        int[] resultNumbers = new int[k];
        PrintArray(resultNumbers, newNumbers);
        int sum = 0;
        for (int i = 0; i < k; i++)
        {
            if (resultNumbers[i] > 0)
            {
                sum++;
            }
        }
        Console.WriteLine("Количество чисел больше 0: " + sum);

        void PrintArray(int[] array, string[] string1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(string1[i]);
                Console.Write(array[i] + "  ");
            }
            Console.Write("]");

            Console.WriteLine();
        }
    }
}
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите значение b1");
        double b1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите число k1");
        double k1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите значение b2");
        double b2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите число k2");
        double k2 = Convert.ToInt32(Console.ReadLine());

         if (k1 == k2)
        {
            Console.WriteLine("Прямые с такими параметрами паралельны");
        }
        else
        {
        double x = (-b2 + b1) / (-k1 + k2);
        double y = k2 * x + b2;
    
        Console.WriteLine($"Прямые пересекутся в точке А с координатами: ({x}; {y})");
        }
    }
}    
*/

