// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

Console.WriteLine("Input length strings");
int strings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input length rows");
int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the starting number: ");
// start = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter step: ");
// step = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[strings, rows];
int[] arrayposledovatelnost = new int[strings * rows];

FillArrayPosledovatelnost(arrayposledovatelnost);
FillArray(array, arrayposledovatelnost);

PrintArray(array);
Console.WriteLine();




void FillArray(int[,] InputArray, int[] InputArrayPosled)
{
    int k = 0;
    // запполняем 1ю строку
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            if (i < 1)
            {
                InputArray[i, j] = InputArrayPosled[k];
                k++;
            }
        }
    }

    // заполняем последний столбе
    for (int i = 1; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            if (j == InputArray.GetLength(1) - 1)
            {
                InputArray[i, j] = InputArrayPosled[k];
                k++;
            }
        }
    }

    // заполняем последнюю строку с конца
    for (int i = InputArray.GetLength(0) - 1; i < InputArray.GetLength(0); i++)
    {
        for (int j = InputArray.GetLength(1) - 2; j >= 0; j--)
        {
            if (i == InputArray.GetLength(0) - 1)
            {
                InputArray[i, j] = InputArrayPosled[k];
                k++;
            }
        }
    }


    // заполняем 1ый столбец с конца с конца
    for (int i = InputArray.GetLength(0) - 2; i >= 1; i--)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            if (j == 0)
            {
                InputArray[i, j] = InputArrayPosled[k];
                k++;
            }
        }
    }

    // заполняем 2ую строку
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 1; j < InputArray.GetLength(1) - 1; j++)
        {
            if (i == 1)
            {
                InputArray[i, j] = InputArrayPosled[k];
                k++;
            }
        }
    }

    // заполняем 3ую строку с кона
    for (int i = InputArray.GetLength(0) - 2; i < InputArray.GetLength(0); i++)
    {
        for (int j = InputArray.GetLength(1) - 2; j >= 1; j--)
        {
            if (i == 2)
            {
                InputArray[i, j] = InputArrayPosled[k];
                k++;
            }
        }
    }
}

void FillArrayPosledovatelnost(int[] InputArray)
{
    for (int i = 0; i < InputArray.Length; i++)
    {
        InputArray[i] = i + 1;
        Console.WriteLine($"{InputArray[i]}");
    }

}

void PrintArray(int[,] InputArray)
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



