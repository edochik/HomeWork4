//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*1. Создать массив.
2. Напечатать массив. 
3. Вывести 8 элементов.*/

int[] CreateArr(int numbers)
{
    int[] arr = new int[numbers];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]}");
    }
}

PrintArr(CreateArr(8));