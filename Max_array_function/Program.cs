int Max(int arg1, int arg2, int arg3) {
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
} 

int[] array = {1,2,33,4,21,6,6,7,4,2,334,21};
int n = array.Length;
int find = 21;
int index = 0;

while (index < n) {
    if (find == array[index]) {
    Console.Write("find=");
    Console.WriteLine(index);
    break;
    }
    index++;
}



// int max1=Max(a1,b1,c1);
// int max2=Max(a2,b2,c2);
// int max3=Max(a3,b3,c3);

// int result=Max(max,max2,max3);

// Console.Write("max=");
// Console.WriteLine(result);