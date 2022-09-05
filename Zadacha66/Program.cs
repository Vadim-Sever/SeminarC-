// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Input M");
int M = Convert.ToInt32(Console.ReadLine()); ;
Console.WriteLine("Input N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int res = PrintSum(M, N, 0);
Console.WriteLine(res);

int PrintSum(int start, int finish, int sum)
{
    for (var i = start; i <= finish; i++)
    {
        PrintSum(start + 1, finish, sum = i + sum);
    }
    return sum;
}
