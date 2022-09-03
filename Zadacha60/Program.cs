// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

Console.WriteLine("Input length X");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input length Y");
int Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input length Z");
int Z = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[X, Y, Z];

FillArray(array);
PrintArray(array);
Console.WriteLine();

void FillArray(int[,,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            for (var k = 0; k < InputArray.GetLength(2); k++)
            {
                InputArray[i, j, k] = new Random(((int)DateTime.Now.Ticks * new Random().Next(0, 99))).Next(0, 99);
            }
        }
    }
}


void PrintArray(int[,,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            for (var k = 0; k < InputArray.GetLength(2); k++)
            {
                Console.Write($"{InputArray[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}


