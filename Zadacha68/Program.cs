// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();

Console.WriteLine("Input M");
int M = Convert.ToInt32(Console.ReadLine()); ;
Console.WriteLine("Input N");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
int res = Akkerman(M, N);
Console.WriteLine(res);

int Akkerman(int start, int finish)
{
    int akker = 0;
    if (start == 0)
    {
        akker = finish + 1;
    }
    else if (finish == 0 && start != 0)
    {
        akker = Akkerman(start - 1, 1);
    }
    else if (finish > 0 && start > 0)
    {
        akker = Akkerman(start - 1, Akkerman(start, finish - 1));
    }
    return akker;
}
