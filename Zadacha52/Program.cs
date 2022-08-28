Console.Clear();

int[,] array = new int[3, 4];
double summ = 0;

FillArray(array);
PrintArray(array);
Console.WriteLine();
Srednee(array);

int[,] FillArray(int[,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            InputArray[i, j] = new Random().Next(0, 9);
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


void Srednee(int[,] InputArray)
{

    for (int i = 0; i < InputArray.GetLength(1); i++)
    {
        summ = 0;
        for (int j = 0; j < InputArray.GetLength(0); j++)
        {
            // Console.Write(InputArray[j, i]); //вывод матрицы
            summ = InputArray[j, i] + summ;
        }
        Console.WriteLine();
        Console.WriteLine($"Среднее арифметическое элементов массива в столбце {i + 1} = {Math.Round(summ / InputArray.GetLength(0), 1)}");

    }
}


