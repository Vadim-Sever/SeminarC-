Console.Clear();

string? n1 = Console.ReadLine();
int dlina = n1.Length;
int summa = 0;


for (int i = 0; i < dlina; i++) {
    int z = (int)Char.GetNumericValue(n1[i]);
    summa = z + summa;
}

Console.WriteLine(summa);