// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Решаем через задаваемый пользователем размер массива, это позволяет делать ввод через ентер

Console.Clear();

Console.Write("Укажите серди какого количества ифр Вы будете проводить поиск:");
int dlina = Convert.ToInt32(Console.ReadLine());

int[] array = new int[dlina];

void FillArray(int[] InputArray) {
    int length = InputArray.Length;
    for (int i = 0; i < length; i++)
    {
        InputArray[i] = Convert.ToInt32(Console.ReadLine());
    }
}

// функия првоерки содержания массива на соответствие заданному условию
int ResCount(int[] InputArray) {
    int length = InputArray.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if(InputArray[i] > 0) {
            count = count + 1;
        }
    }
return count;
}

// запускаем функию заполнения массива
FillArray(array);

int res = ResCount(array);
Console.Write($"Количество цифр, которые > 0 из всех введенных =  {res}");
