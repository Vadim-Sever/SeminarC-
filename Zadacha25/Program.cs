Console.WriteLine("Укажите число, которое будем возводить в степень");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите степень , в которую вохзвести первое число");
int n2 = Convert.ToInt32(Console.ReadLine());
double n3 = 0;
for (int i = 0; i < 1; i++)
{
    n3 = Math.Pow(n1, n2);
}



Console.WriteLine(n3);