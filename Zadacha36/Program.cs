Console.Clear();

void FillArray(int[] InputArray) {
    int length = InputArray.Length;

    for (int i = 0; i < length; i++)
    {
        InputArray[i] = new Random().Next(-100,100);
    }
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
    Console.WriteLine($"\n Сумма нечетных элементов массива = {summ}");
}

int[] array = new int[4];
FillArray(array);
PrintArray(array);



