string Method4(int count, string text) {
    int index = 0;
    string result = string.Empty;

        while (index < count) {
            result = result + text;
            index++;
        }
    return result;
}

string result = Method4(10, "z");
Console.WriteLine(result);

string Method4(int count, string text) {
    string result = string.Empty;

        for(int index = 0; index < count; index++) {
            result = result + text;
        }

    return result;
}


string result = Method4(10, "z");
Console.WriteLine(result);