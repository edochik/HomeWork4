
// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int a = 123;

void PrintNumber(int a)
{
    Console.WriteLine(a);
}


int Method(int a)
{
    int result = 0;
    while (a > 0)
    {
        result += a % 10;
        a = a / 10;
    }
    return result;
}
PrintNumber(Method(a));