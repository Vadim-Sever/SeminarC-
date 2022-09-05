// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Clear();

Console.WriteLine("Input M");
int M = Convert.ToInt32(Console.ReadLine()); ;
Console.WriteLine("Input N");
int N = Convert.ToInt32(Console.ReadLine());


Console.WriteLine();
if (M < N)
{
    PrintNum(M, N);
}
else
{
    Console.WriteLine("Диапазон введен не корректно");
}

void PrintNum(int start, int finish)
{

    if (start < finish)
    {
        Console.Write(start + ", ");
        PrintNum(start + 1, finish);
    }
    if (start == finish)
    {
        Console.Write(start + " ");
        PrintNum(start + 1, finish);
    }
}