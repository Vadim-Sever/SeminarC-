Console.Clear();

void FillArray(int[] InputArray) {
    int length = InputArray.Length;

    for (int i = 0; i < length; i++)
    {
        InputArray[i] = new Random().Next(10, 100) * 10;        
    }
}

void PrintArray(int[] InputArray) {
    int length = InputArray.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if(InputArray[i] % 2 == 0) {
            count = count + 1;
        } 
        
        Console.Write($" {InputArray[i]} ");
    }
   
    Console.WriteLine($"\n Количество четных элементов массива = {count}");
}

int[] array = new int[4];
FillArray(array);
PrintArray(array);