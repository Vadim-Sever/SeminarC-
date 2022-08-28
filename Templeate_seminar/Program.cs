//пример заикленного условия на проверку правда ложь
double varA;

while(true) {
Console.Write("Please, Your text");
if(double.TryParse(Console.ReadLine(), out varA))
    break;
Console.WriteLine("Error");
}

Console.WriteLine($"A={varA}");

// проверка преобразования введенных данных в Int

Console.Write("Input A");
string number_1s = Console.ReadLine() ?? "";
int number_1i;

Console.Write("Input B");
string number_2s = Console.ReadLine() ?? "";
int number_2i;

Console.Write("Input C");
string number_3s = Console.ReadLine() ?? "";
int number_3i;


bool isCorrectInput = true;
if(!int.TryParse(number_1s, out number_1i)) isCorrectInput = false; // если это значение преобразования типа не выполнилось(то при инвертаии) программа зайдет в условие и изменит значение переменной на false
if(!int.TryParse(number_2s, out number_2i)) isCorrectInput = false;
if(!int.TryParse(number_3s, out number_3i)) isCorrectInput = false;

if(!isCorrectInput) {
    Console.WriteLine("Ошибка при вводе данных");
}

// использование тернарного оператора для создания переменных
 bool varAA = false;
 bool varB = true;
 bool varC = false;
 bool varD = true;
 
 int number1 = (varAA?1000:0) + (varB?100:0) + (varC?10:0) + (varD?1:0);
Console.WriteLine(number1);

 int number2 = (varAA?8:0) + (varB?4:0) + (varC?2:0) + (varD?1:0);
 Console.WriteLine(number2);

// механизм перехвата исключений

// static void InitCoordinateUser(ref int x) {
// try
// {
//     Console.Write("Input Oblast");
//     x = int.Parse(Console.ReadLine() ?? "");

//     // Console.Write("Input Y");
//     // y = int.Parse(Console.ReadLine() ?? "");

// }
// catch (Exception exc) // вызываем класс Учуезешщ и у его внутри есть установленная переменная exc
// {
//     Console.WriteLine($"Ошибка ввода {exc.Message}");
// }
// }


static int InitCoordinateUser() {
    int x = 0;
    try
    {
        Console.Write("Input Oblast");
        x = int.Parse(Console.ReadLine() ?? "");

        // Console.Write("Input Y");
        // y = int.Parse(Console.ReadLine() ?? "");

    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода {exc.Message}");
    }
    return x;
}


// использование условия Switch для опредления четверти оси координат
void PrintOblKoordinate() {
    int input = InitCoordinateUser();
    switch (input)
    {
        case 1:
        Console.WriteLine("X > 0 | Y> 0");
        break;

        case 2:
        Console.WriteLine("X > 0 | Y< 0");
        break;

        case 3:
        Console.WriteLine("X < 0 | Y> 0");
        break;

        case 4:
        Console.WriteLine("X < 0 | Y< 0");
        break;
        
        default:
          Console.WriteLine("Error");
          break;
    }

}

PrintOblKoordinate();
