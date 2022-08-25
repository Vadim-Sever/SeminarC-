// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// вариант решения через построчный ввод любого количества цифр

Console.Clear();

// ввод
Console.WriteLine("Введите любое количество положительных и отриательных цифр в одну строку и узнаете сколько среди них > 0");
string? text = Console.ReadLine();

int dlina = text.Length;


// функия заполнения массива с предварительной проверкой преобразуется ли строка корректно в цифры
void FillArray(int[] InputArray, string text) {
    int length = InputArray.Length;
        for (int i = 0; i < length; i++) {
            
            if((int)Char.GetNumericValue(text[i]) > 0 && i == 0)
            {
                    InputArray[i] = (int)Char.GetNumericValue(text[i]);
                    Console.WriteLine($"index {i}= {InputArray[i]}");  
            }

            if((int)Char.GetNumericValue(text[i]) > 0 && i > 0)
            {
               if((int)Char.GetNumericValue(text[i - 1]) > 0) {
                    InputArray[i] = (int)Char.GetNumericValue(text[i]);
                    Console.WriteLine($"index {i}= {InputArray[i]}");
                }    
            }
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

// задаем массив
int[] array = new int[dlina];

// запускаем функию заполнения массива
FillArray(array, text);


int res = ResCount(array);
Console.Write($"Количество цифр, которые > 0 из всех введенных символов =  {res}");

