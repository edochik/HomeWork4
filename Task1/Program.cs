// Найти сумму чисел от 1 до А
/*
int n = 100;


int Method(int a)
{
    n = n * (n + 1) / 2;
    return n;
}


int Method2(int b)
{
    int result = 0;
    for (int i = 0; i < 1; i++)
    {
        result = result + b;
        //Console.Write($" {result}");
    }
    return result;
}

Console.WriteLine(Method(n));
Console.WriteLine(Method2(n));*/
using System.Diagnostics;

int a = 100_000;

int var1(int n)
{
    int[] arr = new int[n + 1];
    for (int i = 0; i <= n; i++)
    {
        arr[i] = i;
    }
    int res = 0;
    for (int i = 0; i <= n; i++)
    {
        res += arr[i];
    }
    return res;
}

int var2(int n)
{
    int res = 0;
    for (int i = 0; i <= n; i++)
    {
        res += i;
    }
    return res;
}

int var3(int n)
{
    n = n * (n + 1) / 2;
    return n;
}

Stopwatch sw = new Stopwatch();
sw.Start();
Console.WriteLine(var1(a));
sw.Stop();
Console.WriteLine(sw.ElapsedMilliseconds);
Console.WriteLine(var2(a));

Console.WriteLine(var3(a));