int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if (a > max) max = a;
if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);