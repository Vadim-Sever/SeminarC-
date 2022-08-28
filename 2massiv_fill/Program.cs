Console.WriteLine("Введите размер строк массива");
int columns = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите размер столбцов массива");
int rows = int.Parse(Console.ReadLine() ?? "");


int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
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

