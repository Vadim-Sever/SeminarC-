//функия(метод) заполнения массива
void fillArray(int[] collection) {
    int length = collection.Length;
    int index = 0;

    while (index < length) {
        collection[index] = new Random().Next(1,10);
        index++;
    }

}

//функия(метод) печати массива
void ArrayPrint(int[] massiv) {
    int count = massiv.Length;
    int index = 0;

    while (index < count) {
        Console.WriteLine(massiv[index]);
        index++;
    }
}

//функия(метод) поиска элемента в массиве
int indexof(int[] collection, int find) {
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count) {
        
        if (collection[index] == find) {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];

fillArray(array);
ArrayPrint(array);
Console.WriteLine();

int pos = indexof(array, 7);
Console.WriteLine(pos);