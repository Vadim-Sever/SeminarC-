// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки ячейки");
int columns = Convert.ToInt32(Console.ReadLine() ?? "");

Console.WriteLine("Введите номер столбца ячейки");
int rows = Convert.ToInt32(Console.ReadLine() ?? "");


int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FindArray(array, rows, columns);

int[,] FillArray(int[,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            InputArray[i, j] = new Random().Next(0, 99);
        }
    }
    return InputArray;
}

void PrintArray(int[,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            Console.Write($"{InputArray[i, j]}  /");
        }
        Console.WriteLine();
    }
}

void FindArray(int[,] InputArray, int rows, int columns)
{
    if (rows > InputArray.GetLength(0) || columns > InputArray.GetLength(1)) Console.WriteLine("такого числа в массиве нет");
    else if (rows == 0 && columns == 0) Console.WriteLine("такого числа в массиве нет");
    else Console.WriteLine($"Элемент расположенный в заданной ячейке = {InputArray[rows - 1, columns - 1]}");
}

