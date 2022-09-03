// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();

Console.WriteLine("Input length strings");
int strings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input length rows");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[strings, rows];

FillArray(array);
PrintArray(array);

int[] arraysum = MaxSumStrokArray(array);
int minindex = FindMinSum(arraysum);
Console.WriteLine($"Минимальная сумма элементов в строке № = {minindex}");



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

int[] MaxSumStrokArray(int[,] InputArray) {
int[] sum = new int[InputArray.GetLength(0)];

for (int i = 0; i < InputArray.GetLength(0); i++)
{
    for (int j = 0; j < InputArray.GetLength(1); j++)
    {
        sum[i] = InputArray[i,j] + sum[i];
    }
    Console.WriteLine($"Строка = {i} с суммой = {sum[i]}");
}
return sum;
}

int FindMinSum(int[] InputArray) {
    int min = InputArray[0];
    int minindex = 0;
    for (int i = 1; i < InputArray.Length; i++)
    {
        if(InputArray[i]<min) {
            min = InputArray[i];
            minindex = i;
        }
    }
    return minindex;
}
