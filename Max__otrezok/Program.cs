Console.Clear();

int num = new Random().Next(10,100);
int a1 = num / 10; // покажет число во 2ом разряде
int a2 = num % 10; // покажет остаток от деления,т.е то число, которое целочисленно не еделится на 10
int max = a1;
if (max < a2 ) {
    max = a2;
}
Console.WriteLine($"Максимальная ифра числа {num} = {max}");


// способ определения максимальной ифры в 3х значном числе без использования массива
int num2 = new Random().Next(100,1000);
a1 = num2 / 100;
Console.WriteLine(a1);
a2 = num2 / 10;
int a22 = a2 % 10; // покажет число во 2ом разряде
Console.WriteLine(a22);
int a3 = num2 % 10; // покажет остаток от деления,т.е то число, которое целочисленно не еделится на 10
Console.WriteLine(a3);
max = a1;
if (max < a22 ) {
    max = a22;
}
if (max < a3) {
    max = a3;
}
Console.WriteLine($"Максимальная ифра числа {num2} = {max}");