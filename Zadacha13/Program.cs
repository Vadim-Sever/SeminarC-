string? text = Console.ReadLine();

if (text.Length < 3) {
    Console.WriteLine("третьей цифры нет");
} else {
    Console.WriteLine(text[2]);
}
