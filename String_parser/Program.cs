Console.Clear();

string text = "(2,3) (4,2) (5,7) (8,2)"
                .Replace("(","")
                .Replace(")","")
                ;

var data = text.Split(" ") // возьми текст и раздели его
                .Select(item => item.Split(",")) //сделай выборку Itemб где разделитель равен ,
                .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1]))) // сделайте обработку массива и преобразование в координаты Х и Y
                .Where(e => e.x % 2 == 0) // выбери пары где первы элемент четный
                .Select(point => (point.x * 10, point.y)) // для полученной выше выборки умножь 1ый элемент на 10
                .ToArray(); // запиши выборки в массив

for (int i = 0; i < data.Length; i++)
{
 
    Console.WriteLine(data[i]);
    Console.WriteLine();
}