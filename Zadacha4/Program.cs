// max of 3

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > a) {
    max = b;
    if (c > b) {
        max = c;
    }
}

Console.WriteLine(max);

// функцией

int Max(int arg1, int arg2, int arg3) {
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}


max = Max(a,b,c);

Console.Write("max=");
Console.WriteLine(max);