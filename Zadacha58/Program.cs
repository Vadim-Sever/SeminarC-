// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.WriteLine("Input length strings");
int strings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input length rows");
int rows = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[,] { { 2, 4 }, { 3, 2 } };
// int[,] array2 = new int[,] { { 3, 4 }, { 3, 3 } };
int[,] array = new int[strings, rows];
int[,] array2 = new int[strings, rows];


FillArray(array);
FillArray(array2);

PrintArray(array, array2);
Console.WriteLine();
int[,] array3 = CompositionArray(array, array2);
PrintArrayCompositon(array3);




void FillArray(int[,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            InputArray[i, j] = new Random().Next(0, 99);
        }
    }
}

void PrintArray(int[,] InputArray, int[,] InputArray2)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            Console.Write($"{InputArray[i, j]}\t");
        }
        Console.Write($"| \t");
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            Console.Write($"{InputArray2[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArrayCompositon(int[,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            Console.Write($"{InputArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] CompositionArray(int[,] InputArray, int[,] InputArray2)
{
    int[,] comparray = new int[InputArray.GetLength(0), InputArray2.GetLength(1)];
    if (InputArray.GetLength(0) == InputArray2.GetLength(1))
    {
        for (int i = 0; i < InputArray.GetLength(0); i++)
        {
            for (int j = 0; j < InputArray2.GetLength(1); j++)
            {
                for (var k = 0; k < InputArray2.GetLength(0); k++)
                {
                    comparray[i, j] += InputArray[i, k] * InputArray2[k, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Матриы умножать нельзя, т.к они не равны");
    }
    return comparray;
}

