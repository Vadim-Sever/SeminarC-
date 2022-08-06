internal class Program
{
    private static void Main(string[] args)
    {
        double Number1 = new Random().Next(1, 10);
        Console. WriteLine(Number1);
        double Number2 = new Random().Next(1, 10);
        Console. WriteLine(Number2);
        double Sum = Number1 / Number2;
        Console.WriteLine(Sum);
    }
}