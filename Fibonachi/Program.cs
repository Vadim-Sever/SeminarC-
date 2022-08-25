Console.Clear();

double Fibonachi(double n) {

    if(n == 1 || n == 2) return 1;
    else return Fibonachi(n-1) + Fibonachi(n-2);
    }

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(Fibonachi(i));
}
