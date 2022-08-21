Console.Clear();

void FillArray (int[] InputArray) {
    int length = InputArray.Length;
    for (int i = 0; i < length; i++)
    {
        InputArray[i] = new Random().Next(1,100);
    }
}

void PrintArray (int[] InputArray) {
    int length = InputArray.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($" {InputArray[i]} ");
    }
}

int[] array = new int[8];

FillArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.Write("\b");