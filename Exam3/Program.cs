Console.WriteLine("Your name?");
string username = Console.ReadLine();

if(username.ToLower()=="vadim") {
    Console.WriteLine("oooooo, Vadim");
} else {
    Console.Write("Hi,");
    Console.WriteLine(username);
}