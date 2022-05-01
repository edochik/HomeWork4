
// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int a = 2;
int b = 4;

void printResult(int a)
{
    Console.Write(a);
}

int twoNumbers(int a, int b)
{
    int result = a;
    for (int i = 0; i < b; i++)
    {
        result = a * result;
    }
    return result;
}

printResult(twoNumbers(a,b));