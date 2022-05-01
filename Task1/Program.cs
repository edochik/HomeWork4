// Найти сумму чисел от 1 до А
// данную задачу разбирали на 5 практическом уроке.

int n = 100;

void PrintVar(int a)
{
    Console.WriteLine(a);
}
int var(int a)
{
    int res = 0;
    for (int i = 0; i <= a; i++)
    {
        res += i;
    }
    return res;
}

PrintVar(var(n));