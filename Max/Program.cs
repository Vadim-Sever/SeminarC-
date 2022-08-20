int a=2;
int b=3;
int c=4;
int v=5;

int max=a;

if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;
if (v>max) max=v;

Console.Write("max=");
Console.WriteLine(max);