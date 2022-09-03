// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();

Console.WriteLine("Input length strings");
int strings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input length rows");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[strings, rows];

FillArray(array);
PrintArray(array);

SortArray(array);
Console.WriteLine();
PrintArray(array);

void FillArray(int[,] InputArray) {
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            InputArray[i,j] = new Random().Next(0, 99);
        }
    }
}

void PrintArray(int[,] InputArray) {
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            Console.Write($"{InputArray[i,j]}\t");
        }
    Console.WriteLine();
    }
}

void SortArray(int[,] InputArray) {
int max = 0;
int min = 0;
for (int i = 0; i < InputArray.GetLength(0); i++)
{
    for (int j = 0; j < InputArray.GetLength(1); j++)
    {
        for (int k = InputArray.GetLowerBound(0); k < InputArray.GetUpperBound(0); k++) // идем со 2го элемента в строке
        {
            if(InputArray[i,k] < InputArray[i,k + 1]){
                max = InputArray[i,k + 1];
                min = InputArray[i,k];
                InputArray[i,k] = InputArray[i,k + 1];
                InputArray[i,k + 1] = min;
                Console.WriteLine($"i = {i}; j = {j}; k = {k}; min={min} / max = {max}" );
        }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
}

