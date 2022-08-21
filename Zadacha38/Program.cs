Console.Clear();

// void FillArray(int[] InputArray) {
//     int length = InputArray.Length;

//     for (int i = 0; i < length; i++)
//     {
//         InputArray[i] = new Random().Next(1,100);
//     }
// }

int MaxArray(int[] InputArray) {
    int length = InputArray.Length;
    int max = InputArray[0];
    for (int i = 0; i < length; i++)
    {
        if(InputArray[i] > max) {
            max = InputArray[i];
        }
    }
    return max;
}

int MinArray(int[] InputArray) {
    int length = InputArray.Length;
    int min = InputArray[0];
    for (int i = 0; i < length; i++)
    {
        if(InputArray[i] < min) {
            min = InputArray[i];
        }
    }
    return min;
}

void PrintArray(int[] InputArray) {
    int length = InputArray.Length;
    int summ = 0;
    for (int i = 0; i < length; i++)
    {
        if(InputArray[i] % 2 != 0) {
            summ = summ + InputArray[i];
        }
    Console.Write($" {InputArray[i]} ");
    }
}

int[] array = {3,7,22,2,78};

int max = MaxArray(array);
int min = MinArray(array);

PrintArray(array);
Console.Write($"\n Разниа между Макс и Мин элементами массива = {max - min}");


