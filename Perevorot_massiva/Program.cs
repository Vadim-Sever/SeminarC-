Console.Clear();

int[] array = GetArray(10, 0, 10); //создает массим в 10 элементов, каждый из которого будет содержать значения от 0 до 10
Console.WriteLine(String.Join(" ", array)); // метод формирует единую строку из элементов массива -2о1 параметр, 1ый параметр это как разделять элементы массива

int[] reversArray = ReversArray1(array);  // Изменяет порядок элементов во всем одномерном массиве Array на обратный  методом копирования в новый массив
Console.WriteLine(String.Join(" ", reversArray));

ReversArray2(array); // Изменяет порядок элементов во всем одномерном массиве Array на обратный  методом копирования через промежуточную переменную
Console.WriteLine(String.Join(" ", array));

Array.Reverse(array); // использование встроенного метода для переворота массива
Console.WriteLine(String.Join(" ", array));

// метод создает массив заданного размера и заполняет массив случайными числами из диапазона
int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

// метод переписывает в обратном порядке элементы массива в новый массив
int[] ReversArray1(int[] InputArray)
{
    int[] result = new int[InputArray.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = InputArray[InputArray.Length - 1 - i];
    }
    return result;
}

// метод меняет элементы массива через временную переменную
int[] ReversArray2(int[] InputArray)
{
    for (int i = 0; i < InputArray.Length / 2; i++)
    {
        int k = InputArray[i];
        InputArray[i] = InputArray[InputArray.Length - 1 - i];
        InputArray[InputArray.Length - 1 - i] = k;
    }
    return InputArray;
}
