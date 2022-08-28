Console.Clear();

int[] array = GetNumberUser("Введите число", "Ошибка ввода");
Console.WriteLine($"{String.Join(" ", array)}");


bool result = Istriangle(array);
if (result) Console.WriteLine("Треугольник может существовать");
else ConsoleWriteLine("Треугольник не может существовать");


// метод заполнения элементов массива и проверки его корректности
int[] GetNumberUser(string message, string errorMessage)
{
    int[] array = new int[3];

    for (int i = 0; i < 3; i++)
    {
        while (true)
        {
            Console.Write(message);
            bool isCorrect = int.TryParse(Console.ReadLine(), out int UserNumber);
            if (isCorrect)
            {
                array[i] = UserNumber;
                break;
            }
            else Console.WriteLine(errorMessage);
        }
    }
    return array;
}


// меод проверки возможности существования треугольника на основе сравнения длинн его сторон
bool Istriangle(int[] array)
{
    bool result;
    if ((array[0] < array[1] + array[2]) && (array[1] < array[0] + array[2]) && (array[2] < array[1] + array[0]))
    {
        result = true;
    }
    return result;
}