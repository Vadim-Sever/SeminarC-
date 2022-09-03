Console.Clear();

Console.WriteLine("Input length strings");
int strings = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input length rows");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[strings, rows];

FillArray(array);
PrintArray(array);

ChangeArray(array);
Console.WriteLine();
PrintArray(array);

ChangeArray2(array);
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

void ChangeArray(int[,] InputArray) {
    int prom = 0;
    for (int j = 0; j < InputArray.GetLength(1); j++)
    {
        prom = InputArray[0,j];
        InputArray[0,j] = InputArray[InputArray.GetUpperBound(0),j];
        InputArray[InputArray.GetUpperBound(0),j] = prom;
    }
}

void ChangeArray2(int[,] InputArray) {
    int prom = 0;
   if(InputArray.GetLength(0) == InputArray.GetLength(1)) {
                 for (int j = 0; j < InputArray.GetLength(1); j++)
    {
        for (int i = 0; i <= j; i++)
        {
            
                prom = InputArray[i,j];
                InputArray[i,j] = InputArray[j,i];
                InputArray[j, i] = prom;
            } 
            
        }
    } else {
                Console.WriteLine("Массив не квадратный");
                }
}

