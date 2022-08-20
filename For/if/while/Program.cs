// for (int i = 2; i <= 10; i++) {
//     for (int j = 2; j <= 10; j++)
//     {
//       Console.WriteLine($"{i} x {j} = {i*j}");  
//     }
// }

string text = "Послушайте лекцию в аудиоформате";

string Replace(string text, char oldValue, char newValue) {
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) {
            result = result + $"{newValue}";
        } else {
            result = result + $"{text[i]}";
        }
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

newText = Replace(text, 'о', 'О');
Console.WriteLine(newText);



// новый метод сортировки

int[] arr = {1, 3, 34, 3, 4, 5, 64, 4};

void PrintArray(int[] array) {
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

void SelectionSort(int[] array) {

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
       
       //ищет минимальный элемент
        for (int j = i + 1; j < array.Length; j++)
        {
                if(array[j]<array[minPosition]) minPosition = j;
        }

        // производим swap
        int tempPosition = array[i];
        array[i] = array[minPosition];
        array[minPosition] = tempPosition;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);