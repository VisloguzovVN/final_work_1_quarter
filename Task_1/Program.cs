//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите элементы массива через пробел: ");
        string[] inputArray = Console.ReadLine()!.Split(' ');

        string[] resultArray = FilterArrayByLength(inputArray);

        Console.WriteLine("Результирующий массив:");
        foreach (string element in resultArray)
        {
            Console.Write($"{element} ");
        }
    }

    static string[] FilterArrayByLength(string[] inputArray)
    {
        int count = 0;

        foreach (string element in inputArray)
        {
            if (element.Length <= 3)
            {
                count++;
            }
        }

        string[] resultArray = new string[count];
        
        int index = 0;
        foreach (string element in inputArray)
        {
            if (element.Length <= 3)
            {
                resultArray[index] = element;
                index++;
            }
        }

        return resultArray;
    }
}

