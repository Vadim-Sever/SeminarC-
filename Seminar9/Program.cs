Console.Clear();

Console.WriteLine("Input N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input M");
int M = Convert.ToInt32(Console.ReadLine());;

Console.WriteLine();
PrintNum(M, N);

void PrintNum(int start, int finish) {
    while(start<finish) {
        if(start< finish) 
    {Console.Write(start + ", ");
    PrintNum(start + 1,finish);
    }
    if(start == finish) 
    {Console.Write(start + " ");
    PrintNum(start + 1,finish);
    }
    }
}