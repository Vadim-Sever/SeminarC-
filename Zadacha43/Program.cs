// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1


Console.Clear();
int k1,k2,b1,b2;
int res = 0;
Console.WriteLine("Введите k1");
k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1");
b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1");
b2 = Convert.ToInt32(Console.ReadLine());


if (((k1 == 0) && (b1 == 0)) || ((k2 == 0) && (b2 == 0))) {
    Console.WriteLine("Это не прямая");
} else if ((k1 * b2) == (k2 * b1)) {
    Console.WriteLine("Прямые параллельны");
} else { 
    res = (b2 - b1)/(k1 - k2);
}
 
Console.WriteLine();
Console.WriteLine($"Точка пересечения x = {res}; y = {k1 * res + b1}");

