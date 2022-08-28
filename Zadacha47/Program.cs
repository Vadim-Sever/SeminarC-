Console.WriteLine("Введите размер строк массива");
int columns = Convert.ToInt32(Console.ReadLine() ?? "");

Console.WriteLine("Введите размер столбцов массива");
int rows = Convert.ToInt32(Console.ReadLine() ?? "");


double[,] array = GetArray(rows, columns);
PrintArray(array);

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];
    double number;
    int numberint;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numberint = new Random().Next(-10, 10);
            number = new Random().NextDouble();
            result[i, j] = numberint * number;
        }
    }
    return result;
}

void PrintArray(double[,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(InputArray[i, j], 1)}  /");
        }
        Console.WriteLine();
    }
}

