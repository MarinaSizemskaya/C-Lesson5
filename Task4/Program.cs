// Задача 4: Задайте массив из 12 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// [5, 18, 123, 6, 2] -> 1

using System;
using static System.Console;
Clear();

int[] array = new int [12];
for (int i = 0; i < 12; i++)
{
    array[i]=new Random().Next(-50, 151);
    Write(array[i] + " ");
}
int count = 0;
for (int i = 0; i < 12; i++)
{
    if(array[i]>=10 && array[i]<=99)
    {
        count++;
    }
}
WriteLine();
WriteLine($"{count}");